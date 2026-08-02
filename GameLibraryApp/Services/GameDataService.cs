using GameLibraryApp.Models;

namespace GameLibraryApp.Services
{
    public class GameDataService
    {
        public List<GameItem> GetGames()
        {
            return new List<GameItem>
            {
                new GameItem
                {
                    Id = 1,
                    Title = "Eclipse Vanguard",
                    Genre = "Action",
                    Platform = "PC",
                    ReleaseYear = 2025,
                    Rating = 8.7,
                    Description = "A fast‑paced sci‑fi shooter where players defend colonies from rogue AI fleets.",
                    ImageName = "FightingGame.jpg",
                    IsInWishlist = true
                },
                new GameItem
                {
                    Id = 2,
                    Title = "Mystic Trails",
                    Genre = "Adventure",
                    Platform = "Nintendo Switch",
                    ReleaseYear = 2024,
                    Rating = 9.1,
                    Description = "Explore enchanted forests and ancient ruins in a story‑driven fantasy world.",
                    ImageName = "ExploreGame.jpg",
                    IsInWishlist = false
                },
                new GameItem
                {
                    Id = 3,
                    Title = "Velocity Drift",
                    Genre = "Racing",
                    Platform = "PlayStation 5",
                    ReleaseYear = 2023,
                    Rating = 8.3,
                    Description = "High‑octane street racing with dynamic weather and real‑time vehicle tuning.",
                    ImageName = "RacingGame.jpg",
                    IsInWishlist = true
                },
                new GameItem
                {
                    Id = 4,
                    Title = "Goal Masters 26",
                    Genre = "Sports",
                    Platform = "Xbox Series X",
                    ReleaseYear = 2026,
                    Rating = 7.9,
                    Description = "Next‑gen football simulation featuring adaptive AI and realistic stadium atmospheres.",
                    ImageName = "SportsGame.jpg",
                    IsInWishlist = false
                },
                new GameItem
                {
                    Id = 5,
                    Title = "Quantum Puzzles",
                    Genre = "Puzzle",
                    Platform = "PC",
                    ReleaseYear = 2025,
                    Rating = 8.5,
                    Description = "Solve mind‑bending logic challenges that manipulate time and space mechanics.",
                    ImageName = "PuzzleGame.jpg",
                    IsInWishlist = true
                },
                new GameItem
                {
                    Id = 6,
                    Title = "Empire Architect",
                    Genre = "Strategy",
                    Platform = "PC",
                    ReleaseYear = 2024,
                    Rating = 9.0,
                    Description = "Build and manage a sprawling empire through diplomacy, trade, and conquest.",
                    ImageName = "BuildingGame.jpg",
                    IsInWishlist = false
                },
                new GameItem
                {
                    Id = 7,
                    Title = "Farmstead Horizon",
                    Genre = "Simulation",
                    Platform = "PC",
                    ReleaseYear = 2023,
                    Rating = 8.2,
                    Description = "A relaxing farming simulator with dynamic seasons and customizable homesteads.",
                    ImageName = "FarmGame.jpg",
                    IsInWishlist = true
                },
                new GameItem
                {
                    Id = 8,
                    Title = "Shadow Nexus",
                    Genre = "Action",
                    Platform = "PlayStation 5",
                    ReleaseYear = 2026,
                    Rating = 9.4,
                    Description = "An open‑world cyber‑ninja adventure blending stealth, parkour, and futuristic combat.",
                    ImageName = "FinalGame.jpg",
                    IsInWishlist = false
                }
            };
        }
    }
}
