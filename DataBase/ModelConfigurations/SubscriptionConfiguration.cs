using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataBase.ModelConfigurations
{
    public class SubscriptionConfiguration : IEntityTypeConfiguration<Subscription>
    {
        public void Configure(EntityTypeBuilder<Subscription> builder)
        {
            builder.ToTable("Subscriptions");
            builder.Property(_ => _.Id).ValueGeneratedOnAdd().UseIdentityColumn();

            builder.HasOne(s => s.User)
                .WithOne(u => u.Subscription)
                .HasForeignKey<Subscription>(s => s.UserId);

            builder.HasOne(s => s.Payment)
                .WithOne(p => p.Subscription)
                .HasForeignKey<Subscription>(s => s.PaymentId);
        }
    }
}
