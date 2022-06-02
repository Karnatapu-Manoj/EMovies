﻿using EMovies.Data.BaseRepo;
using EMovies.Data.ViewModel;
using EMovies.Models;

namespace EMovies.Data.Services
{
    public interface IMoviesService : IEntityBaseRepository<Movie>
    {
        Task<Movie?> GetMovieByIdAsync(int id);
        Task<NewMovieDropdownsVM?> GetNewMovieDropdownsValues();

        Task AddNewMovieAsync(NewMovieVM data);
        Task UpdateMovieAsync(NewMovieVM data);

    }
}
