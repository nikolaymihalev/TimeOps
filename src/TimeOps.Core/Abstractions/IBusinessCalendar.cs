namespace TimeOps.Core.Abstractions;

internal interface IBusinessCalendar
{
    bool IsWeekend(DateOnly date);
    bool IsHoliday(DateOnly date);
    bool IsWorkday(DateOnly date);
    
    DateOnly NextWorkday(DateOnly date, bool includeToday = false);
    DateOnly PreviousWorkday(DateOnly date, bool includeToday = false);

    DateOnly AddBusinessDays(DateOnly date, int days);
    int BusinessDaysBetween(DateOnly start, DateOnly end, bool inclusive = false);
}