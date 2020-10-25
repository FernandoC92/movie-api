namespace movieApi.Dtos
{
    public class MovieReadDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string PosterPath { get; set; }
        public string Genre { get; set; }
        public string Synopsis { get; set; }
        public string ReleaseDate { get; set; }
        public string Classification { get; set; }
        public string Producer { get; set; }
        public string Duration { get; set; }
        public string Budget { get; set; }
        public string GateMoney { get; set; }
    }
}