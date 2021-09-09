using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api_AirPlus.Models
{
    [Table("t_employee")]
    public partial class TEmployee
    {
        [Key]
        [Column("id_employee")]
        public int IdEmployee { get; set; }

        [Column("nm_employee", TypeName = "varchar(100)")]
        public string NmEmployee { get; set; }

        [Column("nm_state", TypeName = "varchar(30)")]
        public string NmState { get; set; }

        [Column("nm_city", TypeName = "varchar(60)")]
        public string NmCity { get; set; }

        [Column("nm_district", TypeName = "varchar(60)")]
        public string NmDistrict { get; set; }
        
        [Column("nr_phone", TypeName = "varchar(30)")]
        public string NrPhone { get; set; }
    }
}
