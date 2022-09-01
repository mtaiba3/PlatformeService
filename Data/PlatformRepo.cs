using System.Collections.Generic;
using System.Linq;
using PlatformeService.Models;

namespace PlatformeService.Data
{
    public class PlatformRepo : IPlatformRepo
    {
        private readonly AppDbContext _context;

        public PlatformRepo(AppDbContext context)
        {
            _context = context;
        }

        public void CreatePlatform(Platform platform)
        {
            if (platform == null)
                throw new System.ArgumentNullException(nameof(platform));
            
            _context.Platforms.Add(platform);
        }

        public void DeletePlatform(int id)
        {
            var platformToRemove = _context.Platforms.FirstOrDefault(p => p.Id == id);
            if (platformToRemove == null)
                return;

            _context.Platforms.Remove(platformToRemove);
        }

        public IEnumerable<Platform> GetAllPlatforms()
        {
            return _context.Platforms.ToList();
        }

        public Platform GetPlatform(int id)
        {
            return _context.Platforms.FirstOrDefault(p => p.Id == id);
        }

        public bool SaveChanges()
        {
            return(_context.SaveChanges() >= 0);
        }

        public void UpdatePlatform(Platform platform)
        {
            throw new System.NotImplementedException();
        }
    }
}