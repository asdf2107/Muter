using System.Diagnostics;
using System.Drawing;

namespace Muter.Core
{
    /// <summary>
    /// Class for manipulating app's volume.
    /// </summary>
    public class App
    {
        private readonly Process _process;

        public int ProcessId => _process.Id;
        public string Name => _process.ProcessName;
        public Icon Icon => _process.GetIcon();

        public float Volume
        {
            get { return AudioManager.GetApplicationVolume(ProcessId).Value; }
            set { AudioManager.SetApplicationVolume(ProcessId, value); }
        }
        public bool IsMuted
        {
            get { return AudioManager.GetApplicationMute(ProcessId).Value; }
            set { AudioManager.SetApplicationMute(ProcessId, value); }
        }

        public App(Process process)
        {
            _process = process;
        }
    }
}
