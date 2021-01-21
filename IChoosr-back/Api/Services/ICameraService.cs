using System;
using System.Collections.Generic;
using Api.Models;

namespace Api.Services
{
    public interface ICameraService
    {
        public IEnumerable<CameraModel> GetCameras();
    }
}
