using SB.Models;
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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace SB
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class AddAd : Page
    {
        public AddAd()
        {
            this.InitializeComponent();
        }

        private void SubmitAd_Click(object sender, RoutedEventArgs e)
        {
            if(ItemManager.AddItem(new Item(1, Name.Text, Image.Text, Convert.ToDouble(Price.Text), Location.Text, Category.Text)))
            {
                ResultBox.Text = "Your Entry has been added";
            }
        }
    }
}
