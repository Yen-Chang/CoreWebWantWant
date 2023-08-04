using System;
using System.Collections.Generic;

namespace prjCoreWebWantWant.Models;

public partial class TaskList
{
    public int CaseId { get; set; }

    public int? AccountId { get; set; }

    public int? TaskNameId { get; set; }

    public string? TaskTitle { get; set; }

    public string? TaskDetail { get; set; }

    public int? WorkingHoursId { get; set; }

    public int? PayFrom { get; set; }

    public int? PayTo { get; set; }

    public int? SalaryId { get; set; }

    public int? TaskPlace { get; set; }

    public int? TownId { get; set; }

    public bool? WorkPlace { get; set; }

    public string? Address { get; set; }

    public string? RequiredNum { get; set; }

    public string? TaskPeriod { get; set; }

    public string? TaskStart { get; set; }

    public string? TaskEnd { get; set; }

    public string? Requirement { get; set; }

    public string? HumanList { get; set; }

    public string? LanguageRequired { get; set; }

    public int? SkillRequiredId { get; set; }

    public int? CertificateRequiredId { get; set; }

    public bool? ServiceStatus { get; set; }

    public int? StatusChangeReasonId { get; set; }

    public string? PublishOrNot { get; set; }

    public string? PublishStart { get; set; }

    public string? PublishEnd { get; set; }

    public int? CaseStatusId { get; set; }

    public int? OnTop { get; set; }

    public string? DataCreateDate { get; set; }

    public string? DataModifyDate { get; set; }

    public string? DataModifyPerson { get; set; }

    public bool? IsExpert { get; set; }

    public virtual ICollection<ApplicationList> ApplicationLists { get; set; } = new List<ApplicationList>();

    public virtual ICollection<CaseSkill> CaseSkills { get; set; } = new List<CaseSkill>();

    public virtual ICollection<ExpertApplication> ExpertApplications { get; set; } = new List<ExpertApplication>();

    public virtual ICollection<MemberCollection> MemberCollections { get; set; } = new List<MemberCollection>();

    public virtual ICollection<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();

    public virtual ICollection<TaskKeywordList> TaskKeywordLists { get; set; } = new List<TaskKeywordList>();

    public virtual ICollection<TaskPhoto> TaskPhotos { get; set; } = new List<TaskPhoto>();
}
