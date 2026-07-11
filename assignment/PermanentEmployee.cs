class PermanentEmployee : Employee
{
    public PermanentEmployee(int id, string name, string dept)
        : base(id, name, dept)
    {
        SetLeaveBalance();
    }

    public override void SetLeaveBalance()
    {
        LeaveBalance = 24;
    }
}