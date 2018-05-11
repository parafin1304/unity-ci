#if UNITY_EDITOR
using UnityEditor;
#endif
using UnityEngine;

public class BuildPlayerExample : MonoBehaviour
{
    public static void MyBuild()
    {
#if UNITY_EDITOR

        BuildPlayerOptions buildPlayerOptions = new BuildPlayerOptions();
        buildPlayerOptions.scenes = new[] { "Assets/Scene1.unity" };
        buildPlayerOptions.locationPathName = "iOSBuild";
        buildPlayerOptions.target = BuildTarget.iOS;
        buildPlayerOptions.options = BuildOptions.None;
        BuildPipeline.BuildPlayer(buildPlayerOptions);
#endif
    }
}