using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace NoFussDiplom
{
	public class BarButtonClicked : ContentPage
	{
        public StackLayout stackLayout = new StackLayout();

        public Image avatar;
        public Image star;
        public Image basket;
        public Image NFC;
        public Image search;

        public BarButtonClicked ()        
		{            
            var grid = new Grid { RowSpacing = 0, ColumnSpacing = 0, BackgroundColor = Color.LightGray };

            grid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Auto) });
            grid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
            grid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
            grid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
            grid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
            grid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });

            avatar = new Image()
            {
                Source = "avatar.png",
                VerticalOptions = LayoutOptions.Center,
                HorizontalOptions = LayoutOptions.Center,
                Aspect = Aspect.AspectFit,
                MinimumHeightRequest = 48,
                MinimumWidthRequest = 36,
                WidthRequest = 48,
                HeightRequest = 36
            };

            star = new Image
            {
                Source = "star.png",
                VerticalOptions = LayoutOptions.Center,
                HorizontalOptions = LayoutOptions.Center,
                Aspect = Aspect.AspectFit,
                MinimumHeightRequest = 48,
                MinimumWidthRequest = 36,
                WidthRequest = 48,
                HeightRequest = 36
            };

            basket = new Image
            {
                Source = "basket.png",
                VerticalOptions = LayoutOptions.Center,
                HorizontalOptions = LayoutOptions.Center,
                Aspect = Aspect.AspectFit,
                MinimumHeightRequest = 48,
                MinimumWidthRequest = 36,
                WidthRequest = 48,
                HeightRequest = 36
            };

            NFC = new Image
            {
                Source = "NFC.png",
                VerticalOptions = LayoutOptions.Center,
                HorizontalOptions = LayoutOptions.Center,
                Aspect = Aspect.AspectFit,
                MinimumHeightRequest = 48,
                MinimumWidthRequest = 36,
                WidthRequest = 48,
                HeightRequest = 36
            };

            search = new Image
            {
                Source = "search.png",
                VerticalOptions = LayoutOptions.Center,
                HorizontalOptions = LayoutOptions.Center,
                Aspect = Aspect.AspectFit,
                MinimumHeightRequest = 48,
                MinimumWidthRequest = 36,
                WidthRequest = 48,
                HeightRequest = 36
            };

            grid.Children.Add(avatar, 0, 0);
            grid.Children.Add(star, 1, 0);
            grid.Children.Add(basket, 2, 0);
            grid.Children.Add(NFC, 3, 0);
            grid.Children.Add(search, 4, 0);

            stackLayout.Children.Add(grid);
            ClickedBarButtons();
        }
        private void ClickedBarButtons()
        {
            TapGestureRecognizer tapGestureRecognizerAvatar = new TapGestureRecognizer();
            TapGestureRecognizer tapGestureRecognizerStar = new TapGestureRecognizer();
            TapGestureRecognizer tapGestureRecognizerBasket = new TapGestureRecognizer();
            TapGestureRecognizer tapGestureRecognizerNFC = new TapGestureRecognizer();
            TapGestureRecognizer tapGestureRecognizerSearch = new TapGestureRecognizer();

            tapGestureRecognizerAvatar.Tapped += ImageAvatar_Clicked;
            tapGestureRecognizerStar.Tapped += ImageStar_Clicked;
            tapGestureRecognizerBasket.Tapped += ImageBasket_Clicked;
            tapGestureRecognizerNFC.Tapped += ImageNFC_Clicked;
            tapGestureRecognizerSearch.Tapped += ImageSearch_Clicked;


            avatar.GestureRecognizers.Add(tapGestureRecognizerAvatar);
            star.GestureRecognizers.Add(tapGestureRecognizerStar);
            basket.GestureRecognizers.Add(tapGestureRecognizerBasket);
            NFC.GestureRecognizers.Add(tapGestureRecognizerNFC);
            search.GestureRecognizers.Add(tapGestureRecognizerSearch);

        }

        public virtual async void ImageAvatar_Clicked(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new Authorization());
        }

        public virtual async void ImageStar_Clicked(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new FavoriteProducts());            
        }

        public virtual async void ImageBasket_Clicked(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new Basket());
        }

        public virtual async void ImageNFC_Clicked(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new NoFussClub());
        }

        public virtual async void ImageSearch_Clicked(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new Search());
        }
        
	}
}