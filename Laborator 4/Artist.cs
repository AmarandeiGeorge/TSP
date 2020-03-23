using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryNetCore
{
    public partial class Artist
    {
        public int ArtistId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public ICollection<ArtistAlbum> ArtistAlbums { get; set; }
    }
}
