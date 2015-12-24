using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using Factory.ObjectClasses;
using Factory.UserForms;
using Microsoft.SqlServer.Server;
using Npgsql;
using NpgsqlTypes;

namespace Factory.Controls
{
    public static class DataBaseController
    {
        private static NpgsqlConnection _npgConnection;

        private const string ConfigFileName = "DataBaseConfif.cfg";

        /// <summary>
        /// Конфигаруция подключения к базе данных
        /// </summary>
        private static string _server;
        private static string _port;
        private static string _user;
        private static string _pass;
        private static string _dbName;

        public static void CreatePatternConfigFile()
        {
            using (FileStream fs = File.Create(ConfigFileName))
            {
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    sw.WriteLine("Server=");
                    sw.WriteLine("Port=");
                    sw.WriteLine("User=");
                    sw.WriteLine("Password=");
                    sw.WriteLine("Database=");
                    sw.WriteLine();
                    sw.WriteLine("Данные вводить без ковычек и других выделяющих знаков" +
                                 "сразу после символа \"=\"");
                }
            }
        }

        private static void ReadConfig()
        {
            if (!File.Exists(ConfigFileName))
            {
                CreatePatternConfigFile();
            }
            var strings = File.ReadAllLines(ConfigFileName);
            if (strings.Count() < 5)
            {
                throw new Exception("Неверно заполнен файл конфигурации");
            }
            _server = strings[0].Split('=').Last();
            _port = strings[1].Split('=').Last();
            _user = strings[2].Split('=').Last();
            _pass = strings[3].Split('=').Last();
            _dbName = strings[4].Split('=').Last();
        }

        public static void Connect()
        {
            ReadConfig();
            _npgConnection = new NpgsqlConnection("Server=" + _server + ";" +
                                                  "Port=" + _port + ";" +
                                                  "User=" + _user + ";" +
                                                  "Password=" + _pass + ";" +
                                                  "Database=" + _dbName + ";");
            try
            {
                _npgConnection.Open();
            }
            catch (Exception ex)
            {
                throw new Exception("Ошибка подключения к базе данных " + ex.Message + Environment.NewLine
                                    + "ПРОВЕРЬТЕ ФАЙЛ КОНФИГУРАЦИИ");
            }
        }

        /// <summary>
        /// Получение списка компонентов
        /// Без аргументов вернет спискок всех компонентов
        /// </summary>
        /// <param name="product">Необязательный аргумент - продукт, для которого выбираются компоненты</param>
        /// <returns></returns>
        public static List<Component> GetComponentList(Product product = null)
        {
            string command = "SELECT component_id, component_name, component_price, description FROM components;";
            if (product != null)
            {
                command =
                    "SELECT components.component_id, component_name, component_price, components.description, component_count, shop_name FROM components " +
                    "LEFT JOIN product_picking ON components.component_id = product_picking.component_id " +
                    "LEFT JOIN shops ON shops.shop_id = product_picking.shop_id WHERE product_id = @productId ORDER BY component_name";
            }
            var componentList = new List<Component>();
            NpgsqlCommand npgCommand = new NpgsqlCommand(command, _npgConnection);
            if (product != null)
            {
                npgCommand.Parameters.Add("@productId", NpgsqlDbType.Uuid).Value = product.GetUuid();
            }
            try
            {
                var npgReader = npgCommand.ExecuteReader();
                while (npgReader.HasRows)
                {
                    npgReader.Read();
                    var component = new Component
                    {
                        Uuid = npgReader.GetValue(0).ToString(),
                        Name = npgReader.GetValue(1).ToString(),
                        Price = npgReader.GetValue(2).ToString(),
                        Description = npgReader.GetValue(3).ToString()
                    };
                    if (product != null)
                    {
                        component.Count = npgReader.GetValue(4).ToString();
                        component.ShopName = npgReader.GetValue(5).ToString();
                    }
                    componentList.Add(component);
                }
                npgReader.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Ошибка получения списка компонент " + ex.Message);
            }
            return componentList;
        }

        /// <summary>
        /// Получение списка продуктов
        /// </summary>
        /// <returns>Список продуктов</returns>
        public static List<Product> GetProductList()
        {
            string command = "SELECT product_id, product_name, product_price, description FROM products";
            var productList = new List<Product>();
            NpgsqlCommand npgCommand = new NpgsqlCommand(command, _npgConnection);
            try
            {
                var npgReader = npgCommand.ExecuteReader();
                while (npgReader.HasRows)
                {
                    npgReader.Read();
                    var product = new Product
                    {
                        Uuid = npgReader.GetValue(0).ToString(),
                        Name = npgReader.GetValue(1).ToString(),
                        Price = npgReader.GetValue(2).ToString(),
                        Description = npgReader.GetValue(3).ToString(),
                    };
                    productList.Add(product);
                }
                npgReader.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Ошибка получения списка компонент " + ex.Message);
            }
            return productList;
        }

