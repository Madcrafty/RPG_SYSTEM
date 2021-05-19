using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(GlobalSystem))]
public class GlobalSystemEditor : Editor
{
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();
        GlobalSystem Gs = (GlobalSystem)target;
        EditorGUILayout.TextField("Focus", GUI.GetNameOfFocusedControl());

        if (GUILayout.Button("ForceUpdate"))
        {
            GUI.FocusControl(null);
            Gs.m_UpdateInheritanceEvent.Invoke();
        }
    }
}
