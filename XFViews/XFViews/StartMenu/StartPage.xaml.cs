using System;
using Xamarin.Forms;

namespace XFViews.StartMenu
{
    public partial class StartPage : MasterDetailPage
    {
        public StartPage()
        {
            InitializeComponent();

            MasterPage.ListView.ItemSelected += OnItemSelected;
        }

        void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as StartMenuItem;
            if (item != null)
            {
                Detail = (Page)Activator.CreateInstance(item.TargetType);

                MasterPage.ListView.SelectedItem = null;
                IsPresented = false;
            }
        }
    }
}