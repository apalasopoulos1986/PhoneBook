using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PhoneBook.Data.Entities;

namespace PhoneBook.Data
{
    public class LocationsRepository : ILocationsRepository
    {
        private readonly PhoneBookContext _ctx;

        public LocationsRepository(PhoneBookContext ctx)
        {
            _ctx = ctx;
        }
        public void AddEntity(Location location)
        {
            _ctx.Locations.Add(location);
        }

        public void DeleteLocationById(Guid id)
        {
            var location = _ctx.Locations.FirstOrDefault(c => c.Id == id);
            if (location != null)
            {
                _ctx.Locations.Remove(location);
            }
        }

        public IEnumerable<Location> GetAllLocations()
        {
            try
            {
                return _ctx.Locations.ToList();
            }
            catch (Exception ex)
            {

                return null;
            }
        }

        public Location GetLocationById(Guid id)
        {
            return _ctx.Locations.FirstOrDefault(c => c.Id == id);
        }

        public bool SaveAll()
        {
            return _ctx.SaveChanges() > 0;
        }
    }
}