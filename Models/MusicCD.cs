using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MbmStore.Models
{
    public class MusicCD : Product
    {
        public ICollection<Track> Tracks { get; } = new List<Track>();
        //public List<Track> Tracks { get; } = new List<Track>();
        public string Artist { get; set; }
        public string Label { get; set; }
        public string Publisher { get; set; }
        private TimeSpan _totalTime;
        public TimeSpan TotalTime
        {
            set { _totalTime = value; }
            get { return _totalTime; }
        }

        public MusicCD() { }

        public MusicCD(int productId, string artist, string title, decimal price, string publisher, string imageFileName, Track[] tracks)
        {
            Artist = artist;
            Title = title;
            Price = price;
            Publisher = publisher;
            ImageFileName = imageFileName;
            ProductId = productId;

            if (tracks != null)
            {
                foreach (Track track in tracks)
                {
                    AddTrack(track);
                }

                TotalTime = GetTotalTime();
            }
        }

        public MusicCD(int productId, string artist, string title, decimal price, string publisher, string imageFileName, Track[] tracks, string category)
        {
            Artist = artist;
            Title = title;
            Price = price;
            Publisher = publisher;
            ImageFileName = imageFileName;
            ProductId = productId;
            Category = category;

            if (tracks != null)
            {
                foreach (Track track in tracks)
                {
                    AddTrack(track);
                }

                TotalTime = GetTotalTime();
            }
        }

        public void AddTrack(Track track)
        {
            Tracks.Add(track);
        }

        public TimeSpan GetTotalTime()
        {
            TimeSpan totalTime = new TimeSpan(0);
            if (Tracks != null)
            {
                foreach (Track track in Tracks)
                {
                    totalTime += track.Length;
                }
            }

            return totalTime;
        }
    }
}
