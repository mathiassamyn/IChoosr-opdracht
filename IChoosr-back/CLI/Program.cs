using System;
using Api.Repositories;
using Api.Services;
using CommandLine;
using Microsoft.Extensions.DependencyInjection;

namespace CLI
{
    class Program
    {
        public class Options
        {
            [Option('n', "name", Required = false, Default = "", HelpText = "Search for cameras by name.")]
            public string Name { get; set; }
        }

        static void Main(string[] args)
        {
            var serviceProvider = CreateServiceProvider();

            var cameraService = serviceProvider.GetService<ICameraService>();

            Parser.Default.ParseArguments<Options>(args)
                   .WithParsed<Options>(o =>
                   {
                       var cameras = cameraService.GetCamerasByName(o.Name);

                       foreach (var camera in cameras)
                       {
                           Console.WriteLine($"{camera.Id} | {camera.Name} | {camera.Latitude} | {camera.Longitude}");
                       }

                   });
        }

        private static ServiceProvider CreateServiceProvider()
        {
            return new ServiceCollection()
                .AddSingleton<ICameraRepository, CameraRepository>()
                .AddSingleton<ICameraService, CameraService>()
                .BuildServiceProvider();
        }
    }
}
