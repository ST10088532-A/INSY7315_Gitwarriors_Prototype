namespace WIL_Website_prototype.Models
{
    public class Clientdashboard
    {
        public int OpenTickets { get; set; }
        public int NetworkHealthScore { get; set; } // e.g. percentage
        public DateTime NextMaintenanceDate { get; set; }
        public string InvoiceStatus { get; set; } = string.Empty;

    }
}

