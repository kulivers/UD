using Contracts;

namespace Repository;

public sealed class RepositoryManager : IRepositoryManager
{
    private readonly RepositoryContext _repositoryContext;
    private readonly Lazy<IMockCompanyRepository> _mockCompanyRepository;
    private readonly Lazy<IMockEmployeeRepository> _mockEmployeeRepository;
    private readonly Lazy<ICompanyRepository> _companyRepository;
    private readonly Lazy<IItemRepository> _itemRepository;


    public RepositoryManager(RepositoryContext repositoryContext) // отсюда всем раскидывает
    {
        _repositoryContext = repositoryContext;
        _mockCompanyRepository = new Lazy<IMockCompanyRepository>(() => new
            MockCompanyRepository(repositoryContext));
        _mockEmployeeRepository =
            new Lazy<IMockEmployeeRepository>(() => new MockEmployeeRepository(repositoryContext));
        _companyRepository = new Lazy<ICompanyRepository>(() => new CompanyRepository(repositoryContext));
        _itemRepository = new Lazy<IItemRepository>(() => new ItemRepository(repositoryContext));
    }

    public IMockCompanyRepository MockCompany => _mockCompanyRepository.Value;
    public IMockEmployeeRepository MockEmployee => _mockEmployeeRepository.Value;
    public ICompanyRepository Company => _companyRepository.Value;
    public IItemRepository Item => _itemRepository.Value;

    public void Save() => _repositoryContext.SaveChanges();
}