﻿using System;

using Buildar.App.ViewModels;

using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Input;

namespace Buildar.App.Views
{
    public sealed partial class MainPage : Page
    {
        public MainViewModel ViewModel { get; } = new MainViewModel();

        public MainPage()
        {
            InitializeComponent();
        }

        private void GridViewContent_ItemClick(object sender, ItemClickEventArgs e)
        {
            switch (e.ClickedItem.ToString())
            {

                case "Start a new build":
                    this.Frame.Navigate(typeof(CustomBuildPage));
                    break;

                case "High End":
                    this.Frame.Navigate(typeof(HighEndPage));
                    break;

                case "Mid Range":
                    this.Frame.Navigate(typeof(MidRangePage));
                    break;

                case "Budget Build":
                    this.Frame.Navigate(typeof(BudgetPage));
                    break;

                case "Community build":
                    this.Frame.Navigate(typeof(MainPage));
                    break;
            }

        }
    }
}
