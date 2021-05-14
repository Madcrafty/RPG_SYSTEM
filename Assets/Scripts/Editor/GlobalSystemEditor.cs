using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(Type))]
public class GlobalSystemEditor : Editor
{
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        GUI.GetNameOfFocusedControl();
        EditorGUILayout.PropertyField()
    }
}
