using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MyTestAspNetCore.Models
{
    public class OrganizationM
    {
        [Key]
        public int Id { get; set; }

        public List<FormsNumberM> Form { get; set; }

        [DisplayName("Орган управления использованием атомной энергии")]
        public string OrganYprav { get; set; }

        [DisplayName("Рег. №")]
        public int RegNumber { get; set; }

        [DisplayName("Субъект Российской Федерации")]
        public string SubjectRF { get; set; }

        [DisplayName("Наименование юридического лица")]
        public string YrName { get; set; }

        [DisplayName("Сокращенное наименование")]
        public string ShortYrName { get; set; }

        [DisplayName("Адрес места нахождения юридического лица")]
        public string AdrYr { get; set; }

        [DisplayName("ФИО, должность руководителя")]
        public string FIO { get; set; }

        [DisplayName("Телефон организации")]
        public string PhoneNumber { get; set; }

        [DisplayName("Факс организации")]
        public string FaksOrg { get; set; }

        [DisplayName("Эл. почта организации")]
        public string MailOrg { get; set; }

        [DisplayName("ОКПО")]
        public int OKPO { get; set; }

        [DisplayName("ОКВЭД")]
        public int OKVED { get; set; }

        [DisplayName("ОКОГУ")]
        public int OKOGY { get; set; }

        [DisplayName("ОКТМО")]
        public int OKTMO { get; set; }

        [DisplayName("ИНН")]
        public int INN { get; set; }

        [DisplayName("КПП")]
        public int KPP { get; set; }

        [DisplayName("ОКОПФ")]
        public int OKOPF { get; set; }

        [DisplayName("ОКФС")]
        public int OKFS { get; set; }

    }
}
