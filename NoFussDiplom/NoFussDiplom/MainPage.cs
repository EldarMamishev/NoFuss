using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace NoFussDiplom
{
    public partial class MainPage
    {
        private void ButtonMain_Click(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new Main())
            {
                BarBackgroundColor = Color.Black
            };

            IsPresented = false;
        }

        private void ButtonProducts_Click(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new Products())
            {
                BarBackgroundColor = Color.Black
            };

            IsPresented = false;
        }

        private void ButtonSaleProducts_Click(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new SaleProducts())
            {
                BarBackgroundColor = Color.Black
            };

            IsPresented = false;
        }

        private void ButtonMyProfile_Click(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new MyProfile())
            {
                BarBackgroundColor = Color.Black
            };

            IsPresented = false;
        }

        private void ButtonMyOrders_Click(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new MyOrders())
            {
                BarBackgroundColor = Color.Black
            };

            IsPresented = false;
        }

        private void ButtonAboutCompany_Click(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new AboutCompany())
            {
                BarBackgroundColor = Color.Black
            };

            IsPresented = false;
        }
    }
}

