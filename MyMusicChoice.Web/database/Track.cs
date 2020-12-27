using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MyMusicChoice.Web.database
{
    public class Track
    {
        public int TrackId { get; set; }

        [Required]
        public string Title { get; set; }

        /// <summary>
        /// In minutes.
        /// </summary>
        public int? Duration { get; set; }

        #region navigation properties

        public int? AlbumId { get; set; }

        public virtual Album Album { get; set; }

        #endregion navigation properties
    }
}