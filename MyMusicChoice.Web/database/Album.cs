using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;

namespace MyMusicChoice.Web.database
{
    public class Album
    {
        public int AlbumId { get; set; }

        public string Name { get; set; }

        public int PublicationYear { get; set; }

        #region navigation properties

        public virtual Collection<Track> Tracks { get; set; }

        public int ArtistId { get; set; }

        #endregion navigation properties
    }
}