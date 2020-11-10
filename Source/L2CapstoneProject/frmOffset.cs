using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace L2CapstoneProject
{
    public partial class frmOffset : Form
    {
        public frmOffset(Mode mode)
        {
            InitializeComponent();
            ViewMode = mode;

            switch (ViewMode)
            {
                case Mode.Add:
                    this.Text = "Add New Offset";
                    break;
                case Mode.Edit:
                    this.Text = "Edit Offset";
                    break;
            }
        }

        public enum Mode { Add, Edit }

        public Mode ViewMode { get; }

        private PhaseAmplitudeOffset settings;

        public PhaseAmplitudeOffset GetSettings()
        {
            return settings;
        }

        public void SetSettings(PhaseAmplitudeOffset value)
        {
            settings = value;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.settings = new PhaseAmplitudeOffset(this.numPhase.Value,this.numAmp.Value);
            this.Close();
         }

        private void numPhase_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
