using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;


namespace NoFussDiplom
{
	public class Authorization : InBarButtonClicked
	{
        public Authorization () : base()
		{
            StackLayout stackLayout = new StackLayout();            
            StackLayout stackLayoutChild = new StackLayout
            {
                Margin = new Thickness(0, 0, Application.Current.MainPage.Width * 0.1, 0)
            };

            ScrollView scrollView = new ScrollView
            {
                Margin = new Thickness(Application.Current.MainPage.Width * 0.1, 0, 0, 10)
            };

            stackLayout.Children.Add(base.stackLayout);
            
            
            Label labelTitle = new Label
            {
                Text = "I ALREADY HAVE AN ACCOUNT",
                HorizontalOptions = LayoutOptions.Center,
                Margin = new Thickness(0, 15),
                FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label))
            };

            Label labelPhoneNuber = new Label
            {
                Text = "Phone number:"
            };
            Entry entryPhoneNumber = new Entry()
            {
                Keyboard = Keyboard.Telephone,
                Placeholder = "(0xx)-xxx-xx-xx"
            };

            Label labelPassword = new Label
            {
                Text = "Password:"                
            };
            Entry entryPassword = new Entry()
            {
                IsPassword = true,
                Keyboard = Keyboard.Default
            };

            Button buttonSignIn = new Button()
            {
                Text = "Sign in",
                HorizontalOptions = LayoutOptions.FillAndExpand,
                TextColor = Color.White,
                BackgroundColor = Color.Black

            };
            Button buttonForgotPassword = new Button()
            {
                Text = "FORGOT PASSWORD?",
                BackgroundColor = Color.Transparent,
                HorizontalOptions = LayoutOptions.FillAndExpand,
                TextColor = Color.Blue
            };

            Label labelRagistration = new Label
            {
                Text = "REGISTRATION",
                HorizontalOptions = LayoutOptions.Center,
                Margin = new Thickness(0, 30, 0, 15),
                FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label))
            };
            Label labelInfo = new Label
            {
                Text = "For making Orders you should have an account",
                HorizontalOptions = LayoutOptions.Center
            };
            Button buttonCreateAccount = new Button()
            {
                Text = "CREATE AN ACCOUNT",
                TextColor = Color.White,
                BackgroundColor = Color.Black,
                HorizontalOptions = LayoutOptions.FillAndExpand
            };

            buttonCreateAccount.Clicked += ButtonCreateAccount;

            stackLayoutChild.Children.Add(labelTitle);
            stackLayoutChild.Children.Add(labelPhoneNuber);
            stackLayoutChild.Children.Add(entryPhoneNumber);
            stackLayoutChild.Children.Add(labelPassword);
            stackLayoutChild.Children.Add(entryPassword);
            stackLayoutChild.Children.Add(buttonSignIn);
            stackLayoutChild.Children.Add(buttonForgotPassword);

            stackLayoutChild.Children.Add(labelRagistration);
            stackLayoutChild.Children.Add(labelInfo);
            stackLayoutChild.Children.Add(buttonCreateAccount);

            scrollView.Content = stackLayoutChild;
            stackLayout.Children.Add(scrollView);
            Content = stackLayout;
        }

        async void ButtonCreateAccount(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new Registration());
        }

        public override void ImageAvatar_Clicked(object sender, EventArgs args)
        {
            //base.ImageAvatar_Clicked(sender, args);
        }     
        
    }
}