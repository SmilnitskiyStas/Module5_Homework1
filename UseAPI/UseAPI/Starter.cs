using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseAPI.API;

namespace UseAPI
{
    internal class Starter
    {
        public static void Run()
        {
            DeleteQueries deleteQueries = new DeleteQueries();
            deleteQueries.DeleteAsync().GetAwaiter().GetResult();

            GetQueries getQueries = new GetQueries();
            getQueries.ListUsersAsync().GetAwaiter().GetResult();
            getQueries.SinglUserAsync().GetAwaiter().GetResult();
            getQueries.SinglUserNotFoundAsync().GetAwaiter().GetResult();
            getQueries.SinglResourceAsync().GetAwaiter().GetResult();
            getQueries.SinglResourceNotFoundAsync().GetAwaiter().GetResult();
            getQueries.ListResourceAsync().GetAwaiter().GetResult();
            getQueries.DelayedResponseAsync().GetAwaiter().GetResult();

            PatchQueries patchQueries = new PatchQueries();
            patchQueries.UpdateAsync().GetAwaiter().GetResult();

            PostQueries postQueries = new PostQueries();
            postQueries.CreateAsync().GetAwaiter().GetResult();
            postQueries.RegisterSuccessfulAsync().GetAwaiter().GetResult();
            postQueries.RegisterUnSuccessfulAsync().GetAwaiter().GetResult();
            postQueries.LoginSuccessfulAsync().GetAwaiter().GetResult();
            postQueries.LoginUnSuccessfulAsync().GetAwaiter().GetResult();

            PutQueries putQueries = new PutQueries();
            putQueries.UpdateAsync().GetAwaiter().GetResult();
        }
    }
}
