using System.Text;
using UseAPI.Models;
using Newtonsoft.Json;

namespace UseAPI.API
{
    internal class PutQueries
    {
        public async Task UpdateAsync()
        {
            using (HttpClient client = new HttpClient())
            {
                var payload = new
                {
                    name = "morpheus",
                    job = "zion resident"
                };

                var httpContent = new StringContent(JsonConvert.SerializeObject(payload), Encoding.UTF8, "application/json");
                var result = await client.PostAsync(@"https://reqres.in/api/users/2", httpContent);

                if (result.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    var content = await result.Content.ReadAsStringAsync();
                    var response = JsonConvert.DeserializeObject<User>(content);
                }
            }
        }
    }
}
