using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PhoneBook.Data.Entities;

namespace PhoneBook.Data
{
    public interface ILocationsRepository
    {
        #region CRUD Interface  
        IEnumerable<Location> GetAllLocations();
        void AddEntity(Location location);
        bool SaveAll();
        Location GetLocationById(Guid id);
        void DeleteLocationById(Guid id);
        #endregion
    }
}
