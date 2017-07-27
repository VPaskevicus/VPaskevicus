using System.Threading.Tasks;

namespace VP.Paskevicus.Web.Services
{
    public interface ISmsSender
    {
        Task SendSmsAsync(string number, string message);
    }
}
