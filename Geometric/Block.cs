using System;
using Xamarin.Forms;
using Xamarin.Forms.Shapes;

namespace Geometric
{
    public class Block : AbsoluteLayout
    {
        public Block(Thickness margin, int width, Color topColor, Color rightColor, Color bottomColor, Color leftColor)
        {
            var shape1 = new Polygon()
            {
                Points = new PointCollection()
                {
                    new Point(0,0),
                    new Point(width,0),
                    new Point(width/2,width/2)
                },
                Fill = topColor
            };

            var shape2 = new Polygon()
            {
                Points = new PointCollection()
                {
                    new Point(width,0),
                    new Point(width,width),
                    new Point(width/2,width/2)
                },
                Fill = rightColor
            };

            var shape3 = new Polygon()
            {
                Points = new PointCollection()
                {
                    new Point(0,width),
                    new Point(width/2,width/2),
                    new Point(width,width)
                },
                Fill = bottomColor
            };

            var shape4 = new Polygon()
            {
                Points = new PointCollection()
                {
                    new Point(0,0),
                    new Point(width/2,width/2),
                    new Point(0,width)
                },
                Fill = leftColor
            };

            this.Margin = margin;
            this.Children.Add(shape1);
            this.Children.Add(shape2);
            this.Children.Add(shape3);
            this.Children.Add(shape4);
        }
    }
}