namespace CodeFirstApproch.Model
{
    public class Album
    {
        public int AlbumID { get; set; }
        public string? AlbumName { get;set; }
        public string?  AlbumDescription { get; set; }
        public string? AlbumType { get; set; }

       public Artiest Artiest { get; set; }

          
    }
}
