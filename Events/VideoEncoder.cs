using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Events
{
    public class VideoEncoder
    {
        // 1. Define a delegate
        public delegate void VideoEncodedEventHandler(object source, VideoEventArgs args);

        // 2.1 Define an event based on that delegate
        //public event VideoEncodedEventHandler VideoEncoded;

        // 2.1 Define an event based on Framework generic EventHandler
        public event EventHandler<VideoEventArgs> GenericHandlerVideoEncoded;

        public void Encode(Video video)
        {
            Console.WriteLine("Encoding Video");
            Thread.Sleep(3000);
            OnVideoEncoded(video);
        }

        // 3. Raise the event
        protected virtual void OnVideoEncoded(Video video)
        {
            if (GenericHandlerVideoEncoded != null)
            {
                GenericHandlerVideoEncoded(this, new VideoEventArgs() { Video = video});
            }
        }
    }
}
