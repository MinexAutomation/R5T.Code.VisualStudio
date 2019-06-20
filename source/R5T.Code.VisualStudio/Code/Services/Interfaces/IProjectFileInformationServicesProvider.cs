using System;

using R5T.Code.VisualStudio.IO;


namespace R5T.Code.VisualStudio
{
    public interface IProjectFileInformationServicesProvider
    {
        ProjectFilePath[] GetReferencedProjectFilePaths(ProjectFilePath projectFilePath);
        ProjectFilePath[] GetReferencedProjectFilePathsRecursive(ProjectFilePath projectFilePath);

        /// <summary>
        /// Determines if a project file has a version, and if so, returns the version.
        /// If the project file does not have a version, returns <see cref="R5T.NetStandard.VersionHelper.None"/>.
        /// </summary>
        bool HasVersion(ProjectFilePath projectFilePath, out Version version);
    }
}
