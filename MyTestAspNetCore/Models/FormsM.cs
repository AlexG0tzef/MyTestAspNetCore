using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MyTestAspNetCore.Models
{
    public class FormsM
    {
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
    }
}