        /// <summary>
        /// Применяет измененные поля передаваемого аргумента
        /// к продукту с указанным в аргументе uuid
        /// </summary>
        /// <param name="product">Продукт с измененными полями</param>
        public static void ChangeProductFields(Product product)
        {
            string command = "UPDATE products SET product_name = @name, product_price = @price, description = @descript WHERE product_id = @id";
            NpgsqlCommand npgCommand = new NpgsqlCommand(command, _npgConnection);
            npgCommand.Parameters.Add("@name", NpgsqlDbType.Text).Value = product.Name;
            npgCommand.Parameters.Add("@descript", NpgsqlDbType.Text).Value = product.Description;
            npgCommand.Parameters.Add("@price", NpgsqlDbType.Integer).Value = product.Price;
            npgCommand.Parameters.Add("@id", NpgsqlDbType.Uuid).Value = product.GetUuid();
            try
            {
                npgCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ошибка изменения полей продукта. " + ex.Message);
            }
        }

        /// <summary>
        /// Поученеи списка компонентов, отстутсвующих в
        /// рецепте продукта
        /// </summary>
        /// <param name="product">Продукт</param>
        /// <returns>Список компонентов</returns>
        public static List<Component> GetNewComponentsForProduct(Product product)
        {
            string command = "SELECT components.component_id, component_name, component_price, description FROM components " +
                               "WHERE component_id NOT IN (SELECT components.component_id FROM components " +
                                "LEFT JOIN product_picking ON components.component_id = product_picking.component_id " +
                                "WHERE product_id = @productId)";
            var componentList = new List<Component>();
            NpgsqlCommand npgCommand = new NpgsqlCommand(command, _npgConnection);
            if (product != null)
            {
                npgCommand.Parameters.Add("@productId", NpgsqlDbType.Uuid).Value = product.GetUuid();
            }
            try
            {
                var npgReader = npgCommand.ExecuteReader();
                while (npgReader.HasRows)
                {
                    npgReader.Read();
                    var component = new Component
                    {
                        Uuid = npgReader.GetValue(0).ToString(),
                        Name = npgReader.GetValue(1).ToString(),
                        Price = npgReader.GetValue(2).ToString(),
                        Description = npgReader.GetValue(3).ToString()
                    };
                    componentList.Add(component);
                }
                npgReader.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Ошибка получения списка компонент " + ex.Message);
            }
            return componentList;
        }

        /// <summary>
        /// Добавление компонента к рецепту продукта
        /// </summary>
        /// <param name="product">Продукт</param>
        /// <param name="component">Компонент</param>
        public static void AddComponentToProduct(Product product, Component component)
        {
            string command = "INSERT INTO product_picking (product_id, component_id, shop_id) " +
                             "VALUES (@productId, @componentId, @shopId)";
            NpgsqlCommand npgCommand = new NpgsqlCommand(command, _npgConnection);
            npgCommand.Parameters.Add("@productId", NpgsqlDbType.Uuid).Value = product.GetUuid();
            npgCommand.Parameters.Add("@componentId", NpgsqlDbType.Uuid).Value = component.GetUuid();
            npgCommand.Parameters.Add("@shopId", NpgsqlDbType.Uuid).Value = component.ShopUuid;
            try
            {
                npgCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ошибка добавления компонента. " + ex.Message);
            }
        }

        /// <summary>
        /// Получение списка цехов
        /// </summary>
        /// <returns></returns>
        public static List<Shop> GetShops()
        {
            string command = "SELECT shop_id, shop_name, description FROM shops";
            var shopsList = new List<Shop>();
            NpgsqlCommand npgCommand = new NpgsqlCommand(command, _npgConnection);
            try
            {
                var npgReader = npgCommand.ExecuteReader();
                while (npgReader.HasRows)
                {
                    npgReader.Read();
                    var product = new Shop
                    {
                        Uuid = npgReader.GetValue(0).ToString(),
                        Name = npgReader.GetValue(1).ToString(),
                        Description = npgReader.GetValue(2).ToString(),
                    };
                    shopsList.Add(product);
                }
                npgReader.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Ошибка получения списка цехов " + ex.Message);
            }
            return shopsList;

        }

        /// <summary>
        /// Обновление количества компонента в продукте
        /// </summary>
        /// <param name="product">Продукт</param>
        /// <param name="component">Компонент</param>
        public static void UpdateComponentCount(Product product, Component component)
        {
            string command = "UPDATE product_picking SET component_count = @comCount " +
                             "WHERE component_id = @compId AND product_id = @prodId";
            NpgsqlCommand npgCommand = new NpgsqlCommand(command, _npgConnection);
            npgCommand.Parameters.Add("@compId", NpgsqlDbType.Uuid).Value = component.GetUuid();
            npgCommand.Parameters.Add("@prodId", NpgsqlDbType.Uuid).Value = product.GetUuid();
            npgCommand.Parameters.Add("@comCount", NpgsqlDbType.Integer).Value = component.Count;
            try
            {
                npgCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ошибка измененеия свойств компонента. " + ex.Message);
            }
        }

