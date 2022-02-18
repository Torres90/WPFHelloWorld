using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace WPFHelloWorld
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>

    //MainWindow.xaml.cs is a partial class because it is combined with the XAML file
    public partial class MainWindow : Window
    {
        int timesClicked = 0;
        public MainWindow()
        {
            //methods runs xaml code
            InitializeComponent();
            //myButton.FontSize = 30;
            //myButton.Content = "Press lots to find out how much I love you";

            //TextBlock textBlock = new();
            //textBlock.Text = "Hello World";
            //this.Content = textBlock;

        }



        private void Hyperlink_RequestNavigate(object sender, RequestNavigateEventArgs e)
        {
            OpenURL("https://www.google.com/");
        }

        private static void OpenURL(string url) { Process.Start(new ProcessStartInfo { FileName = url, UseShellExecute = true }); }

        //private void MyButton_Click(object sender, RoutedEventArgs e)
        //{
        //    //myButton.FontSize += 10;
        //    timesClicked++;

        //    StringBuilder sb = new StringBuilder("I love you th");
        //    for (int i = 0; i < timesClicked; i++)
        //    {
        //        sb.Append("i");
        //    }
        //    sb.Append("s much!");

        //    myButton.Content = sb.ToString();
        //}
    }
}
