using CustomerTransaction_History.Data.Enums;
using System.ComponentModel.DataAnnotations;

namespace CustomerTransaction_History.Models
{
    public class TransactionTypes
    {
        [Key]
        public int TransactionType_ID { get; set; }
        public Transactions_Debit_Credit transactions_Debit_Credit{ get; set; }
    }
}
