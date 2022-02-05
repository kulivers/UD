using Contracts;

namespace Repository;

public sealed class RepositoryManager : IRepositoryManager
{
    private readonly RepositoryContext _repositoryContext;
    private readonly Lazy<IMockCompanyRepository> _mockCompanyRepository;
    private readonly Lazy<IMockEmployeeRepository> _mockEmployeeRepository;


    public RepositoryManager(RepositoryContext repositoryContext) // отсюда всем раскидывает
    {
        _repositoryContext = repositoryContext;
        _mockCompanyRepository = new Lazy<IMockCompanyRepository>(() => new
            MockCompanyRepository(repositoryContext));
        _mockEmployeeRepository =
            new Lazy<IMockEmployeeRepository>(() => new MockEmployeeRepository(repositoryContext));
    }

    public IMockCompanyRepository MockCompany => _mockCompanyRepository.Value;
    public IMockEmployeeRepository MockEmployee => _mockEmployeeRepository.Value;

    public void Save() => _repositoryContext.SaveChanges();
}