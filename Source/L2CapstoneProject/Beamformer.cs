using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L2CapstoneProject
{
    abstract class Beamformer
    {
        public abstract Boolean? Connect();

        public abstract Boolean? Disconnect();
        
    }


    class BeamformerSim : Beamformer
    {
        override public Boolean? Connect()
        {
            Boolean? isConnected = null;
            return isConnected;
        }

        override public Boolean? Disconnect()
        {
            Boolean? isConnected = null;
            return isConnected;
        }
      
    }
}
