using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace NoFussDiplom
{
	public class NoFussClub : InBarButtonClicked
	{
		public NoFussClub () : base()
		{
            StackLayout stackLayout = new StackLayout();
            stackLayout.Children.Add(base.stackLayout);
            Label label = new Label
            {
                Text = "No Fuss Club"
            };
            stackLayout.Children.Add(label);
            Content = stackLayout;
        }

        public override void ImageNFC_Clicked(object sender, EventArgs args)
        {
            //base.ImageNFC_Clicked(sender, args);
        }
    }
}