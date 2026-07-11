class ContractEmployee : Employee
{
    public ContractEmployee(int id, string name, string dept)
        : base(id, name, dept)
    {
        SetLeaveBalance();
    }

    public override void SetLeaveBalance()
    {
        LeaveBalance = 12;
    }
}