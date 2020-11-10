namespace L2CapstoneProject
{
    public class PhaseAmplitudeOffset
    {
        public decimal Phase { get; set; }
        public decimal Amplitude { get; set; }

        public PhaseAmplitudeOffset(decimal PhaseOffset, decimal AmplitudeOffset)
        {
            Phase = PhaseOffset;
            Amplitude = AmplitudeOffset;
        }

        //public override string ToString()
        //{
        //    return $"Phase: {this.Phase} | Ampliture: {this.Amplitude}";
        //}
    }
}
