using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Clasification
{
    public class User
    {


        public User(Guid id, string name,string addres,string email,string password,byte role)
        {
            UserID = id;
            UserName = name;
            UserAddress = addres;
            UserEmailAddress = email;
            UserPassword = password;
            UserRole = role;
        }

        public User(string name)
        {
            UserID = Guid.NewGuid();
            UserName = name;
            UserAddress = "Not Specified";
            UserEmailAddress = "Not Specified";
            UserPassword = "Not Specified";
            UserRole = 0;
        }

        public Guid UserID { get; private set; }

        public string UserName { get; private set; }

        public string UserAddress { get; private set; }

        public string UserEmailAddress { get; private set; }

        public string UserPassword { get; private set; }

        public byte UserRole { get; private set; }

        public void UpdateProfile()
        {
            throw new System.NotImplementedException();
        }

        public override string ToString()
        {
            return $"{UserID};{UserName};{UserAddress};{UserEmailAddress};{UserPassword};{UserRole}";
        }
    }
}