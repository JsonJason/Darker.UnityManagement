using System;
using System.Collections.Generic;
using System.IO;

namespace Darker.UnityManagement
{
    public static class UnityVersionFinder
    {

        public static IEnumerable<string> GetChildDirectoriesWithUnityInstallations(string directory)
        {
            if (!Directory.Exists(directory))
                throw new ArgumentOutOfRangeException(nameof(directory), directory, "No Directory Found");

            var subddirectories = Directory.GetDirectories(directory);
            for (int i = 0, length = subddirectories.Length; i < length; i++)
            {
                var subdirectory = subddirectories[i];
                if (HasUnityInstall(subdirectory))
                    yield return subdirectory;
            }
        }

        public static bool HasUnityInstall(string directoryPath)
        {
            var executable = Path.Combine(directoryPath, "Editor", "Unity.exe");
            return File.Exists(executable);
        }
    }
}