using Bombardelli.Forms.ViewModel;
using Xamarin.Forms;

namespace Bombardelli.Forms.View
{
    public abstract class View : ContentPage, IView
    {

        private IViewModel iViewModel;
        private ActivityIndicator activityIndicator;


        public IViewModel ViewModel
        {
            get { return iViewModel; }
            protected set { iViewModel = value; }
        }

        public ActivityIndicator ActivityIndicator
        {
            get { return activityIndicator; }
            set { activityIndicator = value; }
        }

        private void ViewAppearing(object sender, System.EventArgs e)
        {
            iViewModel.OnViewModelLoaded();
        }

        public View(IViewModel iViewModel)
        {
            BindingContext = ViewModel = iViewModel;
            Appearing += ViewAppearing;
        }

        public View()
        {
        }

        ~View()
        {
            Appearing -= ViewAppearing;
        }

    }
}
