using GameLibraryApp.Models;

namespace GameLibraryApp.Views;

public partial class GamesPage : ContentPage
{
    private readonly GameDataService _service = new();
    private List<GameItem> _allGames = new();

    public GamesPage()
    {
        InitializeComponent();
        GenrePicker.SelectedIndex = 0;

        ApplyFilters();
    }

    private void ApplyFilters()
    {
        string searchText = GameSearchBar.Text?.ToLower() ?? "";
        string selectedGenre = GenrePicker.SelectedItem?.ToString() ?? "All Genres";

        var filtered = _allGames
            .Where(g =>
                (selectedGenre == "All Genres" || g.Genre == selectedGenre) &&
                (string.IsNullOrWhiteSpace(searchText) || g.Title.ToLower().Contains(searchText)))
            .ToList();

        GamesCollectionView.ItemsSource = filtered;
        ResultCountLabel.Text = $"Results: {filtered.Count}";
    }

    private void OnSearchTextChanged(object sender, TextChangedEventArgs e)
    {
        ApplyFilters();
    }

    private void OnGenreChanged(object sender, EventArgs e)
    {
        ApplyFilters();
    }

    private async void OnViewDetailsClicked(object sender, EventArgs e)
    {
        if (sender is Button btn && btn.CommandParameter is GameItem game)
        {
            await Shell.Current.GoToAsync(nameof(GameDetailsPage), true, new Dictionary<string, object>
            {
                { "Game", game }
            });
        }



}
