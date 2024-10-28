using System;
using System.Collections.Generic;

namespace BankSystem.Models;

public partial class Branch
{
    public string Id { get; set; } = null!;

    public string? Name { get; set; }

    public string? HouseNo { get; set; }

    public string? City { get; set; }

    public virtual ICollection<BankTransaction> BankTransactions { get; set; } = new List<BankTransaction>();
}
