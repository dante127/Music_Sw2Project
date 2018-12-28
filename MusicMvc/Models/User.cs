using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MusicMvc.Models
{
    public class User
    {
        [Key, ForeignKey("Subscription")]
        public int UserId { get; set; }

        [StringLength(80)]
        public string Name { get; set; }
        [StringLength(80)]
        public string Email { get; set; }
        [StringLength(80)]
        public string  Password { get; set; }
        [StringLength(40)]
        public string Gender { get; set; }
        public DateTime Birthdate { get; set; }
        public bool Ispremuim { get; set; }

        //with music :

        public virtual List<Music> Songs { get; set; }
        //with playlsit:

        public virtual List<Playlist> playlists { get; set; }

        //with subscribtion:

        public Subscription Subscription { get; set; }


        public int SubscriptionId { get; set; }


    }
}