using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Shob.Project.Models.Entities;
using System.Reflection.Emit;

namespace Shop.Project.DAL.Conficurations;

public class CategoryConficuration : IEntityTypeConfiguration<Category>
{
    public void Configure(EntityTypeBuilder<Category> builder)
    {
        builder.Ignore(c => c.UpdatedDate);
    }
}
