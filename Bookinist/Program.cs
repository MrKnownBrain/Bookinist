using Microsoft.Extensions.Hosting;

using System;

namespace Bookinist
{
    class Program
    {
        [STAThread]
        private static void Main(string[] args)
        {
            var app = new App();
            app.InitializeComponent();
            app.Run();
        }
        public static IHostBuilder CreateHostBuilder(string[] args) => Host.CreateDefaultBuilder(args)
            .ConfigureServices(App.ConfigureServices);
    }
}
