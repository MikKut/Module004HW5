using System.ComponentModel.DataAnnotations;

namespace Module004HW5.Models
{
    public class ArtistSong
    {
        public int ArtistId { get; set; }
        public int SongId { get; set; }
        public virtual Artist Artist { get; set; }
        public virtual Song Song { get; set; }
    }
}
