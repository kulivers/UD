namespace Contracts;

public interface IRepositoryManager
{
    IMockCompanyRepository MockCompany { get; }
    IMockEmployeeRepository MockEmployee { get; }
    void Save();
}