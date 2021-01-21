using System;
using System.Collections.Generic;
using System.IO;
using Api.Models;
using Microsoft.AspNetCore.Diagnostics;

namespace Api.Repositories
{
    public class CameraRepository: ICameraRepository
    {
        private readonly string DB_LOCATION = "/Users/mathiassamyn/projects/IChoosr/IChoosr-opdracht/IChoosr-back/Api/Data/cameras-defb.csv";

        public CameraRepository()
        {
        }

        public IEnumerable<CameraModel> findAll()
        {
            try
            {
                using (StreamReader sr = new StreamReader(@DB_LOCATION))
                {
                    sr.ReadLine();

                    var cameras = new List<CameraModel>();
                    string line;

                    while ((line = sr.ReadLine()) != null)
                    {
                        if(LineIsValid(line))
                        {
                            var values = line.Split(";");
                            var camera = new CameraModel(values[0],  float.Parse(values[1]), float.Parse(values[2]));
                            cameras.Add(camera);
                        }
                    }

                    return cameras;
                }
            }
            catch (Exception e)
            {
                throw new Exception("Could not read the data file.");
            }
        }

        private bool LineIsValid(string line)
        {
            return line != null && !line.ToUpper().Contains("ERROR") && line.Split(";").Length == 3;
        }

    }
}
