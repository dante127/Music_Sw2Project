using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MusicMvc.Models
{
    public class Playlist
    {
        public int PlaylistId { get; set; }
        [StringLength(80)]
        public string Owner { get; set; }
        [StringLength(80)]
        public string Name { get; set; }


        //user id

        public virtual User user { get; set; }

        public int UserId { get; set; }
        //with music :

        public virtual List<Music> songs { get; set; }

    }

}