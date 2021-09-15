using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    class Program
    {
        static void Main(string[] args)
        {
            var video = new Video();
            video.Title = "My Video";

            var videoEncoder = new VideoEncoder();  // publisher
            var mailService = new MailService(); // subscriber
            var textService = new TextService(); // subscriber

            // Custom event handler with delegate
            //videoEncoder.VideoEncoded += mailService.OnVideoEncoded;
            //videoEncoder.VideoEncoded += textService.OnVideoEncoded;

            // Generic event handler 
            videoEncoder.GenericHandlerVideoEncoded += mailService.OnVideoEncoded;
            videoEncoder.GenericHandlerVideoEncoded += textService.OnVideoEncoded;
            

            videoEncoder.Encode(video);

            Console.ReadKey();
        }
    }
}
