using System;
using System.IO;
// using System.Collections.Generic;
// using System.Linq;
// using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
// using Microsoft.Extensions.Configuration;
// using Microsoft.Extensions.Hosting;
// using Microsoft.Extensions.Logging;

namespace MyAspWebApp
{
	public class Program
	{
		public static void Main(string[] args)
		{
			var host = new WebHostBuilder()
				.UseKestrel()
				.UseStartup<Startup>()
				.Build();
				
				host.Run();
		}
	}
	
	public class Startup
	{
		public void Configure(IApplicationBuilder app)
		{
            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("Hello world! It is " + DateTime.Now.ToString("1"));
            }
            );
        }
	}
}
