using System;
using System.Collections.Generic;
using Model;
using DAL;

namespace _ReservationSystemLogic
{
    public class CustomerService
    {
        CustomerDAO customerDAO = new CustomerDAO();
        public List<Customer> GetAll()
        {

            List<Customer> customers = customerDAO.GetAll_Customers();

            return customers;
        }

        public Customer GetById(int customerId)
        {
            Customer customer = null;
            customer = customerDAO.GetCustomer_Byld(customerId);
            return customer;
        }
    }
}
