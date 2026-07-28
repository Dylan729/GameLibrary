using GameLibraryApp.Services;
using GameLibraryApp.Models;

namespace GameLibraryApp.Views;

public partial class WishlistPage : ContentPage
{
    private readonly GameDataService _service = new();

    public WishlistPage()
    {
        InitializeComponent();

        var wishlist = _service.GetGames()
                               .Where(g => g.IsInWishlist)
                               .ToList();

        WishlistCollectionView.ItemsSource = wishlist;
    }
}
