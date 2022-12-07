using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace Movie_codefirstproject.displaymovie
{
    public class displaymoviemodel
    {
        [Key]
        public String MovieName { get; set; }
        public int MovieYear { get; set; }


    }
}