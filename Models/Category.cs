namespace PhotoAlbum.Models
{
    public class Category
    {
        //Primary key
        public int CategoryId { get; set; }

        public string Title { get; set; } = string.Empty;

        //Navigation property
        public List<Photo>? Photos { get; set; } //'?' means it can be null
        //This allows it to not have to load all photos and running extra queries
    }
}
