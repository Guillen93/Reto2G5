﻿using Reto2G5.Model;
using System.Reflection.Metadata.Ecma335;

namespace Reto2G5
{
    public class Endpoints
    {
        public static string Login()
        {
            return "http://localhost:8082/api/users/login";
        }
        public static string SendMail()
        {
            return "http://localhost:8082/api/sendMail";
        }

        public static string GetUsers()
        {
            return "http://localhost:8082/api/users";
        }
        public static string GetUsersByDni(string dni)
        {
            return "http://localhost:8082/api/users/"+dni;
        }
        public static string GetUsersNenabled()
        {
            return "http://localhost:8082/api/users/notEnabled";
        }
        public static string GetStudents()
        {
            return "http://localhost:8082/api/students";
        }
        public static string GetStudentsByDni(String dni)
        {
            return "http://localhost:8082/api/students/"+dni;
        }
        public static string GetProfessors()
        {
            return "http://localhost:8082/api/professors";
        }
        public static string GetProfessorsByDni(String dni)
        {
            return "http://localhost:8082/api/professors/"+dni;
        }
        public static string CreateUsers()
        {
            return "http://localhost:8082/api/users/signup";
        }
        public static string CreateProfessor()
        {
            return "http://localhost:8082/api/professors/create";
        }
        public static string GetRoles()
        {
            return "http://localhost:8082/api/roles";
        }
        public static string DeleteUsers(String dni)
        {
            return "http://localhost:8082/api/users/" + dni;
        }
        public static string UpdateUser(String dni)
        {
            return "http://localhost:8082/api/users/" + dni;
        }
       
    }
}
