using System.ComponentModel.DataAnnotations;

namespace LPSDocument.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}