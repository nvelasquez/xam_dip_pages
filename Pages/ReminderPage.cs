using System;

using Xamarin.Forms;

namespace Pages
{
    public class ReminderPage : ContentPage
    {
        public ReminderPage()
        {
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Hello ContentPage" }
                }
            };
        }
    }
}

