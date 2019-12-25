using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace NoFussDiplom
{
	public class ChangePersonalData : ContentPage
	{
        public ChangePersonalData()
        {
            ScrollView scrollView = new ScrollView
            {
                Margin = new Thickness(Application.Current.MainPage.Width * 0.1, 0, 0, 0),
            };
            StackLayout stackLayout = new StackLayout
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
                Text = "CHANGE DATA",
                FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(ViewCell))
            };
            Label labelInfo = new Label
            {
                VerticalOptions = LayoutOptions.Center,
                VerticalTextAlignment = TextAlignment.Center,
                TextColor = Color.IndianRed,
                Text = "* All cells must be filled!",
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

            Entry entryName = new Entry
            {
                Text = "Name",
                Keyboard = Keyboard.Text
            };
            Entry entrySurname = new Entry
            {
                Text = "Surname",
                Keyboard = Keyboard.Text
            };
            Entry entryAge = new Entry
            {
                Text = "Age",
                Keyboard = Keyboard.Numeric
            };
            Entry entryPhone = new Entry
            {
                Text = "(0xx)-xxx-xx-xx",
                Keyboard = Keyboard.Telephone
            };
            Entry entryEmail = new Entry
            {
                Text = "Email",
                Keyboard = Keyboard.Email
            };
            Entry entryPassword1 = new Entry
            {
                Text = "Password",
                Keyboard = Keyboard.Default
            };
            Entry entryPassword2 = new Entry
            {
                Text = "Password",
                Keyboard = Keyboard.Default
            };
            Entry entryLocality = new Entry
            {
                Text = "Locality",
                Keyboard = Keyboard.Default
            };

            Button buttonSaveChange = new Button
            {
                Text = "SAVE CHANGED DATA",
                TextColor = Color.White,
                BackgroundColor = Color.Black,
                HorizontalOptions = LayoutOptions.FillAndExpand
            };

            buttonSaveChange.Clicked += ButtonSaveChange;

            stackLayout.Children.Add(new TableView
            {
                Intent = TableIntent.Form,
                Root = new TableRoot("")
                {
                    new TableSection ()
                    {
                        new ViewCell
                        {
                            View = labelTitle
                        },
                        new ViewCell
                        {
                            View = labelInfo
                        },
                        new ViewCell
                        {
                            View = labelPersonalData
                        },
                        new ViewCell
                        {
                            View = entryName
                        },
                        new ViewCell
                        {
                            View = entrySurname
                        },
                        new ViewCell
                        {
                            View = entryAge
                        }
                        
                    },

                    new TableSection ()
                    {
                        new ViewCell
                        {
                            View = labelContacts
                        },
                        new ViewCell
                        {
                            View = entryPhone
                        },
                        new ViewCell
                        {
                            View = entryEmail
                        },
                        new ViewCell
                        {
                            View = entryPassword1
                        },
                        new ViewCell
                        {
                            View = entryPassword2
                        },
                        new ViewCell
                        {
                            View = entryLocality
                        },
                    },
                    new TableSection ()
                    {
                        new ViewCell
                        {
                            View = buttonSaveChange
                        }
                    }

                }
            });

            scrollView.Content = stackLayout;
            Content = scrollView;

            async void ButtonSaveChange(object sender, EventArgs args)
            {
                
                if (entryName.Text != null && entrySurname.Text != null && entryPhone.Text != null && entryEmail.Text != null && entryPassword1.Text != null && entryPassword2.Text != null && entryLocality.Text != null)
                {
                    /*
                     * Write SaveData code!
                    */
                    await Navigation.PopAsync();
                }
                else
                {
                    await DisplayAlert("", "All cells must be filled!", "ОK");
                }
                
            }
        }
    }
}