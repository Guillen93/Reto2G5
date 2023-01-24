using Microsoft.AspNetCore.Components;
using Reto2G5.Enum;

namespace Reto2G5.Interfaces
{
    public interface ILocalStorage
    {
        //<summary>
        //Obtiene un valor almacenado en la memoria local
        //</summary>
        //<Typeparam name = "T"></typeparam>
        //<param name ="key"></param>
        //<returns></returns>
        Task<T> GetValue<T>(ValuesKeys key);


        //<summary>
        //Obtiene un valor almacenado en la memoria local
        //y lo serializa al tipo de dato que especificamos
        //</summary>
        //<Typeparam name = "T"></typeparam>
        //<param name ="key"></param>
        //<param name =" value"><param>
        //<returns></returns>
        Task SetValue<T>(ValuesKeys key, T value);


        //<summary>
        //borra de memoria un elemento en especifico
        //</summary>
        //<param name ="key"></param>
        //<returns></returns>
        Task RemoveItem(ValuesKeys key);

        //<summary>
        //borra de memoria todos los datos almacenados
        //</summary>
        Task ClearAll();
    }
}
