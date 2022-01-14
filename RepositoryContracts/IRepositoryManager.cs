namespace RepositoryContracts;

public interface IRepositoryManager
{
    IMockCompanyRepository Company { get; }
    IMockEmployeeRepository Employee { get; }
    void Save();
}