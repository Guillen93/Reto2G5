using Reto2G5.Model;
using System.Reflection.Metadata.Ecma335;

namespace DanielGuillenSanta
{
    public class Endpoints
    {


        //public UserResponse Login(UserRequest userRequest)
        //{
        //    UserResponse userResponse = new UserResponse();

        //    userResponse = "http://localhost:8082/api/users"+[userRequest];

        //    return userResponse;

        //}
        public static string GetUsers()
        {

            return "http://localhost:8082/api/users";

        }
        

    }
}
