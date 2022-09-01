using System.Collections.Generic;
using PlatformeService.Models;

namespace PlatformeService.Data
{
    public interface IPlatformRepo
    {
        bool SaveChanges();

        IEnumerable<Platform> GetAllPlatforms();

        Platform GetPlatform(int id);

        void CreatePlatform(Platform platform);

        void UpdatePlatform(Platform platform);

        void DeletePlatform(int id);
    }
}