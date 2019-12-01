using System;
using Microsoft.EntityFrameworkCore;
namespace RazorPagesMovie.data
{
    public class RazorPagesMovieContext:DbContext
    {
        public RazorPagesMovieContext(DbContextOptions<RazorPagesMovieContext> options)
            : base(options)
        {
        }
    }
}
