using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataBase.ModelConfigurations
{
    public class PaymentConfiguration : IEntityTypeConfiguration<Payment>
    {
        public void Configure(EntityTypeBuilder<Payment> builder)
        {
            builder.ToTable("Payments");
            builder.Property(_ => _.Id).ValueGeneratedOnAdd().UseIdentityColumn();

            builder.HasOne(s => s.Subscription)
                .WithOne(p => p.Payment)
                .HasForeignKey<Payment>(s => s.SubscriptionId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
