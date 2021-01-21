using System;
using System.Collections.Generic;
using Api.Models;

namespace Api.Repositories
{
    public interface ICameraRepository
    {
        public IEnumerable<CameraModel> findAll();
    }
}
