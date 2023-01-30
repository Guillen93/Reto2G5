namespace Reto2G5.Model
{
    
    public class StudentCreate
    {

        public string studentDni { get; set; }
        public string password { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public DateTime bornDate { get; set; }
        public string nationality { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public object photo { get; set; }


    }
}
