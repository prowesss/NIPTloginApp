namespace NIPTloginApp.Models
{
    public class ErrorViewModel
    {
        public string? requestid { get; set; }

        public bool showrequestid => !string.IsNullOrEmpty(requestid);
    }
}
