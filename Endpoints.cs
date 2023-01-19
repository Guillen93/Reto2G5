using Reto2G5.Model;
using System.Reflection.Metadata.Ecma335;

namespace Reto2G5
{
    public class Endpoints
    {
        public static string Login()
        {
            return "http://localhost:8082/api/users/login";
        }

        public static string GetUsers()
        {
            return "http://localhost:8082/api/users";
        }
        public static string GetStudents()
        {
            return "http://localhost:8082/api/students";
        }
        public static string GetProfessors()
        {
            return "http://localhost:8082/api/professors";
        }



    }
}
