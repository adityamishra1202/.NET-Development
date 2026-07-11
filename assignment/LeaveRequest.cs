using System;

class LeaveRequest
{
    public int LeaveId, EmployeeId, NumberOfDays;
    public string Reason;

    public LeaveRequest(int lid, int eid, int days, string reason)
    {
        LeaveId = lid;
        EmployeeId = eid;
        NumberOfDays = days;
        Reason = reason;
    }

    public void Display()
    {
        Console.WriteLine(LeaveId + " " + EmployeeId + " " + NumberOfDays + " " + Reason);
    }
}