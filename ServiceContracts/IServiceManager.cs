namespace ServiceContracts;

public interface IServiceManager
{
    IMockCompanyService MockCompanyService { get; }
    IMockEmployeeService MockEmployeeService { get; }
    ICompanyService CompanyService { get; }
    IItemService ItemService { get; }
}