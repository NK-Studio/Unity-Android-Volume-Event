using System;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;
using Object = UnityEngine.Object;

namespace NKStudio.UFolder.Editor
{
    [CustomEditor(typeof(Runtime.UFolder))]
    public class UFolderGUI : UnityEditor.Editor
    {
        private static string Prefix => EditorGUIUtility.isProSkin ? "d_" : "";

        public override VisualElement CreateInspectorGUI()
        {
            ApplyIcon(target);
            return base.CreateInspectorGUI();
        }

        /// <summary>
        /// Applies an icon to the given GameObject.
        /// </summary>
        /// <param name="target">The GameObject to which the icon will be applied.</param>
        private static void ApplyIcon(Object target)
        {
            string iconName = Prefix + "Folder Icon";
            Texture2D icon = EditorGUIUtility.FindTexture(iconName);
            EditorGUIUtility.SetIconForObject(target, icon);
        }
    }
}
