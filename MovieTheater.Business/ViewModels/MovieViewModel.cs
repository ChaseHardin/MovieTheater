using System;
using MovieTheater.Data.Models;

namespace MovieTheater.Business.ViewModels
{
    public class MovieViewModel
    {
        static MovieViewModel()
        {
            AutoMapper.Mapper.CreateMap<Movie, MovieViewModel>().ReverseMap();
        }

        public Guid MovieId { get; set; }
        public string Name { get; set; }
        public decimal TicketPrice { get; set; }
        public string Rating { get; set; }
        public string Description { get; set; }
        public DateTime StartTime { get; set; }
        public double MovieDuration { get; set; }
    }
}