        /// <summary>
        /// Удаление компонента из рецепта продукта
        /// </summary>
        /// <param name="product">Продукт</param>
        /// <param name="component">Удаляемый компонент</param>
        public static void DeleteCoponentFromProduct(Product product, Component component)
        {
            string command = "DELETE FROM product_picking " +
                             "WHERE product_id = @prodId AND component_id = @compId";
            NpgsqlCommand npgCommand = new NpgsqlCommand(command, _npgConnection);
            npgCommand.Parameters.Add("@compId", NpgsqlDbType.Uuid).Value = component.GetUuid();
            npgCommand.Parameters.Add("@prodId", NpgsqlDbType.Uuid).Value = product.GetUuid();
            try
            {
                npgCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ошибка исключения компонента. " + ex.Message);
            }
        }

        /// <summary>
        /// Добавляет компонент в базу данных
        /// </summary>
        /// <param name="component">Компонент</param>
        public static void AddComponentToComponentList(Component component)
        {
            string command = "SELECT * FROM components WHERE component_name = @name";
            NpgsqlCommand npgCheckCommand = new NpgsqlCommand(command, _npgConnection);
            npgCheckCommand.Parameters.Add("@name", NpgsqlDbType.Text).Value = component.Name;
            try
            {
                var npgReader = npgCheckCommand.ExecuteReader();
                if (npgReader.HasRows)
                {
                    npgReader.Close();
                    throw new Exception("Компонент с таким именем уже существует");
                }
                npgReader.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Ошибка добавления: " + ex.Message);
            }

            command = "INSERT INTO components(component_name, component_price, description) VALUES (@compName, @compPrice, @descript)";
            NpgsqlCommand npgCommand = new NpgsqlCommand(command, _npgConnection);
            npgCommand.Parameters.Add("@compName", NpgsqlDbType.Text).Value = component.Name;
            npgCommand.Parameters.Add("@descript", NpgsqlDbType.Text).Value = component.Description;
            npgCommand.Parameters.Add("@compPrice", NpgsqlDbType.Integer).Value = component.Price;
            try
            {
                npgCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ошибка добавления компонента. " + ex.Message);
            }
        }

        /// <summary>
        /// Добавление продукта в базу данных
        /// </summary>
        /// <param name="product">Добавляемый продукт</param>
        public static void AddProductToProductList(Product product)
        {
            string command = "SELECT * FROM products WHERE product_name = @name";
            NpgsqlCommand npgCheckCommand = new NpgsqlCommand(command, _npgConnection);
            npgCheckCommand.Parameters.Add("@name", NpgsqlDbType.Text).Value = product.Name;
            try
            {
                var npgReader = npgCheckCommand.ExecuteReader();
                if (npgReader.HasRows)
                {
                    npgReader.Close();
                    throw new Exception("Продукт с таким именем уже существует");
                }
                npgReader.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Ошибка добавления: " + ex.Message);
            }

            command = "INSERT INTO products (product_name, description) " +
                             "VALUES (@name, @descript)";
            NpgsqlCommand npgCommand = new NpgsqlCommand(command, _npgConnection);
            npgCommand.Parameters.Add("@name", NpgsqlDbType.Text).Value = product.Name;
            npgCommand.Parameters.Add("@descript", NpgsqlDbType.Text).Value = product.Description;
            try
            {
                npgCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ошибка добавления продукта: " + ex.Message);
            }
        }

        /// <summary>
        /// Удаление продуета из базы данных
        /// </summary>
        /// <param name="product">Удаляемый продукт</param>
        public static void DeleteProduct(Product product)
        {
            string command = "DELETE FROM products WHERE product_id = @prodId";
            NpgsqlCommand npgCommand = new NpgsqlCommand(command, _npgConnection);
            npgCommand.Parameters.Add("@prodId", NpgsqlDbType.Uuid).Value = product.GetUuid();
            try
            {
                npgCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ошибка удаления продукта: " + ex.Message);
            }
        }

        /// <summary>
        /// Изменение полей компонента
        /// </summary>
        /// <param name="component">Изменяемый компонент</param>
        public static void ChangeComponentFields(Component component)
        {
            string command = "UPDATE components SET component_name = @name, component_price = @price, description = @descript WHERE component_id = @id";
            NpgsqlCommand npgCommand = new NpgsqlCommand(command, _npgConnection);
            npgCommand.Parameters.Add("@name", NpgsqlDbType.Text).Value = component.Name;
            npgCommand.Parameters.Add("@descript", NpgsqlDbType.Text).Value = component.Description;
            npgCommand.Parameters.Add("@price", NpgsqlDbType.Integer).Value = component.Price;
            npgCommand.Parameters.Add("@id", NpgsqlDbType.Uuid).Value = component.GetUuid();
            try
            {
                npgCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ошибка изменения полей компонента. " + ex.Message);
            }
        }

        /// <summary>
        /// Получение продуктов, использующих компонент
        /// </summary>
        /// <param name="component">Компонент</param>
        /// <returns>Список продуктов</returns>
        public static List<Product> GetProductsWithComponent(Component component)
        {
            string command =
                "SELECT DISTINCT product_name, product_price, description " +
                "FROM products LEFT JOIN product_picking ON products.product_id = product_picking.product_id " +
                "WHERE component_id = @compId";
            var productList = new List<Product>();
            NpgsqlCommand npgCommand = new NpgsqlCommand(command, _npgConnection);
            npgCommand.Parameters.Add("@compId", NpgsqlDbType.Uuid).Value = component.GetUuid();
            try
            {
                var npgReader = npgCommand.ExecuteReader();
                while (npgReader.HasRows)
                {
                    npgReader.Read();
                    var product = new Product
                    {
                        Name = npgReader.GetValue(0).ToString(),
                        Price = npgReader.GetValue(1).ToString(),
                        Description = npgReader.GetValue(2).ToString(),
                    };
                    productList.Add(product);
                }
                npgReader.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Ошибка получения списка компонент " + ex.Message);
            }
            return productList;
        }

