using System;

namespace GameLibraryApp.Models
{
    /// <summary>
    /// Represents a single game item in the library or wishlist.
    /// </summary>
    public class GameItem
    {
        public int Id { get; set; }

        public string Title { get; set; } = string.Empty;

        public string Genre { get; set; } = string.Empty;

        public string Platform { get; set; } = string.Empty;

        public int ReleaseYear { get; set; }
        public double Rating { get; set; }
        public string Description { get; set; } = string.Empty;

        /// <summary>
        /// The image file name or URI for the game cover.
        /// </summary>
        public string ImageName { get; set; } = string.Empty;

        public bool IsInWishlist { get; set; }
    }
