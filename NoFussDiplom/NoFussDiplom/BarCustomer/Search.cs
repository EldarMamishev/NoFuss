using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace NoFussDiplom
{
	public class Search : InBarButtonClicked
	{
		public Search () : base()
		{
            StackLayout stackLayout = new StackLayout();
            stackLayout.Children.Add(base.stackLayout);
            Label label = new Label
            {
                Text = "Search"
            };
            stackLayout.Children.Add(label);
            Content = stackLayout;
        }

        public override void ImageSearch_Clicked(object sender, EventArgs args)
        {
            //base.ImageSearch_Clicked(sender, args);
        }
    }
}