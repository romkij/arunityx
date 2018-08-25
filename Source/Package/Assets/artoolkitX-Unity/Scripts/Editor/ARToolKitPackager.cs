using UnityEditor;
using System.IO;

class ARToolKitPackager
{
    const string MAIN_DIRECTORY = "artoolkitX-Unity";
    const string PLUGINS_DIRECTORY = "Plugins";
    const string STREAMINGASSETS_DIRECTORY = "StreamingAssets";
    const string SEARCH_PATTERN = "*.*";
    const string ASSETS_DIRECTORY_NAME = "Assets";

    public static void CreatePackage()
    {
        string[] args = System.Environment.GetCommandLineArgs();
        string fileName = args[args.Length - 1];

        AssetDatabase.ExportPackage(
            GetAllAssetPaths(),
            fileName,
            UnityEditor.ExportPackageOptions.Default);
    }

    private static string[] GetAllAssetPaths()
    {
        return Directory.GetFiles(ASSETS_DIRECTORY_NAME, SEARCH_PATTERN, SearchOption.AllDirectories);
    }
}
