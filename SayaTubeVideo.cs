using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jurnalmod6_1302210063
{
    internal class SayaTubeVideo
    {
        private int id;
        private String title;
        private int PlayCount;

        public SayaTubeVideo(int id, String title, int PlayCount)
        {
            this.id = id;   
            this.title = title;
            this.PlayCount = PlayCount;
        }

        public void IncreasePlayCount(int playCount)
        {
            Debug.Assert(PlayCount > 300 || PlayCount < 0,"Input Penambahan Playlist 100 per panggilan methodnya");
            
            
        }
        public void PrintVideoDetails()
        {
            Console.WriteLine("id: " +  this.id);
            Console.WriteLine("judul: "  + this.title);
            Console.WriteLine("Playcount: " +  this.PlayCount);
        }

 
        public int getId()
        {
            return this.id;
        }
        public int getPlayCount()
        {
            return this.PlayCount;
        }
        public String getTitle()
        {
            return this.title;
        }
    }
}
