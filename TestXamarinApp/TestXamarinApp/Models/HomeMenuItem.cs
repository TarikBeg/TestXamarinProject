namespace TestXamarinApp.Models
{
    public enum MenuItemType
    {
        Browse,
        About,
        TestForm
    }

    public class HomeMenuItem
    {
        public MenuItemType Id { get; set; }

        public string Title { get; set; }
    }
}