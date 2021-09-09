using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api_AirPlus.Models
{
    [Table("t_prontuario")]
    public partial class TProntuario
    {
        [Key]
        [Column("id_prontuario")]
        public int IdProntuario { get; set; }

        [Column("nm_paciente", TypeName = "varchar(100)")]
        public string NmPaciente { get; set; }

        [Column("rg_paciente", TypeName = "varchar(100)")]
        public string RgPaciente { get; set; }

        [Column("vl_idade")]
        public int? VlIdade { get; set; }

        [Column("ds_doenca", TypeName = "varchar(255)")]
        public string DsDoenca { get; set; }

        [Column("ds_alergia", TypeName = "varchar(255)")]
        public string DsAlergia { get; set; }

        [Column("ds_cirurgia", TypeName = "varchar(255)")]
        public string DsCirurgia { get; set; }

        [Column("ds_tranfusao_sanguinea", TypeName = "varchar(100)")]
        public string DsTranfusaoSanguinea { get; set; }

        [Column("ds_medicamento", TypeName = "varchar(255)")]
        public string DsMedicamento { get; set; }
        
        [Column("ds_outros", TypeName = "varchar(255)")]
        public string DsOutros { get; set; }
    }
}
