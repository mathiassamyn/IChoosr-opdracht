using System;
using Api.Repositories;
using Api.Services;
using Microsoft.Extensions.DependencyInjection;

namespace CLI
{
    class Program
    {
        static void Main(string[] args)
        {
            var serviceProvider = new ServiceCollection()
                .AddSingleton<ICameraRepository, CameraRepository>()
                .AddSingleton<ICameraService, CameraService>()
                .BuildServiceProvider();

            var cameraService = serviceProvider.GetService<ICameraService>();

            var namePiece = "";

            if(args.Length != 0)
            {
                namePiece = args[0];
            }

            var cameras = cameraService.GetCamerasByName(namePiece);

            foreach (var camera in cameras) {
                Console.WriteLine($"{camera.Id} | {camera.Name} | {camera.Latitude} | {camera.Longitude}");
            }

        }
    }
}
