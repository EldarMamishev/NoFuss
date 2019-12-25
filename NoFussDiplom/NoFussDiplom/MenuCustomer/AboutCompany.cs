using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace NoFussDiplom
{
	public class AboutCompany : BarButtonClicked
	{
		public AboutCompany () : base()
		{
            StackLayout stackLayout = new StackLayout();
            stackLayout.Children.Add(base.stackLayout);
            Label label = new Label
            {
                Text = "About Company"
            };
            stackLayout.Children.Add(label);
            Content = stackLayout;
        }
	}
}