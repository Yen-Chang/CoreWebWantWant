using System;
using System.Collections.Generic;

namespace prjCoreWebWantWant.Models;

public partial class TaskNameList
{
    public int TaskNameId { get; set; }

    public string? TaskName { get; set; }

    public virtual ICollection<Resume> Resumes { get; set; } = new List<Resume>();
}
