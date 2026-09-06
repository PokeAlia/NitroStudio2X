using NAudio.CoreAudioApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NitroStudio2.Functions
{
    public static class ConfigurationDefaults
    {
        private static string GetDefaultWaveDevice()
        {
            string deviceId;
            try {
                deviceId = new MMDeviceEnumerator().GetDefaultAudioEndpoint(DataFlow.Render, Role.Console).ID;
            }
            catch {
                deviceId = "0";
            }
            return deviceId;
        }
        public static readonly Dictionary<string, string> Defaults = new Dictionary<string, string> {
            { "version", Global.version},
            { "writeNames", "true" },
            { "importTool", "NitroStudio" },
            { "exportTool", "NitroStudio" },
            { "inputMidiDevice", "0" },
            { "outputWaveDevice", GetDefaultWaveDevice()},
            { "viewHeap", "hex"},
        };
    }
}
