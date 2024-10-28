using System;
using System.Collections.Generic;
using System.Linq;
using BankSystem.Model;
using BankSystem.Models;
using Microsoft.EntityFrameworkCore;

namespace BankSystem.Controller
{
    public class CustomerController : IController
    {
        
        private List<IModel> customers;

        public List<IModel> Items => customers;
        private BankSystemContext db;
        public CustomerController()
        {
            customers = new List<IModel>();
            db = new BankSystemContext(new DbContextOptions<BankSystemContext>());
        }

        // Phương thức thêm khách hàng
        public bool Create(IModel model)
        {
            var customer = model as Customer;
            if (IsExist(customer.Id)) return false;

            var dbCustomer = new Customer
            {
                Id = customer.Id,
                Name = customer.Name,
                Phone = customer.Phone,
                Email = customer.Email,
                HouseNo = customer.HouseNo,
                City = customer.City,
                Pin = customer.Pin
            };

            db.Customers.Add(dbCustomer);
            db.SaveChanges();

            return true;
        }

        // Phương thức cập nhật khách hàng
        public bool Update(IModel model)
        {
            var customer = model as Customer;
            var dbCustomer = db.Customers.FirstOrDefault(c => c.Id == customer.Id);
            if (dbCustomer == null) return false;

            dbCustomer.Name = customer.Name;
            dbCustomer.Phone = customer.Phone;
            dbCustomer.Email = customer.Email;
            dbCustomer.HouseNo = customer.HouseNo;
            dbCustomer.City = customer.City;
            dbCustomer.Pin = customer.Pin;

            db.SaveChanges();

            // Cập nhật khách hàng trong danh sách bộ nhớ
            var existingCustomer = Read(customer.Id) as Customer;
            existingCustomer.Name = customer.Name;
            existingCustomer.Phone = customer.Phone;
            existingCustomer.Email = customer.Email;
            existingCustomer.HouseNo = customer.HouseNo;
            existingCustomer.City = customer.City;
            existingCustomer.Pin = customer.Pin;

            return true;
        }

        // Phương thức xóa khách hàng
        public bool Delete(object id)
        {
            try
            {
                if (id is not string customerId) return false;

                var dbCustomer = db.Customers.FirstOrDefault(c => c.Id == customerId);
                if (dbCustomer == null) return false;

                db.Customers.Remove(dbCustomer);
                db.SaveChanges();

                // Attempt to read and remove from the in-memory list
                var customer = Read(id) as Customer;
                if (customer != null)
                {
                    customers.Remove(customer as IModel); // Cast to IModel to match the list type
                }

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error deleting customer: {ex.Message}");
                return false;
            }
        }



        // Đọc khách hàng theo ID
        public IModel Read(object id)
        {
            return customers.FirstOrDefault(c => (c as Customer).Id == (string)id);
        }

        // Load tất cả khách hàng từ CSDL
        public bool Load()
        {
            var dbCustomers = db.Customers.ToList();
            customers = dbCustomers.Select(c => new Customer
            {
                Id = c.Id,
                Name = c.Name,
                Phone = c.Phone,
                Email = c.Email,
                HouseNo = c.HouseNo,
                City = c.City,
                Pin = c.Pin
            }).Cast<IModel>().ToList();

            return customers.Count > 0;
        }

        // Load khách hàng theo id
        public bool Load(object id)
        {
            if (id is not string customerId) return false;

            var dbCustomer = db.Customers.FirstOrDefault(c => c.Id == customerId); //databse
            if (dbCustomer == null) return false;

            var customer = new Customer
            {
                Id = dbCustomer.Id,
                Name = dbCustomer.Name,
                Phone = dbCustomer.Phone,
                Email = dbCustomer.Email,
                HouseNo = dbCustomer.HouseNo,
                City = dbCustomer.City,
                Pin = dbCustomer.Pin
            };

            // Ensure customers list is initialized
            customers ??= new List<IModel>();

            // Clear the old list and add the new customer as IModel
            customers.Clear();
            customers.Add(customer as IModel);
            return true;
        }


        // Kiểm tra tồn tại khách hàng theo ID
        public bool IsExist(object id)
        {
            return customers.Any(c => (c as Customer).Id == (string)id);
        }

        public bool IsExist(IModel model)
        {
            var customer = model as Customer;
            return IsExist(customer.Id);
        }
    }
}