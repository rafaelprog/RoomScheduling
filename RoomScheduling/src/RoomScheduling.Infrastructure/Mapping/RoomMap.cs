using RoomScheduling.Domain.Models;
using System.Data.Entity.ModelConfiguration;

namespace RoomScheduling.Infrastructure.Mapping
{
    public class RoomMap : EntityTypeConfiguration<Room>
    {
        public RoomMap()
        {

        }
    }
}
