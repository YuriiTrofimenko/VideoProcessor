using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NReco.VideoConverter;

namespace FFMPEGAPIConsoleApp
{
    public class ConcreteBuilder : Builder
    {
        public List<String> actionList;
        //private FFMpegConverter ffMpeg;
        private ConvertSettings settings;

        //TODO move to Director
        private String mInFile;
        private String mOutFile;

        public ConcreteBuilder()
        {
            //ffMpeg = new FFMpegConverter();
            settings = new ConvertSettings();
        }


        //TODO move to Director
        public override void BuildInputFile(string InFile)
        {
            mInFile = InFile;
        }
        //TODO move to Director
        public override void BuildOutputFile(string OutFile)
        {
            mOutFile = OutFile;
        }

        public override void BuildAudioCodec(string AudioCodec)
        {
            settings.AudioCodec = AudioCodec;
        }

        public override void BuildVideoCodec(string VideoCodec)
        {
            settings.VideoCodec = VideoCodec;
        }

        public override void BuildDurationInString()
        {
            throw new NotImplementedException();
        }

        public override void BuildTimeStamp()
        {
            throw new NotImplementedException();
        }

        public override void BuildMetaData(string MetaString)
        {
            throw new NotImplementedException();
        }

        public override FFMpegConverter GetResult()
        {
            

            return null;
        }
    }
}
