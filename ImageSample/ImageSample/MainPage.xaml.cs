using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ImageSample
{
    public partial class MainPage : ContentPage
    {
        public MainPage()   // constructor
        {
            InitializeComponent();
            SetupImagesOnPage();
        }

        private void SetupImagesOnPage()
        {
            // get the assembly
            var assembly = typeof(MainPage);
            /*
             * need a directory path - ImageSample/Assets/Images/oogway.jpg
             * two parameters are that directory path in that assembly
             */

            string strFilename = "ImageSample.Assets.Images.oogway.jpg";

            imageMain.Source =
                ImageSource.FromResource(strFilename, assembly);

        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            // go to PageTwo.xaml
            // create new instance of PageTwo and put it on the stack
            Navigation.PushAsync(new PuzzlePage());
        }
    }
}
