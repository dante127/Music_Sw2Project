using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MusicMvc.Models
{
    public class Album
    {
        public int AlbumId { get; set; }

        [StringLength(80)]
        public string Name { get; set; }
        public string Image { get; set; }
        public DateTime Date { get; set; }

       
        //Relation Singers:
        public virtual List<Singer> Singers { get; set; }


        //Relation List of songs:


        public virtual List<Music> Songs { get;set; }


    }
}