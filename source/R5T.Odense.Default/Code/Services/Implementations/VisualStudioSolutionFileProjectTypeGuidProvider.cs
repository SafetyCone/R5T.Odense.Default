using System;using R5T.T0064;


namespace R5T.Odense.Default
{[ServiceImplementationMarker]
    public class VisualStudioSolutionFileProjectTypeGuidProvider : IVisualStudioSolutionFileProjectTypeGuidProvider,IServiceImplementation
    {
        public Guid GetCSharpNetStandardLibraryProjectTypeGuid()
        {
            // This is the new value that should be used for all cross-platform .NET Core/Standard projects.
            var cSharpNetStandardLibrary = Guid.Parse("9A19103F-16F7-4668-BE54-9A1E7A4F7556");
            return cSharpNetStandardLibrary;
        }

        public Guid GetOldCSharpNetStandardLibraryProjectTypeGuid()
        {
            // This is the value created by the Visual Studio 2017 new .NET Standard library project.
            var cSharpNetStandardLibrary = Guid.Parse("FAE04EC0-301F-11D3-BF4B-00C04F79EFBC");
            return cSharpNetStandardLibrary;
        }
    }
}
