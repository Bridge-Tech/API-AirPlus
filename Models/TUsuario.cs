using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api_AirPlus.Models
{
    [Table("t_usuario")]
    public partial class TUsuario
    {
        [Key]
        [Column("id_usuario")]
        public int IdUsuario { get; set; }

        [Column("nm_usuario", TypeName = "varchar(100)")]
        public string NmUsuario { get; set; }
        
        [Column("ds_senha", TypeName = "varchar(10)")]
        public string DsSenha { get; set; }
    }
}
