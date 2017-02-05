using EnvDTE;
using Microsoft.VisualStudio.TemplateWizard;
using System;
using System.Collections.Generic;
using System.IO;

namespace Prism.Forms.Plugin.Wizard
{
    public class NewProjectWizard : IWizard
    {
        private DTE _dte = null;

        private string _solutionDir = null;

        private string _templateDir = null;

        private string _projectName = null;

        PluginNewProjectDialogResult _dialogResult;

        public void BeforeOpeningFile(ProjectItem projectItem)
        {
        }

        public void ProjectFinishedGenerating(Project project)
        {
            if (_dialogResult.CreateAndroid)
                CreateProject(Target.Droid.ToString());

            if (_dialogResult.CreateiOS)
                CreateProject(Target.iOS.ToString());

            if (_dialogResult.CreateUwp)
                CreateProject(Target.UWP.ToString());

            //if (_dialogResult.CreateNuspec)
            //    CreateItem();

        }

        void CreateItem()
        {
            string name = $"nuspecs";

            string projectPath = System.IO.Path.Combine(_solutionDir, name);

            string templateName = $"Prism.Forms.Plugin.Nuspec";

            string templatePath = System.IO.Path.Combine(System.IO.Path.GetDirectoryName(_templateDir), $"{templateName}.zip\\{templateName}.vstemplate");

            _dte.Solution.AddFromTemplate(templatePath, projectPath, name);
        }

        void CreateProject(string platform)
        {
            string name = $"{_projectName}.{platform}";

            string projectPath = System.IO.Path.Combine(_solutionDir, Path.Combine(_projectName, name));

            string templateName = $"Prism.Forms.Plugin.{platform}";

            string templatePath = System.IO.Path.Combine(System.IO.Path.GetDirectoryName(_templateDir), $"{templateName}.zip\\{templateName}.vstemplate");

            _dte.Solution.AddFromTemplate(templatePath, projectPath, name);

        }

        public void ProjectItemFinishedGenerating(ProjectItem projectItem)
        {
        }

        public void RunFinished()
        {
        }

        public void RunStarted(object automationObject, Dictionary<string, string> replacementsDictionary, WizardRunKind runKind, object[] customParams)
        {
            try
            {
                _dte = automationObject as DTE;

                _projectName = replacementsDictionary["$safeprojectname$"];

                _solutionDir = System.IO.Path.GetDirectoryName(replacementsDictionary["$destinationdirectory$"]);

                _templateDir = System.IO.Path.GetDirectoryName(customParams[0] as string);

                PluginNewProjectDialog dialog = new PluginNewProjectDialog();
                dialog.ShowDialog();
                _dialogResult = dialog.Result;


                if (_dialogResult.Cancelled)

                    throw new WizardBackoutException();

            }
            catch (Exception)
            {
                if (Directory.Exists(_solutionDir))

                    Directory.Delete(_solutionDir, true);
                throw;
            }
        }

        public bool ShouldAddProjectItem(string filePath)
        {
            return true;
        }
    }
}
