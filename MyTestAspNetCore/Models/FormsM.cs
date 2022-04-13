using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MyTestAspNetCore.Models
{
    public class FormsM
    {
        #region Form
        [Key]
        public int Id { get; set; }

        [Required]
        public OrganizationM Organization { get; set; }

        [DisplayName("Форма")]
        public string FormNum { get; set; }

        [DisplayName("Дата начала периода")]
        public string StartPeriod { get; set; }

        [DisplayName("Дата конца периода")]
        public string EndPeriod { get; set; }

        [DisplayName("Номер корректировки")]
        public int CorNum { get; set; }
        #endregion

        #region Form11
        public int? NumberPP1 { get; set; }
        public int? Cod2 { get; set;}
        public DateTime? Date3 { get; set; }
        public int? NumberPassport4 { get; set; }
        public int? Type5 { get; set; }
        public string? Radionuclid6 { get; set; }
        public int? Number7 { get; set; }
        public int? Kol8 { get; set; }
        public int? SumActiv9 { get; set; }
        public int? CodOKPO10 { get; set; }
        public DateTime? Date11 { get; set; }
        public string? Category12 { get; set; }
        public int? NSS13 { get; set; }
        public int? Cod14 { get; set; }
        public int? CodOKPO15 { get; set; }
        public string? Vid16 { get; set; }
        public int? Number17 { get; set; }
        public DateTime? Date18 { get; set; }
        public int? CodPos19 { get; set; }
        public int? CodPer20 { get; set; }
        public string? Name21 { get; set; }
        public string? Type22 { get; set; }
        public int? Number23 { get; set; }
        #endregion
    }
}
