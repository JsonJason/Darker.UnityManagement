using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Darker.UnityManagement.Examples
{
    public class ExamplesController
    {
        private readonly ExampleForm _form;

        public ExamplesController(ExampleForm form)
        {
            _form = form;
        }

        readonly List<UnityVersion> projectVersions = new List<UnityVersion>();
        
            
        List<UnityProject> CreateProjectsList(string directory)
        {
            var versionFactory = new UnityVersionFactory();
            var projects = new List<UnityProject>();
            if (!Directory.Exists(directory)) return null;
            var installDirectories = UnityProjectFinder.GetChildDirectoriesWithUnityProjects(directory);
            var factory = new UnityProjectFactory();
            foreach (var dir in installDirectories)
            {
                var project = factory.Create(dir);
                projects.Add(project);
                projectVersions.Add(versionFactory.CreateFromVersionNumber(project.Version));
            }

            return projects;
        }

        List<UnityVersion> CreateVersionsList(string directory)
        {
            var versions = new List<UnityVersion>();
            if (!Directory.Exists(directory)) return null;
            var installDirectories = UnityVersionFinder.GetChildDirectoriesWithUnityInstallations(directory);
            var factory = new UnityVersionFactory();
            foreach (var dir in installDirectories)
                versions.Add(factory.Create(dir));

            foreach (var projectVersion in projectVersions)
            {
                if (!versions.Select(x => x.Number).Contains(projectVersion.Number))
                {
                    versions.Add(projectVersion);
                    
                }
            }

            return versions;
         }

        public void RefreshVersions()
        {
           _form.SetVersions(CreateVersionsList(_form.VersionPath));
        }

        public void RefreshProjects()
        {
            _form.SetProjects(CreateProjectsList(_form.ProjectPath));
        }

        public void Refresh()
        {
            RefreshProjects();
            RefreshVersions();
        }

    }
}
