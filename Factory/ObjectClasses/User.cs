using System;
using System.Security.Cryptography;
using System.Text;

namespace Factory.ObjectClasses
{
    public class User
    {
        public string Login { get; set; }
        public string Name { get; set; }

        private string _password;

        public string Pass
        {
            get { return _password; }
            set
            {
                if (value == null)
                {
                    _password = null;
                    return;
                }
                MD5 md5 = MD5.Create();
                _password = Encoding.ASCII.GetString(md5.ComputeHash(Encoding.ASCII.GetBytes(value)));
            }
        }

        public bool IsAdmin { get; set; }

        public string Uuid { get; set; }

        public string WorkerUuid { get; set; }
    }
}