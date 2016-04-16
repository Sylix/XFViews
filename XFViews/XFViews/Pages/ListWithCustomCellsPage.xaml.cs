using System.Collections.ObjectModel;
using Xamarin.Forms;
using XFViews.Data;

namespace XFViews.Pages
{
    public partial class ListWithCustomCellsPage : ContentPage
    {
        public ObservableCollection<Jogador> JogadoresObservableCollection { get; set; }
        public ListWithCustomCellsPage()
        {
            InitializeComponent();

            JogadoresObservableCollection = new ObservableCollection<Jogador>(Escalacao.Get());
            JogadoresList.ItemsSource = JogadoresObservableCollection;
        }
    }
}