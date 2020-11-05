using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L2CapstoneProject
{
    class TestMode
    {
        public Boolean AbortRequest = false;
    }

    class Stepped : TestMode
    {
        public void WriteOffset(PhaseAmplitudeOffset Values)
        {

        }
    }

    class Sequence : TestMode
    {
        public void InitiateSequence()
        {

        }

        public void AbortSequence()
        {
            AbortRequest = true;
        }

        public void ConfigureSequence(PhaseAmplitudeOffset Values, string SequenceType)
        {
            if (SequenceType == "Static")
            {

            }

            else if (SequenceType == "Dynamic")
            {

            }
        }
    }
}
