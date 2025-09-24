namespace Jumia.Models
{
    public class Image
    {
        public int Id { get; set; }
        public string? ImageName { get; set; }
        public byte[]? ImageData { get; set; }  // Maps to VARBINARY(MAX)
        public string? ContentType { get; set; }
    }
}
 