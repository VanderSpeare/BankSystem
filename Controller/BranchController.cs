using BankSystem.Model;
using BankSystem.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using BankSystem.Controller;



namespace BankSystem.Controller
{
    public class BranchController: IController
    {
        private List<IModel> branches;
        private BankSystemContext db ;
        public List<IModel> Items => branches;
        public BranchController()
        {
            branches = new List<IModel>();
            db = new BankSystemContext(new DbContextOptions<BankSystemContext>());
        }



        // Tạo tài khoản mới
        public bool Create(IModel model)



        {
            try
            {
                var account = model as Branch;
                if (IsExist(account.Id)) return false;

                var dbBranch = new Branch
                {
                    Id = account.Id,
                    City = account.City,
                    HouseNo = account.HouseNo, 
                    Name = account.Name,
                };

                db.Branches.Add(dbBranch);
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        // Cập nhật tài khoản
        public bool Update(IModel model)
        {
            try
            {
                var Branch = model as Branch;
                var dbAccount = db.Branches.FirstOrDefault(a => a.Id == Branch.Id);
                if (dbAccount == null)
                {
                   dbAccount.City = Branch.City;       
                   dbAccount.HouseNo = Branch.HouseNo;
                   dbAccount.Name = Branch.Name;   
                    dbAccount.HouseNo = Branch.HouseNo;
                   

                    db.SaveChanges();

                    var existingAccount = Read(Branch.Id) as Branch;
                    existingAccount.HouseNo = Branch.HouseNo;
                    existingAccount.Name = Branch.Name;
                    existingAccount.City = Branch.City;


                    return true;
                }
                return false;
            }
            catch (Exception)
            {
                return false;
            }

        }

        // Xóa tài khoản
        public bool Delete(object id)
        {
            var dbBranch = db.Branches.FirstOrDefault(a => a.Id == id);
            if (dbBranch == null) return false;

            db.Branches.Remove(dbBranch);
            db.SaveChanges();

            var account = Read(id) as AccountModel;
            if (account != null)
            {
                branches.Remove(account);
            }

            return true;
        }

        // Đọc tài khoản
        public IModel Read(object id)
        {
            return branches.FirstOrDefault(a => (a as AccountModel).Id == (int)id);
        }

        // Load tất cả tài khoản từ CSDL
        public bool Load()
        {
            var dbBranch = db.Branches.ToList();
            branches = dbBranch.Select(a => new Branch
            {
                Id = a.Id,
                City = a.City,
                HouseNo = a.HouseNo,
                Name = a.Name,

            }).Cast<IModel>().ToList();

            return true;
        }

        // Phương thức Load tài khoản theo id
        public bool Load(object id)
        {
            var dbBranch = db.Branches.FirstOrDefault(a => a.Id == id);
            if (dbBranch == null)
            {
                return false; // Không tìm thấy tài khoản với ID này
            }

            var account = new Branch
            {
                Id = dbBranch.Id,
                City = dbBranch.City,
                Name = dbBranch.Name,
                HouseNo = dbBranch.HouseNo,
                
            };

            branches.Clear();
            

            return true;
        }

        // Kiểm tra tồn tại tài khoản theo ID
        public bool IsExist(object id)
        {
            return branches.Any(a => (a as AccountModel).Id == (int)id);
        }

        public bool IsExist(IModel model)
        {
            var account = model as AccountModel;
            return IsExist(account.Id);
        }
    }
}