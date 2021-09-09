using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api_AirPlus.Models
{
    [Table("t_permission")]
    public partial class TPermission
    {
        [Key]
        [Column("id_permission")]
        public int IdPermission { get; set; }

        [Column("nm_employee", TypeName = "varchar(100)")]
        public string NmEmployee { get; set; }

        [Column("ds_permission", TypeName = "varchar(255)")]
        public string DsPermission { get; set; }
        
        [Column("bt_disponivel")]
        public bool? BtDisponivel { get; set; }
    }
}
