using System;
using System.Collections.Generic;

namespace BankSystem.Models;

public partial class BankTransaction
{
    public int Id { get; set; }

    public int? FromAccountId { get; set; }

    public string? BranchId { get; set; }

    public DateOnly? DateOfTrans { get; set; }

    public double? Amount { get; set; }

    public string? Pin { get; set; }

    public int? ToAccountId { get; set; }

    public string? EmployeeId { get; set; }

    public virtual Branch? Branch { get; set; }

    public virtual Employee? Employee { get; set; }

    public virtual AccountModel? FromAccount { get; set; }

    public virtual AccountModel? ToAccount { get; set; }
}
