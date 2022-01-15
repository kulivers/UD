using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repository;

public class CompanyConfiguration : IEntityTypeConfiguration<Company>
{
    public void Configure(EntityTypeBuilder<Company> builder)
    {
        builder.HasData(new Company()
        {
            Id = 1,
            Address = "manhaten",
            Country = "USA",
            Name = "PEPSI COLA"
        });
    }
}