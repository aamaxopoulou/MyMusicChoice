using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyMusicChoice.Web.database
{
    public class Track
    {
        public int TrackId { get; set; }

        public string Title { get; set; }

        /// <summary>
        /// In minutes.
        /// </summary>
        public int Duration { get; set; }

        #region navigation properties

        public int AlbumId { get; set; }

        #endregion navigation properties
    }
}