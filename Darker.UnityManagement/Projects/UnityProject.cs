using System;

namespace Darker.UnityManagement
{
    [Serializable]
    public class UnityProject
    {
        public string Name { get; set; }
        public string Version { get; set; }
        public string Path { get; set; }
        public DateTime? LastModified { get; set; }
    }
}
