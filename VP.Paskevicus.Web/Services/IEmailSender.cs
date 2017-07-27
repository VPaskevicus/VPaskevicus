using System.Threading.Tasks;

namespace VP.Paskevicus.Web.Services
{
    public interface IEmailSender
    {
        Task SendEmailAsync(string email, string subject, string message);
    }
}
