using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clasification
{
    class UserFactory:IFactory<User>
    {
        public UserFactory()
        {
        }

        public User Create(string data)
        {
            var datasplit = data.Split(';');
            return new User(Guid.Parse(datasplit[1]),datasplit[2],datasplit[3],datasplit[4],datasplit[5],byte.Parse(datasplit[6]));
        }

        public User Create(string name, string address, string email)
        {
            return new User( name,  address,  email);
        }

    }
}
