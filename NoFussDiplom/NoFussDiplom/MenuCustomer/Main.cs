using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.IO;

namespace NoFussDiplom
{
	public class Main : BarButtonClicked
	{
        public Main() : base()
        {
            StackLayout stackLayout = new StackLayout();
            StackLayout stackLayoutProducts = new StackLayout();
            stackLayout.Children.Add(base.stackLayout);

            ProductList productList = new ProductList();

            ScrollView scrollView = new ScrollView();
                        
            scrollView.Content = productList.stackLayout;
            stackLayout.Children.Add(scrollView);
    
            Content = stackLayout;
        }
	}
}
