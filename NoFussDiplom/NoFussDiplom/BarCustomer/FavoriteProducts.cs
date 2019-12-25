using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace NoFussDiplom
{
	public class FavoriteProducts : InBarButtonClicked
	{
		public FavoriteProducts () : base()
		{
            StackLayout stackLayout = new StackLayout();
            stackLayout.Children.Add(base.stackLayout);
            Label label = new Label
            {
                Text = "Favorite Products"
            };
            stackLayout.Children.Add(label);
            Content = stackLayout;
        }

        public override void ImageStar_Clicked(object sender, EventArgs args)
        {
            //base.ImageStar_Clicked(sender, args);
        }
    }
}