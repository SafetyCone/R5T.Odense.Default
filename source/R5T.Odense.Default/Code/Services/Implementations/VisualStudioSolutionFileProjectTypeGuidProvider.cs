using System;


namespace R5T.Odense.Default
{
    public class VisualStudioSolutionFileProjectTypeGuidProvider : IVisualStudioSolutionFileProjectTypeGuidProvider
    {
        public Guid GetNetStandardLibraryProjectTypeGuid()
        {
            // This is the value created by the Visual Studio 2017 new .NET Standard library project.
            var cSharpNetStandardLibrary = Guid.Parse("FAE04EC0-301F-11D3-BF4B-00C04F79EFBC");
            return cSharpNetStandardLibrary;
        }
    }
}
