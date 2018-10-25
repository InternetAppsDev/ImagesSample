using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ImageSample
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PuzzlePage : ContentPage
	{
		public PuzzlePage ()
		{
			InitializeComponent ();
            AddImagesToPage();
		}

        private void AddImagesToPage()
        {
            /*
             * Add the image - object of type image
             * Add the TapGestureRecogniser as well
             */
            Image myImage;  // variable of type image
            // instantiate a new object of type Image
            myImage = new Image();
            myImage.Aspect = Aspect.AspectFit;
            // set the source
            var assembly = typeof(MainPage);
            myImage.Source =
                ImageSource.FromResource("ImageSample.Assets.Images.panbackground.png",
                                         assembly);
            // add the tap gesture recognition
            // create the recogniser
            var tapGestureRecogniser = new TapGestureRecognizer();
            // add the tapped event to the recogniser
            tapGestureRecogniser.Tapped += TapGestureRecogniser_Tapped;
            // add the tapGesture to the image
            myImage.GestureRecognizers.Add(tapGestureRecogniser);

            // add the image to the stacklayout on the content page
            // add it to the Children collection
            stckContentLayout.Children.Add(myImage);
        }

        private void TapGestureRecogniser_Tapped(object sender, EventArgs e)
        {
            // change the image on tap
            Image current = (Image)sender;
            // set the source
            var assembly = typeof(MainPage);
            current.Source =
                ImageSource.FromResource("ImageSample.Assets.Images.hendrix.jpg",
                                         assembly);

            // remove the tap recognition
            
            //current.GestureRecognizers.Remove()
        }
    }
}