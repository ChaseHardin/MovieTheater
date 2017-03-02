using System;

namespace MovieTheater.Data.Models
{
    public class Movie
    {
        public Guid MovieId { get; set; }
        public string Name { get; set; }
        public decimal TicketPrice { get; set; }
        public string Rating { get; set; }
        public string Description { get; set; }
        public DateTime StartTime { get; set; }
        public double MovieDuration { get; set; }
    }
}