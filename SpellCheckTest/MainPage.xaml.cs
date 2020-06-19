using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Text;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace SpellCheckTest
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void HandleSpellCheckingButton_Checked(object sender, RoutedEventArgs e)
        {
            bool isChecked = ((ToggleButton)sender).IsChecked.GetValueOrDefault();
            Editor.IsSpellCheckEnabled = isChecked;
            var temp = "";
            Editor.Document.GetText(TextGetOptions.FormatRtf, out temp);
            Editor.Document.SetText(TextSetOptions.FormatRtf,string.Empty);
            Editor.Document.SetText(TextSetOptions.FormatRtf, temp);
        }

     

        private void SpellCheckingButton_Click(object sender, RoutedEventArgs e)
        {
            bool isChecked = ((ToggleButton)sender).IsChecked.GetValueOrDefault();
            Editor.IsSpellCheckEnabled = isChecked;
            var temp = string.Empty;
            Editor.Document.GetText(TextGetOptions.FormatRtf, out temp);
            Editor.Document.SetText(TextSetOptions.FormatRtf, string.Empty);
            Editor.Document.SetText(TextSetOptions.FormatRtf, temp);
        }
    }
}
