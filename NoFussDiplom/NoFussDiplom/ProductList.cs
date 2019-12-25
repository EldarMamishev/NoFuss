using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using Xamarin.Forms;

namespace NoFussDiplom
{
	public class ProductList: ContentPage
	{
        public StackLayout stackLayout;
        private ProductObject productObject;
        
        private Grid productObjectsFruitsGrid;
        private Grid productObjectsVegetablesGrid;

        private StackLayout productObjectsFruitsStackLayout1;
        private StackLayout productObjectsVegetablesStackLayout1;

        private StackLayout productObjectsFruitsStackLayout2;
        private StackLayout productObjectsVegetablesStackLayout2;

        public ProductList ()
		{                     
            stackLayout = new StackLayout();

            FunctionFruit(/*params*/);
            FunctionVegetables(/*params*/);


            stackLayout.Children.Add(productObjectsFruitsGrid);
            stackLayout.Children.Add(productObjectsVegetablesGrid);
        }

        private void FunctionFruit(params string[] fileEntriesFruits)
        {
            productObjectsFruitsGrid = new Grid();
            productObjectsFruitsStackLayout1 = new StackLayout();
            productObjectsFruitsStackLayout2 = new StackLayout();            

            for (int i = 0; i < fileEntriesFruits.Length; i++)
            {
                productObject = new ProductObject(fileEntriesFruits[i], fileEntriesFruits[i]);
                if (i % 2 == 0)
                {
                    productObjectsFruitsStackLayout1.Children.Add(productObject.grid);
                }
                else
                {
                    productObjectsFruitsStackLayout2.Children.Add(productObject.grid);
                }
            }

            productObjectsFruitsGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Auto) });
            productObjectsFruitsGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
            productObjectsFruitsGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });

            productObjectsFruitsGrid.Children.Add(productObjectsFruitsStackLayout1, 0, 0);
            productObjectsFruitsGrid.Children.Add(productObjectsFruitsStackLayout2, 1, 0);
        }

        private void FunctionVegetables(params string[] fileEntriesVegetables)
        {
            productObjectsVegetablesGrid = new Grid();
            productObjectsVegetablesStackLayout1 = new StackLayout();
            productObjectsVegetablesStackLayout2 = new StackLayout();
            
            for (int i = 0; i < fileEntriesVegetables.Length; i++)
            {
                productObject = new ProductObject(fileEntriesVegetables[i], fileEntriesVegetables[i]);
                if (i % 2 == 0)
                {
                    productObjectsVegetablesStackLayout1.Children.Add(productObject.grid);
                }
                else
                {
                    productObjectsVegetablesStackLayout2.Children.Add(productObject.grid);
                }
            }
            
            productObjectsVegetablesGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Auto) });
            productObjectsVegetablesGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
            productObjectsVegetablesGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });

            productObjectsVegetablesGrid.Children.Add(productObjectsVegetablesStackLayout1, 0, 0);
            productObjectsVegetablesGrid.Children.Add(productObjectsVegetablesStackLayout2, 1, 0);
        }

    }
}