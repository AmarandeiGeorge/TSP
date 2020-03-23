using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryNetCore
{
    public partial class Album
    {
        public int AlbumId { get; set; }
        public string AlbumName { get; set; }

        public ICollection<ArtistAlbum> ArtistAlbums { get; set; }
    }
}
