using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace NoFussDiplom
{
	public class Basket : InBarButtonClicked
	{
		public Basket () : base()
		{
            StackLayout stackLayout = new StackLayout();
            stackLayout.Children.Add(base.stackLayout);
            Label label = new Label
            {
                Text = "Basket"
            };
            stackLayout.Children.Add(label);
            Content = stackLayout;
        }

        public override void ImageBasket_Clicked(object sender, EventArgs args)
        {
            //base.ImageBasket_Clicked(sender, args);
        }
    }
}