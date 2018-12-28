using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MusicMvc.Models
{
    public class Lyrics
    {
        [Key, ForeignKey("Music")]
        public int LyricsId { get; set; }

        [StringLength(180)]
        public string description { get; set; }

        //song id :

        [ForeignKey("MusicFk")]
        public virtual Music Music { get; set; }
  
        public int MusicId { get; set; }

    }
}