using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MusicMvc.Models
{
    public class Subscription
    {
        [Key, ForeignKey("User")]
        public int SubscriptionId { get; set; }
        public double duration { get; set; }
        public decimal Price { get; set; }


        //user id : 
        public User User { get; set; }


        public int UserId { get; set; }

    }
}