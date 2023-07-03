using System;
using MonoDevelop.Components.Commands;
using MonoDevelop.Ide;
using MonoDevelop.Projects;
using System.Diagnostics;

namespace CodingWithCalvin.OpenBinFolder.VS4Mac
{
	public class OpenBinFolderCommand : CommandHandler
	{
        protected override void Run()
        {
            var activeConfig = IdeApp.Workspace.ActiveConfiguration;
            var project = IdeApp.ProjectOperations.CurrentSelectedProject;
            var projectConfig = (ProjectConfiguration)project.GetConfiguration(activeConfig);

#pragma warning disable CA1416
            Process.Start(new ProcessStartInfo
            {
                FileName = projectConfig!.OutputDirectory,
                UseShellExecute = true
            });
#pragma warning restore CA1416
        }
    }
}

