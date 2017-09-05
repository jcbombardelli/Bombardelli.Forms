using Bombardelli.Forms.View;
using Xamarin.Forms;

namespace Bombardelli.Forms.Services
{
    public interface INavigationService
    {
        void MainPage(IView iView);
        void MainPage(Page contentPage);
        void MainNavigationPage(IView iView);
        void PushAsync(IView iView);
        void PopAsync(IView iView);

    }
}