        /// <summary>
        /// Удаление компонента из базы данных.
        /// Выбрасывает исключение при использовании данного компонента в продуктах
        /// </summary>
        /// <param name="component">Удаляемый компонент</param>
        public static void DeleteComponentFromDataBase(Component component)
        {
            string command =
                "SELECT DISTINCT product_name " +
                "FROM products LEFT JOIN product_picking ON products.product_id = product_picking.product_id " +
                "WHERE component_id = @compId";
            NpgsqlCommand npgCommand = new NpgsqlCommand(command, _npgConnection);
            npgCommand.Parameters.Add("@compId", NpgsqlDbType.Uuid).Value = component.GetUuid();
            try
            {
                var npgReader = npgCommand.ExecuteReader();
                if (npgReader.HasRows)
                {
                    npgReader.Close();
                    throw new Exception("Компонент используется в продуктах");
                }
                npgReader.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Ошибка удаления компонента: " + ex.Message);
            }

            command = "DELETE FROM components WHERE component_id = @compId";
            npgCommand = new NpgsqlCommand(command, _npgConnection);
            npgCommand.Parameters.Add("@compId", NpgsqlDbType.Uuid).Value = component.GetUuid();
            try
            {
                npgCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ошибка удаления компонента: " + ex.Message);
            }
        }

        /// <summary>
        /// Изменение информации о цехе в базе данных
        /// </summary>
        /// <param name="shop">Изменяемый цех с уже добавленными измененими</param>
        public static void ChangeShopFields(Shop shop)
        {
            string command = "UPDATE shops SET shop_name = @name, description = @decscript WHERE shop_id = @shopId";
            NpgsqlCommand npgCommand = new NpgsqlCommand(command, _npgConnection);
            npgCommand.Parameters.Add("@shopId", NpgsqlDbType.Uuid).Value = shop.Uuid;
            npgCommand.Parameters.Add("@name", NpgsqlDbType.Text).Value = shop.Name;
            npgCommand.Parameters.Add("@decscript", NpgsqlDbType.Text).Value = shop.Description;
            try
            {
                npgCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ошибка удаления продукта: " + ex.Message);
            }
        }

        /// <summary>
        /// Удаление цеха из базы данных
        /// Выбрасывает исключение при наличии продуктов, обрабатываемых в данном цехе
        /// </summary>
        /// <param name="shop">Удаляемый цех</param>
        public static void DeleteShopFromDataBase(Shop shop)
        {
            string command =
                "SELECT DISTINCT shop_id FROM product_picking WHERE shop_id = @id";
            var npgCommand = new NpgsqlCommand(command, _npgConnection);
            npgCommand.Parameters.Add("@id", NpgsqlDbType.Uuid).Value = shop.Uuid;
            try
            {
                var npgReader = npgCommand.ExecuteReader();
                if (npgReader.HasRows)
                {
                    npgReader.Close();
                    throw new Exception("В цехе еще ведется производство");
                }
                npgReader.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Ошибка удаления цеха: " + ex.Message);
            }

            command = "DELETE FROM shops WHERE shop_id = @id";
            npgCommand = new NpgsqlCommand(command, _npgConnection);
            npgCommand.Parameters.Add("@id", NpgsqlDbType.Uuid).Value = shop.Uuid;
            try
            {
                npgCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ошибка удаления цеха: " + ex.Message);
            }
        }

        /// <summary>
        /// Добавление цеха в бвзу данных
        /// </summary>
        /// <param name="shop">Цех</param>
        public static void AddShopToShopLIst(Shop shop)
        {
            string command =
                "SELECT DISTINCT shop_id FROM shops WHERE shop_name = @name";
            var npgCommand = new NpgsqlCommand(command, _npgConnection);
            npgCommand.Parameters.Add("@name", NpgsqlDbType.Text).Value = shop.Name;
            try
            {
                var npgReader = npgCommand.ExecuteReader();
                if (npgReader.HasRows)
                {
                    npgReader.Close();
                    throw new Exception("Цех с таким названием уже существует");
                }
                npgReader.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Ошибка добавления цеха: " + ex.Message);
            }

            command = "INSERT INTO shops (shop_name, description) VALUES (@name, @descript)";
            npgCommand = new NpgsqlCommand(command, _npgConnection);
            npgCommand.Parameters.Add("@name", NpgsqlDbType.Text).Value = shop.Name;
            npgCommand.Parameters.Add("@descript", NpgsqlDbType.Text).Value = shop.Description;
            try
            {
                npgCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ошибка добавления цеха: " + ex.Message);
            }
        }

