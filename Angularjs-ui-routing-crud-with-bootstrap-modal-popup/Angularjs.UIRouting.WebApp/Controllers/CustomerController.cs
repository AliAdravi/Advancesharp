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
    public class CustomerController : ApiController
    {
        DataContext db = new DataContext();
        [Route("api/Customer/search")]
        [HttpGet]
        public IEnumerable<Customer> SearchCustomers(string searchText)
        {
            searchText = searchText ?? "";
           return db.Customers
                .Where(x => x.FullName.Contains(searchText) ||
                        x.Country.Contains(searchText) ||
                        x.City.Contains(searchText)
                )
                .Take(20);
        }

        [Route("api/Customer/new")]
        [HttpGet]
        public Customer NewCustomer()
        {
            return new Customer();
        }

        [Route("api/Customer/detail/{id}")]
        [HttpGet]
        public Customer GetDetail(int Id)
        {
            return db.Customers.FirstOrDefault(x=>x.CustomerId == Id);
        }

        [Route("api/Customer/Save")]
        [HttpPost]
        public Customer SaveCustomer(Customer customer)
        {

            if (customer.CustomerId > 0)
            {
                var dbCustomer = db.Customers.FirstOrDefault(x => x.CustomerId == customer.CustomerId);
                dbCustomer.FullName = customer.FullName;
                dbCustomer.Address = customer.Address;
                dbCustomer.City = customer.City;
                dbCustomer.Country = customer.Country;
                dbCustomer.ZipCode = customer.ZipCode;
                db.SaveChanges();
                return dbCustomer;
            }
            else
            {
                db.Customers.Add(customer);
                db.SaveChanges();
                return customer;
            }
        }

        [Route("api/Customer/delete/{id}")]
        [HttpPost]
        public void DeleteCustomer(int Id)
        {
            var customer = db.Customers.FirstOrDefault(x => x.CustomerId == Id);
            db.Customers.Remove(customer);
            db.SaveChanges();
        }
    }
}
