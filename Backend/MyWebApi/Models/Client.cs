using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyWebApi.Models
{
    [Table("clients")]
    public class Client
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int Id { get; set; }
        [Column("name")]
        public string? Name { get; set; }
        [Column("lastname")]
        public string? Lastname { get; set; }
        [Column("account_number")]
        public string? AccountNumber { get; set; }
        [Column("balance", TypeName = "decimal(15, 2)")]
        public decimal Balance { get; set; }
        [Column("date_of_birth")]
        public DateTime DateOfBirth { get; set; }
        [Column("address")]
        public string? Address { get; set; }
        [Column("phone")]
        public string? Phone { get; set; }
        [Column("email")]
        public string? Email { get; set; }
        [Column("client_type")]
        public string? ClientType { get; set; }
        [Column("marital_status")]
        public string? MaritalStatus { get; set; }
        [Column("identification_number")]
        public string? IdentificationNumber { get; set; }
        [Column("profession")]
        public string? Profession { get; set; }
        [Column("gender")]
        public string? Gender { get; set; }
        [Column("nationality")]
        public string? Nationality { get; set; }
    }
}
