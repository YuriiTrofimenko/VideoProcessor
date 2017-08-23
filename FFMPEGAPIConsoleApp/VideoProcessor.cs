using NReco.VideoConverter;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FFMPEGAPIConsoleApp
{
    public class VideoProcessor
    {

        public void extractVideo()
        {
            var ffMpeg = new NReco.VideoConverter.FFMpegConverter();
            ffMpeg.FFMpegToolPath = "ffmpeg";
            ffMpeg.ConvertMedia(
                "input.mp4",
                "mp4",
                "output.mp3",
                "mp3",
                new ConvertSettings { AudioCodec = "libmp3lame", CustomOutputArgs = "-vn -ar 44100 -ac 2 -ab 192K" }
            );
            Console.WriteLine("Ok");
        }
    }
}
