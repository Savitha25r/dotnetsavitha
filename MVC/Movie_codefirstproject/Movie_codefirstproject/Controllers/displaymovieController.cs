using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Movie_codefirstproject.Models;

namespace Movie_codefirstproject.displaymovie
{
    public class displaymovieController : Controller
    {
        MovieContext mm = new MovieContext();
        // GET: displaymovie
        public ActionResult Index(string value)

        {
            List<displaymoviemodel> dm = new List<displaymoviemodel>
            {
               new displaymoviemodel(){MovieName="dhrishiyam",MovieYear=2000},
               new displaymoviemodel(){MovieName="Gandada Gudi",MovieYear=2022},
               new displaymoviemodel(){MovieName="Bommarillu",MovieYear=2016},
               new displaymoviemodel(){MovieName="Accham yenbadhu Madamaiyada",MovieYear=2018},
               new displaymoviemodel(){MovieName="Vinnaithaandi varuvaaaya",MovieYear=2012}

            };
            var ans = dm.Where(Sd => Sd.MovieYear == (Convert.ToInt32(value)) || value == null).ToList();
            return View(ans);
        }

    }
}





////var result = mc.movies.Where(x => x.RDate.Year.ToString().Contains(search) || search == null).ToList();