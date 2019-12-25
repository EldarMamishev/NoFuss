using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace NoFussDiplom
{
    public class InBarButtonClicked : BarButtonClicked
    {    
        public override async void ImageAvatar_Clicked(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new Authorization());
            this.Navigation.RemovePage(this.Navigation.NavigationStack[this.Navigation.NavigationStack.Count - 2]);            
        }

        public override async void ImageStar_Clicked(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new FavoriteProducts());
            this.Navigation.RemovePage(this.Navigation.NavigationStack[this.Navigation.NavigationStack.Count - 2]);
        }

        public override async void ImageBasket_Clicked(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new Basket());
            this.Navigation.RemovePage(this.Navigation.NavigationStack[this.Navigation.NavigationStack.Count - 2]);
        }

        public override async void ImageNFC_Clicked(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new NoFussClub());
            this.Navigation.RemovePage(this.Navigation.NavigationStack[this.Navigation.NavigationStack.Count - 2]);
        }

        public override async void ImageSearch_Clicked(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new Search());
            this.Navigation.RemovePage(this.Navigation.NavigationStack[this.Navigation.NavigationStack.Count - 2]);
        }

    }
}
