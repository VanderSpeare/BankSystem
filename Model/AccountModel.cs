using BankSystem.Model;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;

namespace BankSystem.Models;

public partial class AccountModel : IModel
{
    public int Id { get; set; }

    public string? CustomerId { get; set; }

    public DateOnly? DateOpened { get; set; }

    public double? Balance { get; set; }

    public virtual ICollection<BankTransaction> BankTransactionFromAccounts { get; set; } = new List<BankTransaction>();

    public virtual ICollection<BankTransaction> BankTransactionToAccounts { get; set; } = new List<BankTransaction>();

    public virtual Customer? Customer { get; set; }
    public bool isValid()
    {

        bool isValidId = Id != null;
        bool isValidDate = DateOpened != null && DateOpened <= DateOnly.FromDateTime(DateTime.Now);
        bool isValidBalance = Balance != null && Balance >= 0;
        return isValidId && isValidDate && isValidBalance; 
    }
   
}
