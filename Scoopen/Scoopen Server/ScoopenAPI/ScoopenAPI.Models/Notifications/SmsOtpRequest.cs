namespace ScoopenAPI.Models.Notifications
{
    public class OtpRequest
    {
        public string Email { get; set; }
        public string Mobile { get; set; }
        public string SessionId { get; set; }
        public string Otp { get; set; }
    }
}
