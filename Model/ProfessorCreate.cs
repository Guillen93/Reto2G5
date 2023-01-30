using System.ComponentModel.DataAnnotations;

namespace Reto2G5.Model
{
    public class ProfessorCreate
    {
        [Required(ErrorMessage = "el campo no puede estar vacio"), MaxLength(20, ErrorMessage = "maximo 20 caracteres"), MinLength(5, ErrorMessage = "minimo 5 caracteres")]
        public string dni { get; set; }

        [DataType(DataType.Password), Required(ErrorMessage = "el campo no puede estar vacio")]
        public string password { get; set; }

        public int roleId { get; set; }

        [Required(ErrorMessage = "el campo no puede estar vacio")]
        public string name { get; set; }
        [Required(ErrorMessage = "el campo no puede estar vacio")]
        public string surname { get; set; }
        [Required(ErrorMessage = "el campo no puede estar vacio")]
        public string email { get; set; }
        public string photo { get; set; }
        
        public string nationality { get; set; }
        [Required(ErrorMessage = "el campo no puede estar vacio")]
        public string addres { get; set; }

        
    }
}
