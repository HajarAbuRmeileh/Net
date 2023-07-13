using System.ComponentModel.DataAnnotations.Schema;

namespace Chatbot.Models
{
    [NotMapped]
    public class PackageViewModel
    {
        
        //public string IdentityID { get; set; }
        public string MailBoxItem { get; set; }
        public string TrackingNumber { get; set; }
        public string LogisticsOrderCode { get; set; }
        public string BuyerAddress { get; set; }
        public string BuyerPhone { get; set; }
        public string BuyerName { get; set; }
        public string BuyerMobile { get; set; }
        public string BuyerEmail { get; set; }
        public string RecieverName { get; set; }
        public string RecieverAddress { get; set; }
        public string RecieverZipCode { get; set; }
    }
    [NotMapped]
    public class PackageModel
    {
        public string logistics_interface { get; set; }
        public string data_digest { get; set; }
        public string partner_code { get; set; }
        public string from_code { get; set; }
        public string msg_type { get; set; }
        public string msg_id { get; set; }

    }
}
