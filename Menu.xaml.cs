public partial class MenuPage : ContentPage
{
    public MenuPage()
    {
        InitializeComponent();

        var restaurants = new List<Restaurant>
        {
            new Restaurant
            {
                RestaurantName = "ลุงกับป้า",
                Menus = new List<Menu>
                {
                    new Menu { MenuItem = "ชานมไข่มุกใต้หวัน", Price = "30-35 บาท" },
                    new Menu { MenuItem = "น้ำผึ้งโซดา", Price = "25 บาท" }
                }
            },
            new Restaurant
            {
                RestaurantName = "มุมกิน ฮาลาล",
                Menus = new List<Menu>
                {
                    new Menu { MenuItem = "ข้าวหมกไก่", Price = "50 บาท" },
                    new Menu { MenuItem = "ข้าวหมกเนื้อ", Price = "60 บาท" }
                }
            }
        };

        BindingContext = restaurants;
    }
}
