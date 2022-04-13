using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MyTestAspNetCore.Models
{
    public class FormsNumberM
    {
        #region Form
        [Key]
        public int Id { get; set; }

        public List<FormsM> Form { get; set; }
        #endregion

    }
}
