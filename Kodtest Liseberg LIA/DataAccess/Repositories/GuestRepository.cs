using DataAccess.Interfaces;
using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories
{
    public class GuestRepository : IGuestRepository
    {
        private readonly Dictionary<Guid, Guest> _guests;

        public GuestRepository()
        {
            _guests = new();
        }

        public void Add(Guest guest)
        {
            var newId = Guid.NewGuid();
            guest.Id = newId;

            _guests.Add(newId, guest);
        }
        public List<Guest> GetAll() => _guests.Values.ToList();

        public void Update(Guest guest)
        {
            _guests[guest.Id.Value] = guest;
        }

        public void Delete(Guid id)
        {
            _guests.Remove(id);
        }   

        public Guest GetById(Guid id)
        {
            if (id != Guid.Empty)
            {
                return _guests[id];
            }
            else
            {
                return null;
            }
            
        }
    } 
}
