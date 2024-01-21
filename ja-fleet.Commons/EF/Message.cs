﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace jafleet.Commons.EF
{
    [Table("message")]
    public class Message
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("message_id")]
        public int? MessageId { get; set; }
        [Column("message_type")]
        public string MessageType { get; set; }
        [Column("sender")]
        public string Sender { get; set; }
        [Column("replay_to")]
        public string ReplayTo { get; set; }
        [Column("message")]
        public string MessageDetail { get; set; }
        [Column("recieve_date")]
        public DateTime? RecieveDate { get; set; }
    }
}
