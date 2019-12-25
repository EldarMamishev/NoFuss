using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace NoFussDiplom
{
    public class MyProfile : InBarButtonClicked
    {
        public MyProfile() : base()
        {
            StackLayout stackLayout = new StackLayout();
            stackLayout.Children.Add(base.stackLayout);

            ScrollView scrollView = new ScrollView
            {
                Margin = new Thickness(Application.Current.MainPage.Width * 0.1, 0, 0, 10)
            };
            StackLayout stackLayoutChild = new StackLayout
            {
                Margin = new Thickness(0, 0, Application.Current.MainPage.Width * 0.1, 0)
            };

            Label labelTitle = new Label
            {
                HorizontalOptions = LayoutOptions.FillAndExpand,
                HorizontalTextAlignment = TextAlignment.Center,
                VerticalOptions = LayoutOptions.Center,
                VerticalTextAlignment = TextAlignment.Center,
                TextColor = Color.Black,
                Text = "MY PROFILE",
                FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(ViewCell))
            };
            Label labelPersonalData = new Label
            {
                HorizontalOptions = LayoutOptions.FillAndExpand,
                VerticalOptions = LayoutOptions.Center,
                VerticalTextAlignment = TextAlignment.Center,
                TextColor = Color.Black,
                Text = "Personal data",
                FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(ViewCell))
            };
            Label labelContacts = new Label
            {
                HorizontalOptions = LayoutOptions.FillAndExpand,
                VerticalOptions = LayoutOptions.Center,
                VerticalTextAlignment = TextAlignment.Center,
                TextColor = Color.Black,
                Text = "Contacts",
                FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(ViewCell))
            };

            Button buttonChangeData = new Button
            {
                Text = "CHANGE DATA",
                TextColor = Color.White,
                BackgroundColor = Color.Black,
                HorizontalOptions = LayoutOptions.FillAndExpand
            };

            buttonChangeData.Clicked += ButtonClickedChangeData;

            stackLayoutChild.Children.Add(new TableView
            {

                Intent = TableIntent.Form,
                Root = new TableRoot()
                {
                    new TableSection ()
                    {
                        new ViewCell()
                        {
                            View = labelTitle
                        },
                        new ViewCell()
                        {
                            View = labelPersonalData
                        },
                        new TextCell()
                        {
                            Text = "Name",
                            TextColor = Color.SlateGray,
                            Detail = "name"
                        },
                        new TextCell()
                        {
                            Text = "Surname",
                            TextColor = Color.SlateGray,
                            Detail = "surname"
                        },
                        new TextCell()
                        {
                            Text = "Age",
                            TextColor = Color.SlateGray,
                            Detail = "age"
                        },
                        new TextCell()
                        {
                            Text = "User status",
                            TextColor = Color.SlateGray,
                            Detail = "user status"
                        },
                        new TextCell()
                        {
                            Text = "Personal discount",
                            TextColor = Color.SlateGray,
                            Detail = "personal discount"
                        },
                    },
                    new TableSection ()
                    {
                        new ViewCell()
                        {
                            View = labelContacts
                        },
                        new TextCell()
                        {
                            Text = "Phone number",
                            TextColor = Color.SlateGray,
                            Detail = "phone number"
                        },
                        new TextCell()
                        {
                            Text = "Email",
                            TextColor = Color.SlateGray,
                            Detail = "email"
                        },
                        new TextCell()
                        {
                            Text = "Password",
                            TextColor = Color.SlateGray,
                            Detail = "password"
                        },
                        new TextCell()
                        {
                            Text = "Locality",
                            TextColor = Color.SlateGray,
                            Detail = "locality"
                        },
                    },
                    new TableSection ()
                    {
                        new ViewCell
                        {
                            View = buttonChangeData
                        }
                    }
                }
            });

            scrollView.Content = stackLayoutChild;
            stackLayout.Children.Add(scrollView);
            Content = stackLayout;                        
        }
        async void ButtonClickedChangeData(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new ChangePersonalData());
        }
    }
}