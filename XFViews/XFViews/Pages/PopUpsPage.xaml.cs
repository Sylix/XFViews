using System;
using Xamarin.Forms;

namespace XFViews.Pages
{
    public partial class PopUpsPage : ContentPage
    {
        public PopUpsPage()
        {
            InitializeComponent();
        }

        private void AlertOK_OnClicked(object sender, EventArgs e)
        {
            DisplayAlert("Alert", "Você foi avisado!", "OK");
        }

        private async void AlertTwoOptions_OnClicked(object sender, EventArgs e)
        {
            var answer = await DisplayAlert("Duas opções?", "Você tem duas opções", "Opção 1", "Opção 2");
            var opçãoescolhida = answer ? "Vocês escoleheu a opção 1" : "Vocês escoleheu a opção 2";

            await DisplayAlert("Sério!", opçãoescolhida, "OK");
        }

        private async void ActionSheetCancel_OnClicked(object sender, EventArgs e)
        {
            var action = await DisplayActionSheet("Qual é a melhor plataforma?", "Cancelar", null, "Android", "iOS", "Windows");

            if (action == "Cancelar")
                return;

            await DisplayAlert(action, "É uma boa plataforma", "Comprar", "Cancelar");
        }

        private async void ActionSheetDestruction_OnClicked(object sender, EventArgs e)
        {
            await DisplayActionSheet("Quem você apóia?", "Cancel", "Destruir Brasília", "Aécio Neves", "Dilma Rousseff");
        }
    }
}