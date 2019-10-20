using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hackathon.Models
{
    public class DbService
    {

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int ServiceId { get; set; }
        [ForeignKey("ServiceId")] public Service Service { get; set; }
        public int UserId { get; set; }
        [ForeignKey("UserId")] public DbUser User { get; set; }
    }
}