using Xamarin.Forms;

namespace HelloXamarinFormsWorld
{
	public class App : Xamarin.Forms.Application
    {
		public App ()
        {
            MainPage = new ContentPage
                   {
                       Content = new Label
                                 {
                                     Text = "Helle Duong Thanh Song . . . This is a Robot Xamarin",
                                     VerticalOptions = LayoutOptions.CenterAndExpand,
                                     HorizontalOptions = LayoutOptions.CenterAndExpand,
                                 },
                   };
        }
    }
}
