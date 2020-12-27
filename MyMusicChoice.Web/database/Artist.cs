using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MyMusicChoice.Web.database
{
    public class Artist
    {
        public int ArtistId { get; set; }

        [Required]
        public string Name { get; set; }

        public DateTime? DateOfBirth { get; set; }

        #region navigation properties

        public virtual Collection<Album> Albums { get; set; }

        #endregion navigation properties
    }
}