using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NationalInstruments.Common;

namespace L2CapstoneProject
{
    abstract class Beamformer
    {
        public abstract bool? Connect();

        public abstract bool? Disconnect();
        
    }

    class BeamformerSim : Beamformer
    {
        override public bool? Connect()
        {
            bool? isConnected = null;
            return isConnected;
        }

        override public bool? Disconnect()
        {
            bool? isConnected = null;
            return isConnected;
        }
      
    }
}
