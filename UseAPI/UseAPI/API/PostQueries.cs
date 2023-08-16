using System.Text;
using UseAPI.Models;
using Newtonsoft.Json;

namespace UseAPI.API
{
    internal class PostQueries
    {
        public async Task CreateAsync()
        {
            using (HttpClient client = new HttpClient())
            {
                var payload = new
                {
                    name = "morpheus",
                    job = "leader"
                };

                var httpContent = new StringContent(JsonConvert.SerializeObject(payload), Encoding.UTF8, "application/json");
                var result = await client.PostAsync(@"https://reqres.in/api/users", httpContent);

                if (result.StatusCode == System.Net.HttpStatusCode.Created)
                {
                    var content = await result.Content.ReadAsStringAsync();
                    var response = JsonConvert.DeserializeObject<User>(content);
                }
            }
        }

        public async Task RegisterSuccessfulAsync()
        {
            using (HttpClient client = new HttpClient())
            {
                var payload = new
                {
                    email = "eve.holt@reqres.in",
                    password = "pistol"
                };

                var httpContent = new StringContent(JsonConvert.SerializeObject(payload), Encoding.UTF8, "application/json");
                var result = await client.PostAsync(@"https://reqres.in/api/register", httpContent);

                if (result.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    var content = await result.Content.ReadAsStringAsync();
                    var response = JsonConvert.DeserializeObject<User>(content);
                }
            }
        }

        public async Task RegisterUnSuccessfulAsync()
        {
            using (HttpClient client = new HttpClient())
            {
                var payload = new
                {
                    email = "eve.holt@reqres.in"
                };

                var httpContent = new StringContent(JsonConvert.SerializeObject(payload), Encoding.UTF8, "application/json");
                var result = await client.PostAsync(@"https://reqres.in/api/register", httpContent);

                if (result.StatusCode == System.Net.HttpStatusCode.BadRequest)
                {
                    var content = await result.Content.ReadAsStringAsync();
                    var response = JsonConvert.DeserializeObject<User>(content);
                }
            }
        }

        public async Task LoginSuccessfulAsync()
        {
            using (HttpClient client = new HttpClient())
            {
                var payload = new
                {
                    email = "eve.holt@reqres.in",
                    password = "cityslicka"
                };

                var httpContent = new StringContent(JsonConvert.SerializeObject(payload), Encoding.UTF8, "application/json");
                var result = await client.PostAsync(@"https://reqres.in/api/login", httpContent);

                if (result.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    var content = await result.Content.ReadAsStringAsync();
                    var response = JsonConvert.DeserializeObject<Login>(content);
                }
            }
        }

        public async Task LoginUnSuccessfulAsync()
        {
            using (HttpClient client = new HttpClient())
            {
                var payload = new
                {
                    email = "peter@klaven"
                };

                var httpContent = new StringContent(JsonConvert.SerializeObject(payload), Encoding.UTF8, "application/json");
                var result = await client.PostAsync(@"https://reqres.in/api/login", httpContent);

                if (result.StatusCode == System.Net.HttpStatusCode.BadRequest)
                {
                    var content = await result.Content.ReadAsStringAsync();
                    var response = JsonConvert.DeserializeObject<Login>(content);
                }
            }
        }
    }
}
