using RoomScheduling.Domain.Models;
using System.Data.Entity.ModelConfiguration;

namespace RoomScheduling.Infrastructure.Mapping
{
    class UserMap : EntityTypeConfiguration<User>
    {
        public UserMap()
        {

        }
    }
}
