using CoreWCF;
using CoreWCF.Configuration;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace PseudoRMI_EchoServer
{
    public class ServerMain
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddServiceModelServices();
            builder.Services.AddServiceModelMetadata();
            builder.Services.AddSingleton<IEchoService, EchoService>(); // Rejestracja serwisu

            var host = builder.Build();
            host.UseServiceModel(serviceBuilder =>
            {
                serviceBuilder.AddService<EchoService>()
                              .AddServiceEndpoint<EchoService, IEchoService>(
                                  new BasicHttpBinding(), "/EchoService");
            });

            host.Run();
        }
    }
}