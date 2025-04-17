
namespace SoftwareServerpp.Models
{
    public class SoftwareDetails
    {
        public string DisplayName { get; set; }
        public string DisplayVersion { get; set; }
        public string Publisher { get; set; }
        public string InstallDate { get; set; } // e.g. "20240401"
        public string InstallLocation { get; set; }
        public double EstimatedSize { get; set; } // optional
    }
}