        /// <summary>
        /// Получение списка работников
        /// </summary>
        /// <returns>Список рабоиников</returns>
        public static List<Worker> GetWorkerList()
        {
            string command = "SELECT worker_name, worker_phone, shop_name, post_name, worker_id, " +
                             "workers.shop_id, workers.post_id FROM workers " +
                             "LEFT JOIN shops ON workers.shop_id = shops.shop_id " +
                             "LEFT JOIN posts ON workers.post_id = posts.post_id";
            var workerList = new List<Worker>();
            NpgsqlCommand npgCommand = new NpgsqlCommand(command, _npgConnection);
            try
            {
                var npgReader = npgCommand.ExecuteReader();
                while (npgReader.HasRows)
                {
                    npgReader.Read();
                    var worker = new Worker
                    {
                        Name = npgReader.GetValue(0).ToString(),
                        Phone = npgReader.GetValue(1).ToString(),
                        ShopName = npgReader.GetValue(2).ToString(),
                        Post = npgReader.GetValue(3).ToString(),
                        Uuid = npgReader.GetValue(4).ToString(),
                        ShopUuid = npgReader.GetValue(5).ToString(),
                        PostUuid = npgReader.GetValue(6).ToString(),
                    };
                    workerList.Add(worker);
                }
                npgReader.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Ошибка получения списка работников " + ex.Message);
            }
            return workerList;
        }

        /// <summary>
        /// Удаление работника из базы данных
        /// </summary>
        /// <param name="worker">Работник</param>
        public static void DeleteWorkerFromDataBase(Worker worker)
        {
            string command = "DELETE FROM workers WHERE worker_id = @Id";
            var npgCommand = new NpgsqlCommand(command, _npgConnection);
            npgCommand.Parameters.Add("@id", NpgsqlDbType.Uuid).Value = worker.Uuid;
            try
            {
                npgCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ошибка удаления сотрудника из базы данных: " + ex.Message);
            }
        }

        /// <summary>
        /// Изменяет поля сотрудника
        /// </summary>
        /// <param name="worker">Сотрудник</param>
        public static void ChangeWorkerFields(Worker worker)
        {
            string command = "UPDATE workers SET worker_name = @name, worker_phone = @phone, post_id = @postId, " +
                             "shop_id = @shopId WHERE worker_id = @workerId";
            NpgsqlCommand npgCommand = new NpgsqlCommand(command, _npgConnection);
            npgCommand.Parameters.Add("@workerId", NpgsqlDbType.Uuid).Value = worker.Uuid;
            npgCommand.Parameters.Add("@name", NpgsqlDbType.Text).Value = worker.Name;
            npgCommand.Parameters.Add("@phone", NpgsqlDbType.Text).Value = worker.Phone;
            npgCommand.Parameters.Add("@postId", NpgsqlDbType.Uuid).Value = worker.PostUuid;
            npgCommand.Parameters.Add("@shopId", NpgsqlDbType.Uuid).Value = worker.ShopUuid;
            try
            {
                npgCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ошибка удаления продукта: " + ex.Message);
            }
        }

        /// <summary>
        /// Получение списка должностей
        /// </summary>
        /// <returns>Должность</returns>
        public static List<Post> GetPostList()
        {
            string command = "SELECT post_id, post_name, post_duty FROM posts";
            var postList = new List<Post>();
            NpgsqlCommand npgCommand = new NpgsqlCommand(command, _npgConnection);
            try
            {
                var npgReader = npgCommand.ExecuteReader();
                while (npgReader.HasRows)
                {
                    npgReader.Read();
                    var post = new Post
                    {
                        Uuid = npgReader.GetValue(0).ToString(),
                        Name = npgReader.GetValue(1).ToString(),
                        Duty = npgReader.GetValue(2).ToString()
                    };
                    postList.Add(post);
                }
                npgReader.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Ошибка получения списка работников " + ex.Message);
            }
            return postList;
        }

        /// <summary>
        /// Добавление нового работника
        /// </summary>
        /// <param name="worker">Работник</param>
        public static void AddWorkerToDataBase(Worker worker)
        {
            var command = "INSERT INTO workers (worker_name, worker_phone, post_id, shop_id)" +
                          " VALUES (@name, @phone, @postId, @shopId)";
            var npgCommand = new NpgsqlCommand(command, _npgConnection);
            npgCommand.Parameters.Add("@name", NpgsqlDbType.Text).Value = worker.Name;
            npgCommand.Parameters.Add("@phone", NpgsqlDbType.Text).Value = worker.Phone;
            npgCommand.Parameters.Add("@postId", NpgsqlDbType.Uuid).Value = worker.PostUuid;
            npgCommand.Parameters.Add("@shopId", NpgsqlDbType.Uuid).Value = worker.ShopUuid;
            try
            {
                npgCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ошибка регистрации работника: " + ex.Message);
            }
        }

