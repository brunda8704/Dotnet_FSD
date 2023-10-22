using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceRealUsage
{
    internal class ProcessPlayer
    {
        // Interface is like base class
        //below line is same like IVideoPlayer videoPlayer = new Student();
        IVideoPlayer _videoPlayer;
        public ProcessPlayer(IVideoPlayer videoPlayer)
        {
            _videoPlayer = videoPlayer;
        }

        public void PlayData()
        {
            _videoPlayer.Play();
        }

    }
}
