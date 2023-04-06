using System.ComponentModel.DataAnnotations;

namespace CustomerTransaction_History.Models
{
    public class Clients
    {
        [Key]
        public int ClientID { get; set; }
        public float ClientBalance { get; set; }
        public string ClientName { get; set; }

        //relationships
        public Transactions Transactions { get; set; }
    }
}
