using Reto2G5.Model;
using System.Reflection.Metadata.Ecma335;

namespace Reto2G5
{
    public class Endpoints
    {
        public static string Login2()
        {
            return "http://localhost:8082/api/users/login";
        }
        public static string Login()
        {
            return "http://localhost:8082/api/users/login/Di";
        }

        public static string GetUsers()
        {
            return "http://localhost:8082/api/users/Di";
        }
        public static string GetStudents()
        {
            return "http://localhost:8082/api/students";
        }
        public static string GetProfessors()
        {
            return "http://localhost:8082/api/professors";
        }
        public static string CreateUsers()
        {
            return "http://localhost:8082/api/users/signup";
        }
        public static string GetRoles()
        {
            return "http://localhost:8082/api/roles";
        }
        public static string DeleteUsers(String dni)
        {
            return "http://localhost:8082/api/users/"+dni;
        }


    }
}