        /// <summary>
        /// Одновление полей должности
        /// </summary>
        /// <param name="post">Измененная должность</param>
        public static void ChangePostFilds(Post post)
        {
            string command = "UPDATE posts SET post_name = @name, post_duty = @duty WHERE post_id = @postId";
            NpgsqlCommand npgCommand = new NpgsqlCommand(command, _npgConnection);
            npgCommand.Parameters.Add("@postId", NpgsqlDbType.Uuid).Value = post.Uuid;
            npgCommand.Parameters.Add("@name", NpgsqlDbType.Text).Value = post.Name;
            npgCommand.Parameters.Add("@duty", NpgsqlDbType.Text).Value = post.Duty;
            try
            {
                npgCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ошибка удаления продукта: " + ex.Message);
            }
        }

        /// <summary>
        /// Удаление должности из базы данных
        /// </summary>
        /// <param name="post">Удаляемая должность</param>
        public static void DeletePostFromDataBase(Post post)
        {
            string command =
                "SELECT DISTINCT post_id FROM workers WHERE post_id = @id";
            var npgCommand = new NpgsqlCommand(command, _npgConnection);
            npgCommand.Parameters.Add("@id", NpgsqlDbType.Uuid).Value = post.Uuid;
            try
            {
                var npgReader = npgCommand.ExecuteReader();
                if (npgReader.HasRows)
                {
                    npgReader.Close();
                    throw new Exception("Есть сотрудники на этой должности");
                }
                npgReader.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Ошибка удаления должности: " + ex.Message);
            }

            command = "DELETE FROM posts WHERE post_id = @id";
            npgCommand = new NpgsqlCommand(command, _npgConnection);
            npgCommand.Parameters.Add("@id", NpgsqlDbType.Uuid).Value = post.Uuid;
            try
            {
                npgCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ошибка удаления должности: " + ex.Message);
            }
        }

        /// <summary>
        /// Добавление должноти в базу данных
        /// </summary>
        /// <param name="post">должность</param>
        public static void AddPostToDataBase(Post post)
        {
            string command =
                "SELECT DISTINCT post_id FROM posts WHERE post_name = @name";
            var npgCommand = new NpgsqlCommand(command, _npgConnection);
            npgCommand.Parameters.Add("@name", NpgsqlDbType.Text).Value = post.Name;
            try
            {
                var npgReader = npgCommand.ExecuteReader();
                if (npgReader.HasRows)
                {
                    npgReader.Close();
                    throw new Exception("Такая должность существует");
                }
                npgReader.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Ошибка добавления должности: " + ex.Message);
            }

            command = "INSERT INTO posts(post_name, post_duty) VALUES (@name, @duty)";
            npgCommand = new NpgsqlCommand(command, _npgConnection);
            npgCommand.Parameters.Add("@name", NpgsqlDbType.Text).Value = post.Name;
            npgCommand.Parameters.Add("@duty", NpgsqlDbType.Text).Value = post.Duty;
            try
            {
                npgCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ошибка добавления должности: " + ex.Message);
            }
        }

        /// <summary>
        /// Получает список незарегистрированных в программе работников
        /// </summary>
        /// <returns>Список работников</returns>
        public static List<Worker> GetNotRegisterWorkerList()
        {
            string command = "SELECT worker_name, worker_phone, shop_name, post_name, worker_id, " +
                             "workers.shop_id, workers.post_id FROM workers " +
                             "LEFT JOIN shops ON workers.shop_id = shops.shop_id " +
                             "LEFT JOIN posts ON workers.post_id = posts.post_id " +
                             "WHERE worker_id NOT IN (SELECT worker_id FROM users)";
            var workerList = new List<Worker>();
            NpgsqlCommand npgCommand = new NpgsqlCommand(command, _npgConnection);
            try
            {
                var npgReader = npgCommand.ExecuteReader();
                while (npgReader.HasRows)
                {
                    npgReader.Read();
                    var worker = new Worker
                    {
                        Name = npgReader.GetValue(0).ToString(),
                        Phone = npgReader.GetValue(1).ToString(),
                        ShopName = npgReader.GetValue(2).ToString(),
                        Post = npgReader.GetValue(3).ToString(),
                        Uuid = npgReader.GetValue(4).ToString(),
                        ShopUuid = npgReader.GetValue(5).ToString(),
                        PostUuid = npgReader.GetValue(6).ToString(),
                    };
                    workerList.Add(worker);
                }
                npgReader.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Ошибка получения списка работников " + ex.Message);
            }
            return workerList;
        }

        /// <summary>
        /// Получение списка пользователей
        /// </summary>
        /// <returns>Пользователи</returns>
        public static List<User> GetUserList()
        {
            string command =
                "SELECT user_id, user_login, is_admin, worker_name FROM users " +
                "LEFT JOIN workers ON users.worker_id = workers.worker_id";
            var userList = new List<User>();
            NpgsqlCommand npgCommand = new NpgsqlCommand(command, _npgConnection);
            try
            {
                var npgReader = npgCommand.ExecuteReader();
                while (npgReader.HasRows)
                {
                    npgReader.Read();
                    var worker = new User
                    {
                        Uuid = npgReader.GetValue(0).ToString(),
                        Login = npgReader.GetValue(1).ToString(),
                        IsAdmin = npgReader.GetValue(2).ToString() == true.ToString(),
                        Name = npgReader.GetValue(3).ToString()
                    };
                    userList.Add(worker);
                }
                npgReader.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Ошибка получения списка пользователей " + ex.Message);
            }
            return userList;
        }

