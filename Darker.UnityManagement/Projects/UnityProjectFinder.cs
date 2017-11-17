using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Darker.UnityManagement
{
    public static class UnityProjectFinder
    {
        public static IEnumerable<string> GetChildDirectoriesWithUnityProjects(string directory)
        {
            var subdirectories = Directory.GetDirectories(directory);

            var found = GetUnityProjectsInDirectory(directory);
            foreach (var f in found)
            {
                yield return f;
            }

            foreach (var subdirectory in subdirectories)
            {
                found = GetUnityProjectsInDirectory(subdirectory);
                foreach (var f in found)
                {
                    yield return f;
                }
            }
                   
        }

        static IEnumerable<string> GetUnityProjectsInDirectory(string directory)
        {
            var subdirectories = Directory.GetDirectories(directory);

            foreach (var subdirectory in subdirectories)
                if (IsAProjectFolder(subdirectory))
                    yield return subdirectory;
        }

        private static bool IsAProjectFolder(string path)
        {
            var subdirectories = Directory.GetDirectories(path).ToList();
            return subdirectories.Contains(Path.Combine(path, "Assets")) &&
                   subdirectories.Contains(Path.Combine(path, "Library")) &&
                   subdirectories.Contains(Path.Combine(path, "ProjectSettings"));
        }
    }
}