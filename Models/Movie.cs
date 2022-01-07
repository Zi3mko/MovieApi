namespace MovieApi
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; } = String.Empty;
        public string Director { get; set; } = String.Empty;
        public string Cast { get; set; } = String.Empty;
        public string ReleaseYear { get; set; } = String.Empty;
        public string Duration { get; set; } = String.Empty;
        public string Categories { get; set; } = String.Empty;
        public string Description { get; set; } = String.Empty;

    }
}
