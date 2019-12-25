using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace NoFussDiplom
{
	public partial class MainPage : MasterDetailPage
    {
		public MainPage()
		{
			InitializeComponent();

            Detail = new NavigationPage(new Main())
            {
                BarBackgroundColor = Color.Black
            };            

            IsPresented = false;
        }
        


    }
}
