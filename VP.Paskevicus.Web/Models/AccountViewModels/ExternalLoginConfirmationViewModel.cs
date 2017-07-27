using System.ComponentModel.DataAnnotations;

namespace VP.Paskevicus.Web.Models.AccountViewModels
{
    public class ExternalLoginConfirmationViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
