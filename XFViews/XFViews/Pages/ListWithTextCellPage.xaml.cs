using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using XFViews.Data;

namespace XFViews.Pages
{
    public partial class ListWithTextCellPage : ContentPage
    {
        public ObservableCollection<Jogador> JogadoresObservableCollection { get; set; }

        public ListWithTextCellPage()
        {
            InitializeComponent();

            JogadoresObservableCollection = new ObservableCollection<Jogador>(Escalacao.Get());
            JogadoresList.ItemsSource = JogadoresObservableCollection;
        }
    }
}