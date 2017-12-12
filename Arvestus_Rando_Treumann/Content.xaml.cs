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

namespace Arvestus_Rando_Treumann
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Content : Page
    {
        public Content()
        {
            this.InitializeComponent();
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            if (rootPivot.SelectedIndex > 0)
            {
                rootPivot.SelectedIndex -= 1;
            }
            else
            {
                rootPivot.SelectedIndex = rootPivot.Items.Count - 1;
            }
        }

        private void NextButton_Click(object sender, RoutedEventArgs e)
        {
            if (rootPivot.SelectedIndex < rootPivot.Items.Count - 1)
            {
                rootPivot.SelectedIndex += 1;
            }
            else
            {
                rootPivot.SelectedIndex = 0;
            }
        }
    }
}
