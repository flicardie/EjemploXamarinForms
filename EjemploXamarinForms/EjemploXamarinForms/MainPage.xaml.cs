﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using Xamarin.Forms;

namespace EjemploXamarinForms
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            List<HomePageViewModel> models = new List<HomePageViewModel>
            {
              
                new HomePageViewModel(typeof(EjemploAlertas), NavigateTo, BrowseSource),
                new HomePageViewModel(typeof(EjemploSQLite), NavigateTo, BrowseSource)
              
               



            };

            listView.ItemsSource = models;
        }

        async void NavigateTo(Type pageType)
        {
            // Get all the constructors of the page type.
            IEnumerable<ConstructorInfo> constructors =
                    pageType.GetTypeInfo().DeclaredConstructors;

            foreach (ConstructorInfo constructor in constructors)
            {
                // Check if the constructor has no parameters.
                if (constructor.GetParameters().Length == 0)
                {
                    // If so, instantiate it, and navigate to it.
                    Page page = (Page)constructor.Invoke(null);
                    await this.Navigation.PushAsync(page);
                    break;
                }
            }
        }

        async void BrowseSource(string pageName)
        {
            string espacioDeNombres = "EjemploXamarinForms.";
            string xamlPage = espacioDeNombres + pageName + ".xaml";
            Assembly assembly = this.GetType().GetTypeInfo().Assembly;

            using (Stream stream = assembly.GetManifestResourceStream(xamlPage))
            {
                using (StreamReader reader = new StreamReader(stream))
                {
                    string xaml = reader.ReadToEnd();
                    await this.Navigation.PushAsync(new VisualizadorXaml(xaml));
                }
            }
        }

        // Also go to the page when the ListView item is selected.
        void OnListViewItemSelected(object sender, SelectedItemChangedEventArgs args)
        {
            HomePageViewModel viewModel = args.SelectedItem as HomePageViewModel;

            if (viewModel != null)
            {
                viewModel.GoToCommand.Execute(viewModel.PageType);
            }
        }
    }
}
