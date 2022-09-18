using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Arahk.AntifakeNews.Infrastructure;

public class UserDbConfig : IEntityTypeConfiguration<UserDbEntity>
{
    public void Configure(EntityTypeBuilder<UserDbEntity> builder)
    {
        builder.HasKey(p => p.Id);
        builder.Property(p => p.Firstname).HasMaxLength(100).IsRequired();
        builder.Property(p => p.Lastname).HasMaxLength(100).IsRequired();

        builder.HasData(new []
        {
            new UserDbEntity()
            {
                Id = Guid.Parse("ac7383b1-3703-462c-89c9-d8d5534d0db1")
                , Firstname = "Estio"
                , Lastname = "officia"
            }
        });
    }
}