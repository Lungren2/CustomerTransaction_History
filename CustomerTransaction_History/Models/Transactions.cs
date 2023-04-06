using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CustomerTransaction_History.Models
{
    public class Transactions
    {
        [Key]
        public int TransactionID { get; set; }
        public List<string> transactions { get; set; }
        public float Amount { get; set; }
        public int TransactionType_ID { get; set; }
        [ForeignKey("TransactionType_ID")]
        public int ClientID { get; set; }
        [ForeignKey("ClientID")]
        public string Comment { get; set; }

    }
}
