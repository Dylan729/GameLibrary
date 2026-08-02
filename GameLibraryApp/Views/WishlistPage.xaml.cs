using GameLibraryApp.Models;

namespace GameLibraryApp.Views;

public partial class WishlistPage : ContentPage
{
    private readonly GameDataService _service = new();

    public WishlistPage()
    {
        InitializeComponent();
    }

    public void RefreshWishlist()
    {
        var wishlist = _service.GetGames()
                               .Where(g => g.IsInWishlist)
                               .ToList();

        WishlistCollectionView.ItemsSource = wishlist;
    }
}
