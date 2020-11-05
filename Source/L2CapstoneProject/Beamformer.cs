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
            Boolean? isConneted = null;
            return isConneted;
        }

        override public Boolean? Disconnect()
        {
            Boolean? isConneted = null;
            return isConneted;
        }
      
    }
}
