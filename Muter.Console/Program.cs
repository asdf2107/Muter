using System;
using c = System.Console;
using Muter.Core;

namespace Muter.Console
{
    internal class Program
    {
        [STAThread]
        static void Main()
        {
            var apps = AppManager.GetAppsUsingVolume();

            foreach (var app in apps)
            {
                c.WriteLine($"{app.ProcessId,10} {app.Volume,3} {app.IsMuted} {app.Name}");
            }

            c.WriteLine(AudioManager.GetMasterVolume());

            while (true)
            {
                //AudioManager.SetMasterVolume(int.Parse(c.ReadLine()));
                //AudioManager.SetApplicationVolume(int.Parse(c.ReadLine()), 0.5f);
                AudioManager.SetApplicationMute(int.Parse(c.ReadLine()), c.ReadLine() == "0");
            }
        }
    }
}
