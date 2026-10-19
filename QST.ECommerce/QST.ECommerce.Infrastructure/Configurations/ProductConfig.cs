using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QST.ECommerce.Domain.Catalogue;

namespace QST.ECommerce.Infrastructure.Configurations;

// Class to Map Product Entity with the Underlying Database Table (Product)
// Purpose: Mapt Entity with Table plus apply necessary Database Level Validations

public class ProductConfig : IEntityTypeConfiguration<Product>
{
    // Class which is used to Map the Entity with the Underlying Database Table. Also it performs validation
    public void Configure(EntityTypeBuilder<Product> builder)
    {
        builder.ToTable("Products");
        builder.HasKey(x => x.Id); // Primary Key (Not Null, Not Duplicate)
        builder.Property(x => x.Id).IsRequired();
        builder.Property(x => x.ProductName).HasColumnName("Name").IsRequired().HasMaxLength(300);
        builder.Property(x => x.UnitPrice).HasColumnName("Price");
        //throw new NotImplementedException();
    }
}


