using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace Geometric
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            // Configuration
            var blockSize = 50;
            var colors = new List<Color>()
            {
                Color.FromHex("#E8E9B7"),
                Color.FromHex("#B0BAA4"),
                Color.FromHex("#7A8992"),
                Color.FromHex("#6D657E")
            };

            InitializeComponent();

            // Get Display dimensions using Xamarin.Essentials
            var mainDisplayInfo = DeviceDisplay.MainDisplayInfo;
            var screenWidth = mainDisplayInfo.Width;
            var screenHeight = mainDisplayInfo.Height;

            // Build the UI
            var xPos = 0;
            var yPos = 0;

            while (yPos < screenHeight)
            {
                var rowColors = colors.GetRange(0, colors.Count);
                while (xPos < screenWidth)
                {
                    rowColors = Reorder(rowColors);

                    backgroundLayout.Children.Add(new Block(new Thickness(xPos, yPos), blockSize,
                        rowColors[0], rowColors[1], rowColors[2], rowColors[3]));
                    xPos += blockSize;
                }
                colors = Reorder(colors);

                xPos = 0;
                yPos += blockSize;
            }
        }

        // Reorder list by moving the first item to the back
        public List<Color> Reorder(List<Color> list)
        {
            var first = list.First();
            list.RemoveAt(0);
            list.Add(first);
            return list;
        }
    }
}
