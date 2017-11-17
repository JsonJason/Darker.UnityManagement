using System.Net;
using System.Text.RegularExpressions;

namespace Darker.UnityManagement
{
    public class UnityWebsite
    {
        public static string ReleaseUrl(string version)
        {
            var url = "";
            if (version.Contains("f"))
            {
                version = Regex.Replace(version, @"f.", "", RegexOptions.IgnoreCase);
                return "https://unity3d.com/unity/whats-new/unity-" + version;
            }
            if (version.Contains("p"))
                return "https://unity3d.com/unity/qa/patch-releases/" + version;
            if (version.Contains("b"))
                return "https://unity3d.com/unity/beta/unity" + version;
            return url;
        }

        public static string DownloadUrl(string version)
        {
            var releaseUrl = ReleaseUrl(version);
            var url = "";
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            using (var client = new WebClient())
            {
                var html = client.DownloadString(releaseUrl);
                var regex = new Regex(@"(http).+(UnityDownloadAssistant)+[^\s*]*(.exe)");
                var match = regex.Match(html);
                var gr = match.Groups[0];
                if (gr.Captures.Count == 0) return url;
                var c = gr.Captures[0];
                url = c.Value;
                return url;
            }
        }
    }
}