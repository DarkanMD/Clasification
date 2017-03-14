using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Clasification
{
    public class User
    {
        private string _userAddres;

        private string _userEmail;

        private int _userID;

        private string _userName;

        private string _userPassword;
        private string _userType;
        private int _role;

        public string UserAddres
        {
            get
            {
                return _userAddres;
            }

            set
            {
                _userAddres = value;
            }
        }

        public string UserEmail
        {
            get
            {
                return _userEmail;
            }

            set
            {
                _userEmail = value;
            }
        }

        public int UserID
        {
            get
            {
                return _userID;
            }

            set
            {
                _userID = value;
            }
        }

        public string UserName
        {
            get
            {
                return _userName;
            }

            set
            {
                _userName = value;
            }
        }

        public string UserPassword
        {
            get
            {
                return _userPassword;
            }

            set
            {
                _userPassword = value;
            }
        }

        public string UserType
        {
            get
            {
                return _userType;
            }

            set
            {
                _userType = value;
            }
        }

        public void BanUser()
        {
            throw new System.NotImplementedException();
        }

        public void UpdateProfile()
        {
            throw new System.NotImplementedException();
        }
    }
}