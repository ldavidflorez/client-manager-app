using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyWebApi.Models
{
    [Table("app_users")]
    public class AppUser
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int Id { get; set; }
        [Column("username")]
        public string? Username { get; set; }
        [Column("password")]
        public string? Password { get; set; }
        [Column("role")]
        public string? Role { get; set; }
        [Column("created_at")]
        public DateTime CreatedAt { get; set; }
    }
}