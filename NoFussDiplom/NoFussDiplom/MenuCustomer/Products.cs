using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace NoFussDiplom
{
	public class Products : BarButtonClicked
	{
		public Products () : base()
		{
            StackLayout stackLayout = new StackLayout();
            stackLayout.Children.Add(base.stackLayout);
            Label label = new Label
            {
                Text = "Products"
            };
            stackLayout.Children.Add(label);
            Content = stackLayout;
        }
	}
}