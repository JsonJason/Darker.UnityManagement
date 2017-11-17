using System;

namespace Darker.UnityManagement
{
    /// <summary>
    /// A Version of the Unity3d Application
    /// </summary>
    [Serializable]
    public class UnityVersion
    {
        public string Number { get; set; }
        public string Type { get; set; }
        public string Path { get; set; }
    }
}
