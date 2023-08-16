using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace UseAPI.API
{
    internal class DeleteQueries
    {
        public async Task DeleteAsync()
        {
            using (HttpClient client = new HttpClient())
            {
                var result = await client.GetAsync(@"https://reqres.in/api/users/2");

                if (result.StatusCode == HttpStatusCode.NoContent)
                {
                    var content = await result.Content.ReadAsStringAsync();
                }
            }
        }
    }
}
