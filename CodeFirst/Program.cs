using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeFirst.EntityConfiguration;
//using System.Linq;
namespace CodeFirst
{

    class Program
    {
        static void Main(string[] args)
        {
            CodeFirstContext context = new CodeFirstContext();
            //var actionmovies = context.Videos.Where(v => v.Genre.Name == "Action");
            //var dramaMovies = context.Videos.Where(v => v.Genre.Name == "Drama").OrderByDescending(v => v.ReleaseDate);
            //var movies = context.Videos.Select(v => new { MovieName = v.Name, Genre = v.Genre.Name });
            //var moviesByClassification = context.Videos.GroupBy(v => v.Classification).OrderBy(v => v.Key);
            //var moviesByGenre = context.Videos.GroupBy(v => v.Genre.Name).OrderByDescending(mg => mg.Count());
            var videos = context.Videos.Include(v => v.Genre).ToList();
            foreach(var video in videos)
            {
                Console.WriteLine(video.Genre.Name);
            }

            //foreach (var m in moviesByClassification)
            //{
            //    //Console.WriteLine("{0} {1}",movie.MovieName,movie.Genre);
            //    Console.WriteLine("{0} ({1})",m.Key,m.Count());
            //    //foreach (var movie in m)
            //        //Console.WriteLine("\t" + movie.Name);
                   
            //}
            //foreach (var mg in moviesByGenre)
            //{
            //    //Console.WriteLine("{0} {1}",movie.MovieName,movie.Genre);
            //    Console.WriteLine("{0} ({1})", mg.Key, mg.Count());
            //    //foreach (var movie in m)
            //    //Console.WriteLine("\t" + movie.Name);

            //}
        }
    }
}
