using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FontSizeApp
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PhotoGallery : ContentPage
	{
        private int CurrentImage;
		public PhotoGallery ()
		{
			InitializeComponent ();
            CurrentImage = 1; 
            
		}

        public UriImageSource Image_Source { get; private set; }

        private void PreviousPhoto(object sender, EventArgs e)
        {
            CurrentImage--;
            if (CurrentImage == 0)
            {
                CurrentImage = 10;
            }
            LoadImage();
        }

        private void NextPhoto(object sender, EventArgs e)
        {

            CurrentImage--;
            if (CurrentImage == 0)
            {
                CurrentImage = 10;
            }
            LoadImage();
        }
        void LoadImage()
        {
            try
            {
                Image_Source = new UriImageSource
                {

                    Uri = new Uri(String.Format("http://lorempixel.com/1920/1080/city/{0}", CurrentImage)),
                    CachingEnabled = false
                };
                image.Source = Image_Source;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                
            }
            
        }
    }
}