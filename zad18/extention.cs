
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace zad18
{
    public static class extention
    {
        public static void AddWebServices(this IServiceCollection services)
        {

            services.AddSingleton<IUserManager, UserManager>();

        }

    }
}
