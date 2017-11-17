using System;
using System.IO;

namespace Darker.UnityManagement
{
    public class UnityProjectFactory
    {
        public UnityProject Create(string projectDirectory)
        {
            var info = new DirectoryInfo(projectDirectory);
            var projectName = info.Name;
            var csprojFile = Path.Combine(projectDirectory, projectName + ".csproj");

            if (File.Exists(csprojFile))
                csprojFile = Path.Combine(projectDirectory, projectName + ".Editor.csproj");

            var lastUpdated = GetLastUpdatedTime(csprojFile);

            var projectVersion = GetProjectVersion(projectDirectory);

            return Create(projectName, projectVersion, projectDirectory, lastUpdated);
        }


        public UnityProject Create(string name, string version, string path,
            DateTime? lastModified = null) => new UnityProject
        {
            LastModified = lastModified,
            Name = name,
            Version = version,
            Path = path
        };

        private DateTime? GetLastUpdatedTime(string path)
        {
            if (!File.Exists(path)) return null;

            var modification = File.GetLastWriteTime(path);
            return modification;
        }


        private string GetProjectVersion(string path)
        {
            var version = "";
            if (!Directory.Exists(Path.Combine(path, "ProjectSettings"))) return version;

            var versionPath = Path.Combine(path, "ProjectSettings", "ProjectVersion.txt");
            if (!File.Exists(versionPath)) return version;

            var data = File.ReadAllLines(versionPath);

            if (data.Length <= 0)
                throw new InvalidDataException("invalid projectversion data:" + data);

            var dd = data[0];
            if (!dd.Contains("m_EditorVersion"))
                throw new InvalidDataException("Cannot find m_EditorVersion:" + dd);

            var t = dd.Split(new[] {"m_EditorVersion: "}, StringSplitOptions.None);
            if (t.Length > 0)
                version = t[1].Trim();
            else
                throw new InvalidDataException("invalid version data:" + data);
            return version;
        }
    }
}