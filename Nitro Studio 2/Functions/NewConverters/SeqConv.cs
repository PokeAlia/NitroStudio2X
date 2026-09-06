using Melanchall.DryWetMidi.Core;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NitroStudio2.Functions.NewConverters
{
    public static class SeqConv
    {
        public static string[] GetSmftFromMid(MidiFile File)
        {
            List<string> lines = new List<string>();
            lines.Add(";;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;");
            lines.Add("; Generated with Nitro Studio 2X");
            lines.Add(";;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;");
            lines.Add("Sequence_Start: ");
            int tracks = 0;
            System.Collections.BitArray tracks_toggle = new System.Collections.BitArray(16);
            foreach(var track in File.GetTrackChunks())
            {
                tracks_toggle.Set(tracks, true);
                tracks++;
            }
            lines.Add("\talloctrack " + tracks_toggle.ToString());
            for (int t = 0; t < tracks; t++)
            {
                lines.Add("\topentrack " + t + ", _Track_" + t);
            }
            foreach(var line in lines)
            {
                Debug.WriteLine(line);
            }
            return lines.ToArray();
        }
    }
}
