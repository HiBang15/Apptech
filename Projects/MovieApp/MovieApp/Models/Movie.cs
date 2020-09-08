using System;
namespace MovieApp.Models
{
    public class Movie
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public string Publisher { get; set; }
        public bool Previewed { get; set; }
        public int Year { get; set; }
        public string Type { get; set; }
    }
}
