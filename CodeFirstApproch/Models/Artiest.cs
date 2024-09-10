namespace CodeFirstApproch.Model
{
    public class Artiest
    {
        public int ArtiestId { get; set; }
        public string? ArtiestName { get; set; }
        public string? ArtiestDescription { get; set; }
        public string? ArtiestVersion { get; set; }

    public ICollection<Album> Albums { get; set; }

    }
}
