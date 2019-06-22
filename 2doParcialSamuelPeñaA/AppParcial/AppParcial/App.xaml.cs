using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using AppParcial.View;
using AppParcial.ViewModel;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace AppParcial
{
    public partial class App : Application
    {
        public App(string filename)
        {
            InitializeComponent();
            NotesViewModel.Inicializador(filename);
            MainPage = new NotesView();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
