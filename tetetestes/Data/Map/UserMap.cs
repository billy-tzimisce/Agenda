using System.Data.Entity.ModelConfiguration;
using Agenda.Domain.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;

namespace Agenda.Data.Map
{
    public class UserMap : EntityTypeConfiguration<User>
    {
        public UserMap() 
        {
            ToTable("User");

            Property(x => x.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(x => x.Nome)
                .HasMaxLength(60)
                .IsRequired();

            Property(x => x.Email)
                .HasMaxLength(160)
                .IsRequired();

            Property(x => x.CPF)
                .HasMaxLength(14)
                 .HasColumnAnnotation(
                    IndexAnnotation.AnnotationName,
                    new IndexAnnotation(new IndexAttribute("CPF", 1) { IsUnique = true }))
                .IsRequired();

            Property(x => x.Endereco)
                .HasMaxLength(100)
                .IsRequired();

            Property(x => x.Telefone)
                .HasMaxLength(14)
                .IsRequired();
        }

    }
}
