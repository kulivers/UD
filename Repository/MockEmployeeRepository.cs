using Contracts;
using Entities.Models;

namespace Repository;

public class MockEmployeeRepository : RepositoryBase<MockEmployee>, IMockEmployeeRepository
{
    public MockEmployeeRepository(RepositoryContext repositoryContext)
        : base(repositoryContext)
    {
    }
}