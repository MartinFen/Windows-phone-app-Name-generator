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
        }

        private void selectAllText_GotFocus(object sender, RoutedEventArgs e)
        {

            TextBox temp = (TextBox)sender;
            temp.SelectAll();
          

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
