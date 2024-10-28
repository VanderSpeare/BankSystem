using System;
using System.Collections.Generic;

namespace BankSystem.Models;

public partial class Customer
{
    public string Id { get; set; } = null!;

    public string? Name { get; set; }

    public string? Phone { get; set; }

    public string? Email { get; set; }

    public string? HouseNo { get; set; }

    public string? City { get; set; }

    public string? Pin { get; set; }

    public virtual ICollection<AccountModel> Accounts { get; set; } = new List<AccountModel>();
}