        /// <summary>
        /// Измеение полей пользователя
        /// </summary>
        /// <param name="user">Измененнй пользователь</param>
        public static void ChangeUserFields(User user)
        {
            var command = "SELECT user_id FROM users WHERE user_login = @login AND user_id != @userId";
            var npgCommand = new NpgsqlCommand(command, _npgConnection);
            npgCommand.Parameters.Add("@login", NpgsqlDbType.Text).Value = user.Login;
            npgCommand.Parameters.Add("@userId", NpgsqlDbType.Uuid).Value = user.Uuid;
            try
            {
                var npgReader = npgCommand.ExecuteReader();
                if (npgReader.HasRows)
                {
                    npgReader.Close();
                    throw new Exception("Пользователь с таким логином уже существует");
                }
                npgReader.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Ошибка изменения аккаунта: " + ex.Message);
            }

            command = user.Pass != null
                ? "UPDATE users SET user_login = @login, user_pass = @pass, is_admin = @isAdmin WHERE user_id = @userId"
                : "UPDATE users SET user_login = @login, is_admin = @isAdmin WHERE user_id = @userId";
            npgCommand = new NpgsqlCommand(command, _npgConnection);
            npgCommand.Parameters.Add("@login", NpgsqlDbType.Text).Value = user.Login;
            npgCommand.Parameters.Add("@isAdmin", NpgsqlDbType.Boolean).Value = user.IsAdmin;
            npgCommand.Parameters.Add("@pass", NpgsqlDbType.Text).Value = user.Pass ?? "";
            npgCommand.Parameters.Add("@userId", NpgsqlDbType.Uuid).Value = user.Uuid;
            try
            {
                npgCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ошибка изменения аккаунта: " + ex.Message);
            }
        }

        /// <summary>
        /// Удаляет пользователя из базы данных
        /// </summary>
        /// <param name="user">Удаляемый ользователь</param>
        public static void DeleteUserFromDataBase(User user)
        {
            var command = "DELETE FROM users WHERE user_id = @id";
            var npgCommand = new NpgsqlCommand(command, _npgConnection);
            npgCommand.Parameters.Add("@id", NpgsqlDbType.Uuid).Value = user.Uuid;
            try
            {
                npgCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ошибка удаления пользователя: " + ex.Message);
            }
        }

        /// <summary>
        /// Добавления пользователя в базу данных
        /// </summary>
        /// <param name="user">Даобавляемый пользователь</param>
        public static void AddUserToDataBase(User user)
        {
            var command = "SELECT user_id FROM users WHERE user_login = @login";
            var npgCommand = new NpgsqlCommand(command, _npgConnection);
            npgCommand.Parameters.Add("@login", NpgsqlDbType.Text).Value = user.Login;
            try
            {
                var npgReader = npgCommand.ExecuteReader();
                if (npgReader.HasRows)
                {
                    npgReader.Close();
                    throw new Exception("Пользователь с таким логином уже существует");
                }
                npgReader.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Ошибка регистрации аккаунта: " + ex.Message);
            }

            command = "SELECT user_id FROM users WHERE worker_id = @workerId";
            npgCommand = new NpgsqlCommand(command, _npgConnection);
            npgCommand.Parameters.Add("@workerId", NpgsqlDbType.Uuid).Value = user.WorkerUuid;
            try
            {
                var npgReader = npgCommand.ExecuteReader();
                if (npgReader.HasRows)
                {
                    npgReader.Close();
                    throw new Exception("Сотрудник уже зарегистрирован");
                }
                npgReader.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Ошибка регистрации аккаунта: " + ex.Message);
            }

            command = "INSERT INTO users(user_login, user_pass, worker_id, is_admin) " +
                      "VALUES (@login, @pass, @workerId, @isdmin)";
            npgCommand = new NpgsqlCommand(command, _npgConnection);
            npgCommand.Parameters.Add("@login", NpgsqlDbType.Text).Value = user.Login;
            npgCommand.Parameters.Add("@pass", NpgsqlDbType.Text).Value = user.Pass;
            npgCommand.Parameters.Add("@workerId", NpgsqlDbType.Uuid).Value = user.WorkerUuid;
            npgCommand.Parameters.Add("@isdmin", NpgsqlDbType.Boolean).Value = user.IsAdmin;
            try
            {
                npgCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ошибка добавления пользователя: " + ex.Message);
            }
        }

