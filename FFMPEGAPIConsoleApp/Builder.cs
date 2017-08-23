using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NReco.VideoConverter;

namespace FFMPEGAPIConsoleApp
{
    abstract class Builder
    {
        public abstract void BuildInputFile(string InFile); //-i url (input)
        public abstract void BuildOutputFile(string OutFile);
        public abstract void BuildAudioCodec(string AudioCodec); //-codec[:stream_specifier] codec (input/output,per-stream)
        public abstract void BuildVideoCodec(string VideoCodec); //-codec[:stream_specifier] codec (input/output,per-stream)
        public abstract void BuildDurationInString(); //-t duration (input/output)
        public abstract void BuildTimeStamp(); //-timestamp date (output)
        public abstract void BuildMetaData(string MetaString); //-metadata[:metadata_specifier] key=value (output,per-metadata)
        //-frames[:stream_specifier] framecount (output,per-stream)
        public abstract FFMpegConverter GetResult();
    }
}
