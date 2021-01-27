using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AnimationsDemo
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        async void Translate_Clicked(object sender, System.EventArgs e)
        {
            await translateButton.TranslateTo(100, 0, 1000, Easing.SinOut);
            await translateButton.TranslateTo(-100, 0, 500);
            await translateButton.TranslateTo(0, 0);
        }
        async void Fade_Clicked(object sender, System.EventArgs e)
        {
            await fadeButton.FadeTo(0, 500);
            await fadeButton.FadeTo(1, 500);
        }
        async void Rotate_Clicked(object sender, System.EventArgs e)
        {
            await rotateButton.RotateTo(180, 500, Easing.BounceOut);
            await rotateButton.RotateTo(0, 500, Easing.BounceOut);
        }
        async void Mixed_Clicked(object sender, System.EventArgs e)
        {
            await Task.WhenAny<bool>(
                mixedButton.TranslateTo(0, 300, 1000, Easing.SinOut),
                mixedButton.RelRotateTo(720, 1000)
            );
            await mixedButton.FadeTo(0, 500);
            await mixedButton.TranslateTo(0, 0);
            //await mixedButton.RotateTo(0);
            await mixedButton.FadeTo(1, 500, Easing.SpringIn);
        }
    }
}
