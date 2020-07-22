using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading.Tasks;

namespace PhoneBook.Data
{
    public class PhoneBookSeeder
    {
        private readonly PhoneBookContext _ctx;
        public PhoneBookSeeder(PhoneBookContext ctx)
        {
            _ctx = ctx;
        }

        public void Seed()
        {
            _ctx.Database.Initialize(true);
        }
    }
}