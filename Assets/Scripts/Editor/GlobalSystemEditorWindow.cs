//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//using UnityEditor;

//public class GlobalSystemEditorWindow : ExtendedEditorWindow
//{
//    public static void Open(GlobalSystem dataObject)
//    {
//        GlobalSystemEditorWindow window = GetWindow<GlobalSystemEditorWindow>("Game");
//        window.serializedObject = new SerializedObject(dataObject);
//    }
//    public void OnGUI()
//    {
//        currentProperty = serializedObject.FindProperty("memes");
//        DrawProperties(currentProperty, true);
//        currentProperty = serializedObject.FindProperty("StatList");
//        DrawProperties(currentProperty, true);
//        currentProperty = serializedObject.FindProperty("AttackList");
//        DrawProperties(currentProperty, true);
//        currentProperty = serializedObject.FindProperty("StatusList");
//        DrawProperties(currentProperty, true);
//        currentProperty = serializedObject.FindProperty("TypeList");
//        DrawProperties(currentProperty, true);
//    }
//}
