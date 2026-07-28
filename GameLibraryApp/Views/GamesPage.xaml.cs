using GameLibraryApp.Services;
using GameLibraryApp.Models;

namespace GameLibraryApp.Views;

public partial class GamesPage : ContentPage
{
    private readonly GameDataService _service = new();

    public GamesPage()
    {
        InitializeComponent();
        GamesCollectionView.ItemsSource = _service.GetGames();
    }

    private async void OnGameSelected(object sender, SelectionChangedEventArgs e)
    {
        if (e.CurrentSelection.FirstOrDefault() is GameItem selectedGame)
        {
            await Shell.Current.GoToAsync(nameof(GameDetailsPage), true, new Dictionary<string, object>
            {
                { "Game", selectedGame }
            });
        }
    }
}
