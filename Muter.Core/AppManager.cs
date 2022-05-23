using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;

namespace Muter.Core
{
    public static class AppManager
    {
        public static IEnumerable<App> GetAppsUsingVolume()
        {
            return Process.GetProcesses()
                .Where(p => p.Id != 0 && AudioManager.GetApplicationVolume(p.Id) != null)
                .Select(p => new App(p));
        }

        public static Icon GetIcon(this Process process)
        {
            try
            {
                return Icon.ExtractAssociatedIcon(process.MainModule.FileName);
            }
            catch
            {
                return null;
            }
        }
    }
}
