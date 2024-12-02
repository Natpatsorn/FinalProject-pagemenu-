using System.Collections.ObjectModel;
using System.Text.Json;
using System.IO;

namespace FinalProject;
public partial class MenuPage : ContentPage
{
    public ObservableCollection<MenuItem> MenuItems { get; set; }
    public MenuPage()
    {
        InitializeComponent();
        LoadMenuItems();
    }

    private async void LoadMenuItems()
    {
        var menuService = new MenuService();
        var menuItems = await menuService.ReadJsonCrossPlatformAsync();
        MenuListView.ItemsSource = menuItems;
    }

    private void OnMenuItemSelected(object sender, SelectionChangedEventArgs e)
    {
        if (e.CurrentSelection.FirstOrDefault() is MenuItem selectedItem)
        {
            DisplayAlert("Selected", $"You selected {selectedItem.Name}", "OK");
        }
    }
}
