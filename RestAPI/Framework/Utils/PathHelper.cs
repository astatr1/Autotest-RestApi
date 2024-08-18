namespace RestAPI.Framework.Utils
{
    public static class PathHelper
    {
        public static string GetProjectPath()
        {
            var testDirectory = TestContext.CurrentContext.TestDirectory;
            var projectDirectory = Directory.GetParent(testDirectory).Parent.Parent.FullName;
            return projectDirectory;
        }

        public static string GetFullPath(string[] relativePath)
        {
            var projectPath = GetProjectPath();
            var fullPath = Path.Combine([projectPath, .. relativePath]);
            return fullPath;
        }
    }
}
