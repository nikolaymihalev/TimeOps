namespace TimeOps.Core.Abstractions;

internal interface IWorkSchedule
{
    IReadOnlySet<DayOfWeek> WorkingDaysOfWeek { get; }
    TimeOnly? WorkdayStart { get; } 
    TimeOnly? WorkdayEnd   { get; }
}