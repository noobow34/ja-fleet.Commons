using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace jafleet.Commons.EF
{
    [Table("MESSAGE")]
    public class Message
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("MESSAGE_ID")]
        public int? MessageId { get; set; }
        [Column("MESSAGE_TYPE")]
        public string MessageType { get; set; }
        [Column("SENDER")]
        public string Sender { get; set; }
        [Column("REPLAY_TO")]
        public string ReplayTo { get; set; }
        [Column("MESSAGE")]
        public string MessageDetail { get; set; }
        [Column("RECIEVE_DATE")]
        public DateTime? RecieveDate { get; set; }
    }
}
