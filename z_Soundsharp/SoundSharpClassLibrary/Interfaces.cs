using System;
using System.Collections.Generic;
using System.Text;

namespace AudioDevices.Interfaces
{
    public class Interfaces
    {
        public interface IDisplay 
        {
            string GetResolutionInfo();
            int DisplayWidth { get; set; }
            int DisplayHeight { get; set; }
            int TotalPixels { get; }
        }
    }
}