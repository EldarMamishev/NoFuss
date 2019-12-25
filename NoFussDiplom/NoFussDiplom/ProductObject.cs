using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace NoFussDiplom
{
    class ProductObject: ContentPage
    {
        private Image image;
        private Label imageName;
        private Label cost;
        private Label saleCost;
        private Label count;
        private Picker quality;

        public Grid grid;

        private Button buttonToFavoriteProducts = new Button
        {
            Text = "Add to Favorites",
            HorizontalOptions = LayoutOptions.Center,
            VerticalOptions = LayoutOptions.Center
        };
        private Button buttonToBasket = new Button
        {
            Text = "Add to Basket",
            HorizontalOptions = LayoutOptions.Center,
            VerticalOptions = LayoutOptions.Center
        };

        public ProductObject(string image, string imageName)
        {
            this.image = new Image
            {
                Source = image,
                VerticalOptions = LayoutOptions.Center,
                HorizontalOptions = LayoutOptions.Center,
                Aspect = Aspect.AspectFit,
                MinimumHeightRequest = 90,
                MinimumWidthRequest = 120,
                WidthRequest = 90,
                HeightRequest = 120
            };

            this.imageName = new Label
            {
                Text = imageName,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center
            };

            grid = new Grid
            {
                RowSpacing = 0,
                ColumnSpacing = 0
            };

            grid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Auto) });
            grid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Auto) });

            grid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });

            grid.Children.Add(this.image, 0, 0);
            grid.Children.Add(this.imageName, 0, 1);

            
        }

        public ProductObject(string image, string imageName, int cost, int saleCost, int count, params string[] quality)
        {
            this.image = new Image
            {
                Source = image,
                VerticalOptions = LayoutOptions.Center,
                HorizontalOptions = LayoutOptions.Center,
                Aspect = Aspect.AspectFit,
                MinimumHeightRequest = 90,
                MinimumWidthRequest = 120,
                WidthRequest = 90,
                HeightRequest = 120
            };

            this.imageName = new Label
            {
                Text = imageName,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center
            };
            this.cost = new Label
            {
                Text = cost.ToString(),
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center
            };
            this.saleCost = new Label
            {
                Text = saleCost.ToString(),
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center
            };
            this.count = new Label
            {
                Text = count.ToString(),
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center
            };
            this.quality = new Picker
            {
                Title = "Quality",
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center                
            };
            for (int i = 0; i < quality.Length; i++)
            {
                this.quality.Items.Add(quality[i]);
            }

            grid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Auto) });
            grid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Auto) });
            grid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Auto) });
            grid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Auto) });
            grid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Auto) });
            grid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Auto) });
            grid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Auto) });
            grid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Auto) });

            grid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });

            grid.Children.Add(this.image, 0, 0);
            grid.Children.Add(this.imageName, 0, 1);
            grid.Children.Add(this.cost, 0, 2);
            grid.Children.Add(this.saleCost, 0, 3);
            grid.Children.Add(this.count, 0, 4);
            grid.Children.Add(this.quality, 0, 5);
            grid.Children.Add(this.buttonToFavoriteProducts, 0, 6);
            grid.Children.Add(this.buttonToBasket, 0, 7);

        }


    }
}
