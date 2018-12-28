using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MusicMvc.Models
{
    public class Music
    {
        [Key, ForeignKey("Lyrics")]
        public int MusicId { get; set; }
        [StringLength(80)]
        public string Name { get; set; }
        [StringLength(80)]
        public string type { get; set; }
        [StringLength(20)]
        public string Language { get; set; }
        public int Length { get; set; }
        [StringLength(80)]
        public string Path { get; set; }
        public string Image { get; set; }
        //album id :
        public virtual Album Album { get; set; }

        public int AlbumId { get; set; }


        //with user M2M
        public virtual List<User> users { get; set; }

        //with playlist m2m
        public virtual List<Playlist> playlists { get; set; }

        //with lyrics:

        [ForeignKey("LyricsFk")]
        public virtual Lyrics Lyrics { get; set; }

        public int LyricsId { get; set; }
            



    }
}