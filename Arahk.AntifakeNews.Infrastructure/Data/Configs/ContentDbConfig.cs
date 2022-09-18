using Arahk.AntifakeNews.Infrastructure.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Arahk.AntifakeNews.Infrastructure.Data.Configs;

public class ContentDbConfig : IEntityTypeConfiguration<ContentDbEntity>
{
    public void Configure(EntityTypeBuilder<ContentDbEntity> builder)
    {
        builder.HasKey(p => p.Id);
        builder.Property(p => p.TitleEn).HasMaxLength(150);
        builder.Property(p => p.TitleTh).HasMaxLength(150);
        builder.Property(p => p.Detail).HasMaxLength(1500).IsRequired();
        builder.Property(p => p.Organize).HasMaxLength(100).IsRequired();
        builder.Property(p => p.Author).HasMaxLength(100).IsRequired();
        builder.HasOne(p => p.CreatedBy).WithMany().HasForeignKey(p => p.CreatedById).IsRequired().OnDelete(DeleteBehavior.NoAction);

        builder.HasData(new []
        {
            new ContentDbEntity()
            {
                Author = "Sint incididunt"
                , CreatedById = Guid.Parse("ac7383b1-3703-462c-89c9-d8d5534d0db1")
                , CreatedOn = new DateTime(2022, 9, 18, 20, 54,0)
                , Detail = "Ea nisi laborum ullamco veniam ullamco nisi anim. Ad proident duis tempor sint reprehenderit nisi reprehenderit voluptate mollit veniam amet velit dolor est. Labore veniam sit dolor consectetur minim esse. Elit nisi Lorem magna ad enim elit pariatur laborum dolore deserunt esse.Tempor nulla in nisi tempor dolor Lorem. Minim mollit sunt sint aute occaecat Lorem quis incididunt adipisicing. Qui nisi consectetur occaecat eiusmod tempor ullamco minim nisi commodo est veniam sint ut fugiat. Do enim id ad irure incididunt magna consequat. Consectetur magna tempor Lorem tempor voluptate incididunt sit."
                , Id = Guid.Parse("7b5a9dec-7122-4844-983f-606a0add2e95")
                , Organize = "Est exercitation"
                , TitleEn = "Officia ea in elit commodo veniam."
                , TitleTh = ""
            },
            new ContentDbEntity()
            {
                Author = "Cupidatat"
                , CreatedById = Guid.Parse("ac7383b1-3703-462c-89c9-d8d5534d0db1")
                , CreatedOn = new DateTime(2022, 6, 28, 14, 27,0)
                , Detail = "Elit reprehenderit non occaecat nostrud esse et nisi nulla velit do esse proident aliqua reprehenderit. Ullamco est laboris do do duis sint. Consectetur fugiat cillum pariatur duis nisi et. Reprehenderit pariatur nulla laboris consectetur irure pariatur.Ad cillum quis sit minim commodo esse in mollit anim consequat et. Consectetur pariatur consequat proident deserunt commodo aliquip Lorem. Officia qui reprehenderit Lorem officia quis non aliquip qui officia velit ipsum. Id cupidatat nisi sint cillum dolor do est culpa exercitation voluptate aliquip. Id irure irure proident ex proident eiusmod irure deserunt deserunt excepteur veniam commodo fugiat id. Dolor consectetur in amet cupidatat mollit."
                , Id = Guid.Parse("1a210062-d9f5-4795-922a-2aa07827eca1")
                , Organize = "Proident exercitation"
                , TitleEn = "Anim dolor deserunt consectetur do ad deserunt."
                , TitleTh = "แล้วสอนว่าอย่าไว้ใจมนุษย์ มันแสนสุดลึกล้ำเหลือกำหนด"
            }
        });
    }
}