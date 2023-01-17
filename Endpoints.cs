using Reto2G5.Model;
using System.Reflection.Metadata.Ecma335;

namespace DanielGuillenSanta
{
    public class Endpoints
    {

        public static UserResponse Login(UserRequest userRequest)
        {
            private UserResponse userResponse;
        protected override async Task<UserResponse> OnInitializedAsync()
        {
            var postBody = new { dni = userRequest.dni, password = userRequest.password };
            using var response = await HttpClient.PostAsJsonAsync("https://reqres.in/api/articles", postBody);

            // convert response data to Article object
            userResponse = await response.Content.ReadFromJsonAsync<UserRequest>();
            return userResponse;
        }

        }

        public UserResponse Login(UserRequest userRequest)
        {

            return "https://localhost:8082/api/users/login";

        }
        public static string Get25Beers()
        {

            return "https://api.punkapi.com/v2/beers";

        }



    }
}
