using Muter.Core;
using System.Windows.Forms;

namespace Muter
{
    public partial class Form1 : Form
    {
        const int AdjustHeightStep = 10;
        const int EmptyHeight = 150;

        public Form1()
        {
            InitializeComponent();
        }

        private void Reload()
        {
            MainFlow.Controls.Clear();

            foreach (var app in AppManager.GetAppsUsingVolume())
            {
                MainFlow.Controls.Add(new AppSoundControl(app));
            }

            AdjustHeight();
        }

        private void AdjustHeight()
        {
            if (MainFlow.VerticalScroll.Visible)
            {
                while (MainFlow.VerticalScroll.Visible)
                {
                    Height += AdjustHeightStep;
                }
            }
            else if (MainFlow.Controls.Count > 0)
            {
                while (!MainFlow.VerticalScroll.Visible)
                {
                    Height -= AdjustHeightStep;
                }

                Height += AdjustHeightStep;
            }
            else
            {
                Height = EmptyHeight;
            }
        }

        private void Form1_Load(object sender, System.EventArgs e)
        {
            Reload();
        }

        private void ReloadButton_Click(object sender, System.EventArgs e)
        {
            Reload();
        }

        private void ResetAllButton_Click(object sender, System.EventArgs e)
        {
            ResetAllAppSoundControls();
        }

        private void ResetAllAppSoundControls()
        {
            foreach (var control in MainFlow.Controls)
            {
                ((AppSoundControl)control).Reset();
            }
        }
    }
}