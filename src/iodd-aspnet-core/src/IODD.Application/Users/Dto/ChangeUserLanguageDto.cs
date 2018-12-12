using System.ComponentModel.DataAnnotations;

namespace IODD.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}