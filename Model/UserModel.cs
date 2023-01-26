using System;

namespace Reto2G5.Model
{
    public class UserModel
    {

        public string dni { get; set; }


        public string password { get; set; }

        public Boolean enabled { get; set; }

        public List<RoleModel> Roles { get; set; }
        public UserModel() { }

    }
}
