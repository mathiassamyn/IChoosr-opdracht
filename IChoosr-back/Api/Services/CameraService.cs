using System;
using System.Collections.Generic;
using Api.Models;
using Api.Repositories;

namespace Api.Services
{
    public class CameraService: ICameraService
    {
        private readonly ICameraRepository _cameraRepository;

        public CameraService(ICameraRepository cameraRepository)
        {
            _cameraRepository = cameraRepository;
        }

        public IEnumerable<CameraModel> GetCameras()
        {
            return _cameraRepository.FindAll();
        }

        public IEnumerable<CameraModel> GetCamerasByName(string name)
        {
            return _cameraRepository.FindByName(name);
        }
    }
}
