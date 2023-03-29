using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jurnalmod6_1302210063
{
    internal class SayaTubeUser
    {
        private int id;
        private List<SayaTubeVideo> uploadedVideos;
        private String Username;

       public SayaTubeUser(String username)
        {
            this.Username = username;
        }
        public int getTotalVideoPlayCount()
        {
            int i = 0;
            foreach(var video in uploadedVideos)
            {
                i = i + video.getPlayCount();
            }
            return i;
        }
        public void AddVideo(SayaTubeVideo video) 
        {
            uploadedVideos.Add(video);
        }
        public void PrintAllVideosPlaycount()
        {
            Console.WriteLine("user :" +  Username);
            foreach (var video in uploadedVideos)
            {
                Console.WriteLine("video " );
            }
            Console.WriteLine("Video 1 Judul: " );
            Console.WriteLine("" ); 
        }
    }
}
