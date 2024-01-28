using UnityEditor.Android;
using System.Collections.Generic;

public class ModifyProjectScript : AndroidProjectFilesModifier
{
    public override void OnModifyAndroidProjectFiles(AndroidProjectFiles projectFiles)
    {
        var attributesM1 = new Dictionary<string, string>() { ["android:name"] = "com.unity3d.player.UnityPlayerGameActivity"};
        var activityM0 = projectFiles.UnityLibraryManifest.Manifest.Application.ActivityList.GetElement(attributesM1);
        activityM0?.Attributes.Name.Set("com.unity3d.player.CustomUnityPlayerGameActivity");
    }
}
