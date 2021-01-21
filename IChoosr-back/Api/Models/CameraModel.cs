using System;
namespace Api.Models
{
    public class CameraModel
    {
        public int Id { get; }
        public string Name { get; set; }
        public float Latitude { get; set; }
        public float Longitude { get; set; }

        public CameraModel(string name, float latitude, float longitude)
        {
            Name = name;
            Latitude = latitude;
            Longitude = longitude;
            Id = getIdFromName(Name);
        }

        private int getIdFromName(string name)
        {
            var id = name.Split("-")[2]?.Split(" ")[0];

            return Int32.Parse(id);
        }
    }
}
