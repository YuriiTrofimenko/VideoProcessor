using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NReco.VideoConverter;

namespace FFMPEGAPIConsoleApp
{
    class Director
    {
        public Director()
        {
            public void doAction()
            {
                FFMpegConverter ffMpeg = new FFMpegConverter();
                //Call Builder methods here - get settings
                ffMpeg.ConvertMedia(
                    mInFile,
                    "mp4",
                    mOutFile,
                    "mp3",
                    settings
                );
            }
        }
    }
}
