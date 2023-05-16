namespace ECommerceAPI.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; } = string.Empty;
        public string? Password { get; set; } // Store hashed passwords, not plain text!
        // Add other properties as needed
    }
}