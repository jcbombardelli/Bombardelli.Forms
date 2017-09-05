using System.Threading.Tasks;

namespace Bombardelli.Forms.Services
{
    public interface IMessageService
    {
        Task ShowAsync(string title, string message);
        Task<bool> ShowYesNoAsync(string title, string message);
    }
}
