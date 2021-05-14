//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//using UnityEditor;
//using UnityEditor.Callbacks;

//public class AssetHandler
//{
//    [OnOpenAsset()]
//    public static bool OpenEditor(int instanceID, int line)
//    {
//        GlobalSystem obj = EditorUtility.InstanceIDToObject(instanceID) as GlobalSystem;
//        if (obj != null)
//        {
//            GlobalSystemEditorWindow.Open(obj);
//            return true;
//        }
//        return false;
//    }
//}

//[CustomEditor(typeof(GlobalSystem))]
//public class GlobalSystemCustomEditor : Editor
//{
//    public override void OnInspectorGUI()
//    {
//        if (GUILayout.Button("Open Editor"))
//        {
//            GlobalSystemEditorWindow.Open((GlobalSystem)target);
//        }
//    }
//}
