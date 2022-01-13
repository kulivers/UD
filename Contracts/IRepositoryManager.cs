namespace Contracts;

public interface IRepositoryManager
{
    IMockCompanyRepository Company { get; }
    IMockEmployeeRepository Employee { get; }
    void Save();
}