﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace jafleet.Commons.EF
{
    [Table("CODE")]
    public partial class Code
    {
        [Key]
        [Column("CODE_ID")]
        public int? CodeId { get; set; }
        [Column("CODE_TYPE")]
        public string CodeType { get; set; }
        [Column("KEY")]
        public string Key { get; set; }
        [Column("VALUE")]
        public string Value { get; set; }
    }
}
