using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using MovieTheater.Business.ViewModels;
using MovieTheater.Data;

namespace MovieTheater.Business.Services
{
    public class MovieService : BaseService
    {
        public List<MovieViewModel> GetMovies()
        {
            using (var db = Application.GetDatabaseInstance())
            {
                return db.Movies.Select(Mapper.Map<MovieViewModel>).ToList();
            }
        }
    }
}