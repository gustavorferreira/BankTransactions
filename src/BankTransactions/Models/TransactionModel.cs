using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BankTransactions.Models
{
    public class TransactionModel
    {
        [Key]
        public int TransactId { get; set; }

        [Column(TypeName ="nvarchar(12)")]
        public string AccountNumber { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string BeneficiaryName { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string BankName { get; set; }

        [Column(TypeName = "nvarchar(11)")]
        public string SwiftCode { get; set; }

        public int Ammount { get; set; }

        public DateTime Date { get; set; }
    }
}
