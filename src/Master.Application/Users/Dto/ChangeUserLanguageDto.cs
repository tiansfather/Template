using System.ComponentModel.DataAnnotations;

namespace Master.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}