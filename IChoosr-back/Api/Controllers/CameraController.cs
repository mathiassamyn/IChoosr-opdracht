using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.Models;
using Api.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CameraController : ControllerBase
    {
        private readonly ICameraService _cameraService;

        public CameraController(ICameraService cameraService)
        {
            _cameraService = cameraService;
        }

        [HttpGet]
        [Route("")]
        [Route("all")]
        public IEnumerable<CameraModel> GetCameras()
        {
            return _cameraService.GetCameras();
        }
    }
}
