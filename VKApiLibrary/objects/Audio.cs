using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VKCOMCSharpLibrary.objects
{
    class Audio
    {
        int id;
        int ownerId;
        string artist;
        string title;
        int duration;
        Uri uri;
        int lyricsId;
        int genreId;
        DateTime date;
        bool noSearch;

        public int Id
        {
            get
            {
                return id;
            }
        }

        public int OwnerId
        {
            get
            {
                return ownerId;
            }
        }

        public string Artist
        {
            get
            {
                return artist;
            }
        }

        public string Title
        {
            get
            {
                return title;
            }
        }

        public int DurationMM
        {
            get
            {
                return duration / 60;
            }
        }

        public int DurationSS
        {
            get
            {
                return duration - DurationMM * 60;
            }
        }

        public Uri URI
        {
            get
            {
                return uri;
            }
        }

        public int LyricsId
        {
            get
            {
                return lyricsId;
            }
        }

        public int GenreId
        {
            get
            {
                return genreId;
            }
        }

        public bool isNoSearch
        {
            get
            {
                return noSearch;
            }
        }
    }
}
