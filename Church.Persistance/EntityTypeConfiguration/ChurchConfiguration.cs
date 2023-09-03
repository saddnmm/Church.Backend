using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;//https://learn.microsoft.com/ru-ru/dotnet/api/microsoft.entityframeworkcore.metadata.builders.entitytypebuilder?view=efcore-7.0
using Church.Domain;

namespace Church.Persistance.EntityTypeConfiguration
{
    internal class ChurchConfiguration : IEntityTypeConfiguration<Tbsystem>
    {
        public void Configure(EntityTypeBuilder<Tbsystem> builder)
        {
            builder.HasKey(tbsystem => tbsystem.Tbsystem_id);
            builder.HasIndex(tbsystem => tbsystem.Tbsystem_id).IsUnique();
        }
    }
}
