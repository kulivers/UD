using Contracts;
using Entities.Models;

namespace Repository;

public class MockCompanyRepository : RepositoryBase<MockCompany>, IMockCompanyRepository
{
    public MockCompanyRepository(RepositoryContext repositoryContext)
        : base(repositoryContext)
    {
    }
}