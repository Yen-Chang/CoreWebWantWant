using System;
using System.Collections.Generic;

namespace prjCoreWebWantWant.Models;

public partial class Salary
{
    public int SalaryId { get; set; }

    public string? Payment { get; set; }

    public DateTime? PaymentDate { get; set; }
}
