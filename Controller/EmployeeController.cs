using BankSystem.Model;
using BankSystem.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace BankSystem.Controller
{
    internal class EmployeeController : IController
    {
        private List<IModel> employees;
        private BankSystemContext db;

        public List<IModel> Items => employees;

        public EmployeeController()
        {
            employees = new List<IModel>();
            db = new BankSystemContext(new DbContextOptions<BankSystemContext>());

        }
        // Thêm nhân viên mới
        public bool Create(IModel model)
        {
            try
            {
                var employee = model as Employee;
                if (IsExist(employee.Id)) return false;

                var dbEmployees = new Employee
                {
                    Id = employee.Id,
                    Name = employee.Name,
                    Password = PasswordHelper.HashPassword(employee.Password),
                    Role = employee.Role
                };

                db.Employees.Add(dbEmployees);
                db.SaveChanges();

                employees.Add(employee as IModel );
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        // Cập nhật thông tin nhân viên
        public bool Update(IModel model)
        {
            try
            {
                var employee = model as Employee;
                var dbEmployees = db.Employees.SingleOrDefault(e => e.Id == employee.Id);
                if (dbEmployees != null)
                {
                    dbEmployees.Name = employee.Name;
                    dbEmployees.Role = employee.Role;
                    db.SaveChanges();

                    var existingEmployee = Read(employee.Id) as Employee;
                    existingEmployee.Name = employee.Name;
                    existingEmployee.Role = employee.Role;

                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        // Xóa nhân viên
        public bool Delete(object id)
        {
            try
            {
                var dbEmployee = db.Employees.SingleOrDefault(e => e.Id == (string)id);
                if (dbEmployee != null)
                {
                    db.Employees.Remove(dbEmployee);
                    db.SaveChanges();

                    var employee = Read(id) as Employee;
                    if (employee != null)
                    {
                        employees.Remove(employee as IModel);
                    }
                    return true;
                }
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        // Đọc nhân viên
        public IModel Read(object id)
        {
            return employees.FirstOrDefault(a => (a as Employee).Id == (string)id);
        }

        // Load tất cả nhân viên từ CSDL
        public bool Load()
        {
            var dbEmployee = db.Employees.ToList();
            employees = dbEmployee.Select(a => new Employee
            {
                Id = a.Id,
                Name = a.Name,
                Password = a.Password,
                Role = a.Role
            }).Cast<IModel>().ToList();

            return true;
        }

        // Phương thức Load nhân viên theo id
        public bool Load(object id)
        {
            var dbEmployee = db.Employees.FirstOrDefault(a => a.Id == (string)id);
            if (dbEmployee == null)
            {
                return false; // Không tìm thấy nhân viên với ID này
            }

            var employee = new Employee
            {
                Id = dbEmployee.Id,
                Name = dbEmployee.Name,
                Password = dbEmployee.Password,
                Role = dbEmployee.Role
            };

            employees.Clear();
            employees.Add(employee as IModel);

            return true;
        }

        // Kiểm tra tồn tại nhân viên theo ID
        public bool IsExist(object id)
        {
            if (employees == null || !employees.Any())
            {
                return false;
            }

            return employees.Any(a => (a as Employee).Id == (string)id);
        }

        public bool IsExist(IModel model)
        {
            var employee = model as Employee;
            return IsExist(employee.Id);
        }

        internal bool Update(Employee employee)
        {
            throw new NotImplementedException();
        }

        internal object LoadEmployees()
        {
            throw new NotImplementedException();
        }
    }
    public static class PasswordHelper
    {
        public static string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = Encoding.UTF8.GetBytes(password);
                byte[] hash = sha256.ComputeHash(bytes);
                return BitConverter.ToString(hash).Replace("-", "").ToLower();
            }
        }
    }
}