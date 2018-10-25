﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Xamarin.Prism.Forms3371.FlexLayoutDemo
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ExperimentPage : ContentPage
	{
        static Color[] _colors = { Color.Red, Color.Magenta, Color.Blue,
                                  Color.Cyan, Color.Green, Color.Yellow };

        static string[] _digitsText = { "", "One", "Two", "Three", "Four", "Five",
                                       "Six", "Seven", "Eight", "Nine", "Ten",
                                       "Eleven", "Twelve", "Thirteen", "Fourteen",
                                       "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen" };

        static string[] _decadeText = { "", "", "Twenty", "Thirty", "Forty", "Fifty",
                                       "Sixty", "Seventy", "Eighty", "Ninety" };

        public ExperimentPage()
        {
            InitializeComponent();

            OnNumberStepperValueChanged(flexLayout, new ValueChangedEventArgs(0, numberStepper.Value));
        }

        void OnNumberStepperValueChanged(object sender, ValueChangedEventArgs args)
        {
            int count = (int)args.NewValue;

            while(flexLayout.Children.Count > count)
            {
                flexLayout.Children.RemoveAt(flexLayout.Children.Count - 1);
            }
            while(flexLayout.Children.Count < count)
            {
                int number = flexLayout.Children.Count + 1;
                string text = "";

                if(number < 20)
                {
                    text = _digitsText[number];
                }
                else
                {
                    text = _decadeText[number / 10] +
                           (number % 10 == 0 ? "" : "-") +
                                _digitsText[number % 10];
                }

                Label label = new Label
                {
                    Text = text,
                    FontSize = 16 + 4 * ((number - 1) % 4),
                    TextColor = _colors[(number - 1) % _colors.Length],
                    BackgroundColor = Color.LightGray
                };

                flexLayout.Children.Add(label);
            }
        }
    }
}