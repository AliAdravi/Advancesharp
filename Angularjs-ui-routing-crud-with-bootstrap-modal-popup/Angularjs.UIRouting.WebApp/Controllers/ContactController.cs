using Angularjs.UIRouting.WebApp.DataAccessLayer;
using Angularjs.UIRouting.WebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Angularjs.UIRouting.WebApp.Controllers
{
    public class ContactController : ApiController
    {
        DataContext db = new DataContext();
        // GET: api/Contact
        public IEnumerable<Contact> Get()
        {
            return db.Contacts;
        }

        public Contact Get(int id)
        {
            return db.Contacts.FirstOrDefault(x => x.ContactId == id);
        }

        [Route("api/Contact/ByCustomerId/{Id}")]
        public IEnumerable<Contact> GetCustomerContacts(int Id)
        {
            var contacts = db.Contacts.Where(x => x.CustomerId == Id);
            return contacts;
        }
    }
}
