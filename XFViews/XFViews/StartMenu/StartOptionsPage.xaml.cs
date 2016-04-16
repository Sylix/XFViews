using System.Collections.Generic;
using Xamarin.Forms;
using XFViews.Pages;

namespace XFViews.StartMenu
{
    public partial class StartOptionsPage : ContentPage
    { 
        public ListView ListView { get { return listView; } }

        public StartOptionsPage()
        {
            //var grouped = new List<StartMenuGroup>();
            //var contentPagesGroup = new StartMenuGroup { Title = "Content Pages" };
            //var tabbedPagesGroup = new StartMenuGroup { Title = "Tabbed Page" };

            //// Content Pages
            //contentPagesGroup.Add(new StartMenuItem
            //{
            //    Title = "ActivityIndicator / Button",
            //    IconSource = "ic_filter_1_black_24dp.png",
            //    TargetType = typeof(ActivityIndicatorAndButtonPage)
            //});
            //contentPagesGroup.Add(new StartMenuItem
            //{
            //    Title = "PopUps Page",
            //    IconSource = "ic_filter_2_black_24dp.png",
            //    TargetType = typeof(PopUpsPage)
            //});
            //contentPagesGroup.Add(new StartMenuItem
            //{
            //    Title = "Slider / Entry/ Label / Bindings",
            //    IconSource = "ic_filter_3_black_24dp.png",
            //    TargetType = typeof(SliderEntryLabelBindingsPage)
            //});



            //// Tabbed Page
            //tabbedPagesGroup.Add(new StartMenuItem
            //{
            //    Title = "ListView e TabbedPage",
            //    IconSource = "ic_filter_4_black_24dp.png",
            //    TargetType = typeof (ListsTabbedPage)
            //});

            //grouped.Add(contentPagesGroup);
            //grouped.Add(tabbedPagesGroup);
            //listView.ItemsSource = grouped;
        }
    }
}