﻿using Rg.Plugins.Popup.Extensions;
using Rg.Plugins.Popup.Pages;
using System;
using Xamarin.Forms.Xaml;

namespace XF_Demos
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CodeviewPage : PopupPage
    {
        public CodeviewPage(string title, string keyDecriptionPoint, string importantCodeSnippets)
        {
            InitializeComponent();
            MainTitle.Text = title;
            keyPoints.Text = keyDecriptionPoint;
            codesnippets.Text=importantCodeSnippets;
        }

        private void closeButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PopPopupAsync(true);
        }
    }
}