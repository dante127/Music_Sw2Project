using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MusicMvc.Models
{
    public class Singer
    {
        public int SingerId { get; set; }
        [StringLength(80)]
        public string Name { get; set; }
        public int rate { get; set; }



        //list of albums
        public virtual List<Album> Albums { get; set; }


    }
}