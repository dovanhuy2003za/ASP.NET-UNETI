using btTuan2.Data;

namespace btTuan2.Models
{
    public class SeedData
    {
        public static void Initialize(MVCmovieContext mVCmovieContext)
        {
            
                // Look for any movies.
                if (mVCmovieContext.Movie.Any())
                {
                    return;   // DB has been seeded
                }

                mVCmovieContext.Movie.AddRange(
                    new Movie
                    {
                        Title = "When Harry Met Sally",
                        ReleaseDate = DateTime.Parse("1989-2-12"),
                        Genre = "Romantic Comedy",
                        Price = 700000
                    },

                    new Movie
                    {
                        Title = "Ghostbusters",
                        ReleaseDate = DateTime.Parse("1984-3-13"),
                        Genre = "Comedy",
                        Price = 855555
                    },

                    new Movie
                    {
                        Title = "Ghostbusters 2",
                        ReleaseDate = DateTime.Parse("1986-2-23"),
                        Genre = "Comedy",
                        Price = 958877
                    },

                    new Movie
                    {
                        Title = "Rio Bravo",
                        ReleaseDate = DateTime.Parse("1959-4-15"),
                        Genre = "Western",
                        Price = 35282444
                    }
                );
            mVCmovieContext.SaveChanges();
        }
    }
}
