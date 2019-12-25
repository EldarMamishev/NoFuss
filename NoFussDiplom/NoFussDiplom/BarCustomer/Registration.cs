using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace NoFussDiplom
{
	public class Registration : ContentPage
	{
        public Registration()
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
                Text = "REGISTRATION",
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
                Placeholder = "Name",
                Keyboard = Keyboard.Text
            };
            Entry entrySurname = new Entry
            {
                Placeholder = "Surname",
                Keyboard = Keyboard.Text
            };
            Entry entryAge = new Entry
            {
                Text = "Age",
                Keyboard = Keyboard.Numeric
            };
            Entry entryPhone = new Entry
            {
                Placeholder = "(0xx)-xxx-xx-xx",
                Keyboard = Keyboard.Telephone
            };
            Entry entryEmail = new Entry
            {
                Placeholder = "Email",
                Keyboard = Keyboard.Email
            };
            Entry entryPassword = new Entry
            {
                Placeholder = "Password",
                Keyboard = Keyboard.Default
            };
            Entry entryLocality = new Entry
            {
                Placeholder = "Locality",
                Keyboard = Keyboard.Default
            };

            Picker picker = new Picker
            {
                Title = "User status",
                Items = { "Customer", "Picker", "Carrier", "Merchandiser", "Director" }
            };

            Button buttonRegister = new Button
            {
                Text = "REGISTER",
                TextColor = Color.White,
                BackgroundColor = Color.Black,
                HorizontalOptions = LayoutOptions.FillAndExpand
            };

            buttonRegister.Clicked += ButtonRegister;

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
                        },
                        new ViewCell
                        {
                            View = picker
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
                            View = entryPassword
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
                            View = buttonRegister
                        }
                    }

                }
            });

            scrollView.Content = stackLayout;
            Content = scrollView;


            async void ButtonRegister(object sender, EventArgs args)
            {                
                if (picker.SelectedItem != null && entryName.Text != null && entrySurname.Text != null && entryPhone.Text != null && entryEmail.Text != null && entryPassword.Text != null && entryLocality.Text != null)
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



