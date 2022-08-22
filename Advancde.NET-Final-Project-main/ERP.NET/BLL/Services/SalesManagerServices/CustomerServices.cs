using BLL.Entities;
using DAL.DataAccessFactory;
using DAL.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services.SalesManagerServices
{
    public class CustomerServices
    {
        public static List<CustomerModel> Get()
        {
            var data = DataAccessFactory.CustomerworkDataAccess().Get();
            var customers = new List<CustomerModel>();
            foreach (var item in data)
            {
                customers.Add(new CustomerModel()
                {
                    id = item.id,
                    name = item.name,
                    email = item.email,
                    phone = item.phone,
                    delivery_point = item.delivery_point,
                    first_purchase = item.first_purchase,
                    type =item.type

                });
            }
            return customers;
        }
    }
}
