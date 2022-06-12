using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace fluidXtoresApi.Models
{
    public class User
    {
        //[DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        [Key]
        public long UserId { get; set; }
        public string UserName { get; set; }
        public string UserEmail { get; set; }
        public string UserPassword { get; set; }
        public DateTime UserRegisterDate { get; set; }
        public DateTime? LastLoginDate { get; set; }

    }
}
