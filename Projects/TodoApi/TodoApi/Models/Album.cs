using System;
namespace TodoApi.Models
{
    public class Album
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Genre { get; set; }
        public int Year { get; set; }
        public int Price { get; set; }
    }
}
