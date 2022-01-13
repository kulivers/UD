using Contracts;

namespace Repository;

public sealed class RepositoryManager : IRepositoryManager
{
    private readonly RepositoryContext _repositoryContext;
    private readonly Lazy<IMockCompanyRepository> _companyRepository;
    private readonly Lazy<IMockEmployeeRepository> _employeeRepository;

    public RepositoryManager(RepositoryContext repositoryContext)
    {
        _repositoryContext = repositoryContext;
        _companyRepository = new Lazy<IMockCompanyRepository>(() => new
            MockCompanyRepository(repositoryContext));
        _employeeRepository = new Lazy<IMockEmployeeRepository>(() => new
            MockEmployeeRepository(repositoryContext));
    }

    public IMockCompanyRepository Company => _companyRepository.Value;
    public IMockEmployeeRepository Employee => _employeeRepository.Value;
    public void Save() => _repositoryContext.SaveChanges();
}