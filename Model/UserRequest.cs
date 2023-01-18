using System;
using System.ComponentModel.DataAnnotations;

namespace Reto2G5.Model
{
    public class UserRequest
    {

        [Required(ErrorMessage = "el campo no puede estar vacio"), MaxLength(20, ErrorMessage = "maximo 20 caracteres"), MinLength(5, ErrorMessage = "minimo 5 caracteres")]
        public string dni { get; set; }



        [DataType(DataType.Password), Required(ErrorMessage = "el campo no puede estar vacio")]
        public string password { get; set; }



    }
}
