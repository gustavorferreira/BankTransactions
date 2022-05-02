using System.ComponentModel.DataAnnotations;

namespace BankTransactions.Models
{
    public class TransactionModel
    {
        [Key]
        public int TransactId { get; set; }

        public string AccountNumber { get; set; }

        public string BeneficiaryName { get; set; }

        public string BankName { get; set; }    

        public string SwiftCode { get; set; }

        public int Ammount { get; set; }

        public DateTime Date { get; set; }
    }
}
