using System.Text.Json;

namespace Reto2G5.Helpers
{
    public class IsDataNull
    {

        public static T Check<T>(string data) 
        {
        
            return data == null ? default : JsonSerializer.Deserialize<T>(data);

        }

        public static T CreateInstanceIFIsNull<T>(T data) where T: new()
        {
            return data == null ? new T() : data;
        }

        ///UserModel = isdDataNull.CreateInstanceIfIsNull<UserModel>(await LocalStorage.GetValue<UserModel>(ValuesKeys.Objeto));
    }
}
