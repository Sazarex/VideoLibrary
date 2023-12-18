using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataBase.ModelConfigurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("Users");
            builder.Property(_ => _.Id).ValueGeneratedOnAdd().UseIdentityColumn();


            builder.HasOne(u => u.Subscription)
                .WithOne(s => s.User)
                .HasForeignKey<User>(u => u.SubscriptionId);
        }
    }
}
