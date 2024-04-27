using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Data;

namespace NT106_WebServer.Models
{
    public class MovieModel
    {
        [Required]
        public Movie MovieInfo { get; set; }
        public List<Episodes>? Episodess { get; set; }
        public List<Season> Seasons { get; set; }
        public List<Person> Directors { get; set; }
        public List<Person> Writers { get; set; }
        public List<Person> Creators { get; set; }
      
        public class Movie
        {
            public string MovieId { get; set; }
            public string MovieName { get; set; }
            public DateTime ReleaseDate { get; set; }
            public int Duration { get; set; }
            public string ContentRating { get; set; }
            public double IMDbScore { get; set; }
            public int RatingCount { get; set; }
            public string PosterURL { get; set; }
            public string BackgroundURL { get; set; }
            public string? TrailerURL { get; set; }
            public string Description { get; set; }
            public int? TotalViews { get; set; }
            public int? TotalEpisodes { get; set; }
            public int? CurrentEpisodes { get; set; }
            public int? IMDbEpisodes { get; set; }
            public int? TotalReviews { get; set; }
            public double? RatingRatio { get; set; }
            public bool IsTVShows { get; set; }
        }
        public class Episodes
        {
            public List<Cast>? Casts { get; set; }
            public List<EpisodeCreator>? Creators { get; set; }
            public List<EpisodeDirectors>? Directors { get; set; }
            public List<EpisodeWriters>? Writers { get; set; }
            public List<EpisodeGenres>? Genres { get; set; }
            public List<EpisodeKeywords>? Keywords { get; set; }
            public string Id { get; set; }
            public string MovieId { get; set; }
            public string Season { get; set; }
            public string? Episode { get; set; }
            public DateTime? ReleaseDate { get; set; }
            public int? Duration { get; set; }
            public string? Image { get; set; }
            public string? ImageCaption { get; set; }
            public string? Title { get; set; }
            [JsonProperty("Plot")]
            public string? Plot { get; set; }
            public double? AggregateRating { get; set; }
            public int? VoteCount { get; set; }
        }
        public class Person
        {
            public string Id { get; set; }
            public string? Name { get; set; }
            public string? Image { get; set; }
        }
        public class Cast
        {
            public string? EpisodeId { get; set; }
            public Person Person { get; set; }
            public string CharacterName { get; set; }
        }

        public class MovieDirectors
        {
            public string? MovieId { get; set; }
            public string PersonId { get; set; }
        }
        public class MovieWriters
        {
            public string? MovieId { get; set; }
            public string PersonId { get; set; }
        }
        public class MovieCreator
        {
            public string? MovieId { get; set; }
            public string PersonId { get; set; }
        }
        public class EpisodeDirectors
        {
            public string? MovieId { get; set; }
            public Person Person { get; set; }
        }
        public class EpisodeWriters
        {
            public string? MovieId { get; set; }
            public Person Person { get; set; }
        }
        public class EpisodeCreator
        {
            public string? MovieId { get; set; }
            public Person Person { get; set; }
        }
        public class EpisodeGenres
        {
            public string? EpisodeId { get; set; }
            public string Name { get; set; }
        }

        public class EpisodeKeywords
        {
            public string? EpisodeId { get; set; }
            public string Name { get; set; }
        }
        public class Season
        {
            public string? MovieId { get; set; }
            public string Name { get; set; }
        }

    }
}
