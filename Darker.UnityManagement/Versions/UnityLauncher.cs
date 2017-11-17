using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;

namespace Darker.UnityManagement
{
    public class UnityLauncher
    {
        public void OpenFolder(UnityVersion version)
        {
            LaunchPath(version.Path);
        }

        public void OpenReleaseNotes(UnityVersion version)
        {
            LaunchPath(UnityWebsite.ReleaseUrl(version.Number));
        }

        public void OpenFolder(UnityProject project)
        {
            LaunchPath(project.Path);
        }

        public void Launch(UnityVersion version)
        {
            LaunchPath(Path.Combine(version.Path, "Editor", "Uninstall.exe"));
        }

        public void Launch(UnityVersion version, UnityProject project)
        {
            var launchProcess = new Process();
            var cmd = Path.Combine(version.Path, "Editor", "Unity.exe");
            var pars = " -projectPath " + "\"" + project.Path + "\"";
            launchProcess.StartInfo.FileName = cmd;
            launchProcess.StartInfo.Arguments = pars;
            launchProcess.Start();
        }

        public void Uninstall(UnityVersion version)
        {
            LaunchPath(Path.Combine(version.Path, "Editor", "Unity.exe"));
        }

        public bool DownloadAndRun(UnityVersion version)
        {
            var url = UnityWebsite.DownloadUrl(version.Number);
            if (String.IsNullOrWhiteSpace(url)) return false;
            DownloadAndRun(url);
            return true;
        }


        void DownloadAndRun(string downloadUrl)
        {
            using (var downloader = new WebClient())
            {
                var f = GetFileNameFromUrl(downloadUrl);
                var fileInfo = new FileInfo(f);
                downloader.DownloadFile(downloadUrl, f);

                if (!File.Exists(fileInfo.FullName)) return;

                var myProcess = new Process { StartInfo = { FileName = fileInfo.FullName } };
                try { 
                myProcess.Start();
                myProcess.WaitForExit();
                 }catch(Exception ex) { }
            }
        }

        void LaunchPath(string path)
        {
            var launchProcess = new Process
            {
                StartInfo = { FileName = path }
            };
            launchProcess.Start();
        }

        private string GetFileNameFromUrl(string url)
        {
            var uri = new Uri(url);
            var filename = uri.Segments.Last();
            return filename;
        }
    }
}