        /// <summary>
        /// Авторизация пользователя
        /// Сравнение введенного логина и хэша пароля с
        /// данными в базе данных
        /// </summary>
        /// <param name="user">Пользователь</param>
        /// <returns>Результат</returns>
        public static bool Authentication(User user)
        {
            string command = "SELECT worker_name, post_name, is_admin, user_id FROM users " +
                             "LEFT JOIN workers ON users.worker_id = workers.worker_id " +
                             "LEFT JOIN posts ON posts.post_id = workers.post_id " +
                             "WHERE user_login = @login AND user_pass = @pass";
            var npgCommand = new NpgsqlCommand(command, _npgConnection);
            npgCommand.Parameters.Add("@login", NpgsqlDbType.Text).Value = user.Login;
            npgCommand.Parameters.Add("@pass", NpgsqlDbType.Text).Value = user.Pass;
            try
            {
                var npgReader = npgCommand.ExecuteReader();
                if (npgReader.HasRows)
                {
                    npgReader.Read();
                    var currUser = new Worker
                    {
                        Name = npgReader.GetValue(0).ToString(),
                        Post = npgReader.GetValue(1).ToString()

                    };
                    MainForm.UserIsAdmin = npgReader.GetValue(2).ToString() == true.ToString();
                    MainForm.CurrentWorker = currUser;
                    MainForm.CurrenUser = new User
                    {
                        Uuid = npgReader.GetValue(3).ToString(),
                    };
                    npgReader.Close();
                    return true;
                }
                npgReader.Close();
                throw new Exception("Неверная пара логин-пароль");
            }
            catch (Exception ex)
            {
                throw new Exception("Ошибка авторизации: " + ex.Message);
            }
        }
        
        /// <summary>
        /// Поучение информации о фабрике
        /// </summary>
        /// <returns>Массив из 5 строк </returns>
        public static string[] GetAboutFactory()
        {
            var resStrings = new string[5];
            //Количество работников
            string command = "SELECT count(worker_id) FROM workers";
            var npgCommand = new NpgsqlCommand(command, _npgConnection);
            try
            {
                var npgReader = npgCommand.ExecuteReader();
                if (npgReader.HasRows)
                {
                    npgReader.Read();
                    resStrings[0] = npgReader.GetValue(0).ToString();
                }
                npgReader.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Ошибка получения информации о фабрике: " + ex.Message);
            }
            //Количество пользователей
            command = "SELECT count(user_id) FROM users";
            npgCommand = new NpgsqlCommand(command, _npgConnection);
            try
            {
                var npgReader = npgCommand.ExecuteReader();
                if (npgReader.HasRows)
                {
                    npgReader.Read();
                    resStrings[1] = npgReader.GetValue(0).ToString();
                }
                npgReader.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Ошибка получения информации о фабрике: " + ex.Message);
            }
            //количество продуктов
            command = "SELECT count(product_id) FROM products";
            npgCommand = new NpgsqlCommand(command, _npgConnection);
            try
            {
                var npgReader = npgCommand.ExecuteReader();
                if (npgReader.HasRows)
                {
                    npgReader.Read();
                    resStrings[2] = npgReader.GetValue(0).ToString();
                }
                npgReader.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Ошибка получения информации о фабрике: " + ex.Message);
            }
            //количество цехов
            command = "SELECT count(shop_id) FROM shops";
            npgCommand = new NpgsqlCommand(command, _npgConnection);
            try
            {
                var npgReader = npgCommand.ExecuteReader();
                if (npgReader.HasRows)
                {
                    npgReader.Read();
                    resStrings[3] = npgReader.GetValue(0).ToString();
                }
                npgReader.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Ошибка получения информации о фабрике: " + ex.Message);
            }
            //количество компонентов
            command = "SELECT count(component_id) FROM components";
            npgCommand = new NpgsqlCommand(command, _npgConnection);
            try
            {
                var npgReader = npgCommand.ExecuteReader();
                if (npgReader.HasRows)
                {
                    npgReader.Read();
                    resStrings[4] = npgReader.GetValue(0).ToString();
                }
                npgReader.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Ошибка получения информации о фабрике: " + ex.Message);
            }
            return resStrings;
        }

        /// <summary>
        /// Получение записей таблицы "сессии"
        /// </summary>
        /// <returns>DataSet с таблицей сессии</returns>
        public static DataSet GetSessionDataSet()
        {
            string s_command =
                "SELECT user_login AS ЛОГИН, worker_name AS ИМЯ, sessions.record AS СТАТУС_СЕССИИ, record_date AS ДАТА FROM sessions " +
                "LEFT JOIN users ON users.user_id = sessions.user_id " +
                "LEFT JOIN workers ON workers.worker_id = users.worker_id " +
                "WHERE user_login IS NOT null";
            NpgsqlDataAdapter npgDateAdapter = new NpgsqlDataAdapter(s_command, _npgConnection);
            DataSet dsDataSet = new DataSet();
            try
            {
                npgDateAdapter.Fill(dsDataSet);
            }
            catch (Exception ex)
            {
                throw new Exception("Ошибка получения списка сесссий: " + ex.Message);
            }
            return dsDataSet;
        }

        /// <summary>
        /// Запись в таблицу сессий
        /// </summary>
        /// <param name="user">Пользователь</param>
        /// <param name="record">Запись</param>
        public static void WriteSession(User user, string record = "Сессия открыта")
        {
            string command = "INSERT INTO sessions(record, user_id) VALUES (@rcrd, @userId)";
            var npgCommand = new NpgsqlCommand(command, _npgConnection);
            npgCommand.Parameters.Add("@rcrd", NpgsqlDbType.Text).Value = record;
            npgCommand.Parameters.Add("@userId", NpgsqlDbType.Uuid).Value = user.Uuid;
            try
            {
                npgCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ошибка записи информации о сессии: " + ex.Message);
            }
        }
    }
}