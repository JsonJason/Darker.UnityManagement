using System.Diagnostics;
using System.IO;

namespace Darker.UnityManagement
{
    public class UnityVersionFactory
    {
        public UnityVersion Create(string installDirectory)
        {
            var v = GetUnityVersionFromPath(installDirectory);
            return Create(v,GetVersionType(v),installDirectory);
        }

        public UnityVersion CreateFromVersionNumber(string version)
        {
            return new UnityVersion { Number = version, Type = GetVersionType(version), Path = null };
        }

        public UnityVersion Create(string version, string type,string path = null)
        {
            return new UnityVersion {Number = version, Type = type, Path = path};
        }

        private static string GetUnityVersionFromPath(string path)
        {
            var uninstallexecutable = Path.Combine(path, "Editor", "Uninstall.exe");
            var fvi = FileVersionInfo.GetVersionInfo(uninstallexecutable);
            return fvi.ProductName.Replace("(64-bit)", "").Replace("Unity", "").Trim();
        }

        private string GetVersionType(string version)
        {
            if (version.Contains("f"))
                return "Archived";
            if (version.Contains("p"))
                return "Patch";

            return version.Contains("b") ? "Beta" : "Unknown";
        }
    }
}