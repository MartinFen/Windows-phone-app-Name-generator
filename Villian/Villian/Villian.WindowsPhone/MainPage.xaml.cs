using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Villian
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        VillianMe VillianObj1 = new VillianMe();
        TextBox VillainObj2 = new TextBox();


        public MainPage()
        {
            this.InitializeComponent();

            this.NavigationCacheMode = NavigationCacheMode.Required;
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.
        /// This parameter is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            // TODO: Prepare page for display here.

            // TODO: If your application contains multiple pages, ensure that you are
            // handling the hardware Back button by registering for the
            // Windows.Phone.UI.Input.HardwareButtons.BackPressed event.
            // If you are using the NavigationHelper provided by some templates,
            // this event is handled for you.
        }

        private void selectAllText_GotFocus(object sender, RoutedEventArgs e)
        {

            TextBox temp = (TextBox)sender;
            temp.SelectAll();
            // firstValue.SelectAll();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            if (First.Text == "" || Second.Text == "" || Third.Text == "")
            {
                Villian.Text = "Fill out all the text boxes";

            }
            else
            {
                string a = First.Text.ToLower();
                char Temp1 = a[0];

                string b = Second.Text.ToLower();
                char Temp2 = b[0];

                string c = Third.Text.ToLower();
                char Temp3 = c[0];

                String temp1 = VillianObj1.getFirstValue(Temp1);
                String temp2 = VillianObj1.getSecondValue(Temp2);
                String temp3 = VillianObj1.getThirdValue(Temp3);

                Villian.Text = temp1 + " " + temp2 + " " + temp3;
            }


        } 
    }
}
