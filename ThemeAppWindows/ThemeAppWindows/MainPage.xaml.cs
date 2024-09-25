using System.Reflection;

namespace ThemeAppWindows
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnButtonClicked(object sender, EventArgs e)
        {
            if(Application.Current is not null)
            {
                if (Application.Current.RequestedTheme == AppTheme.Dark)
                {
                    Application.Current.UserAppTheme = AppTheme.Light;
                }
                else
                {
                    Application.Current.UserAppTheme = AppTheme.Dark;
                }
            }
           
        }


    }

}
