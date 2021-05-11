using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class ExtendedEditorWindow : EditorWindow
{
    protected SerializedObject serializedObject;
    protected SerializedProperty currentProperty;

    protected void DrawProperties(SerializedProperty prop, bool drawChilderen)
    {
        string lastPropPath = string.Empty;
        if (prop.isArray && prop.propertyType == SerializedPropertyType.Generic)
        {
            foreach (SerializedProperty p in prop)
            {
                EditorGUILayout.BeginHorizontal();
                p.isExpanded = EditorGUILayout.Foldout(p.isExpanded, p.displayName);
                EditorGUILayout.EndHorizontal();
                if (p.isExpanded)
                {
                    EditorGUI.indentLevel++;
                    DrawProperties(p, drawChilderen);
                    EditorGUI.indentLevel--;
                }
                if (!string.IsNullOrEmpty(lastPropPath) && p.propertyPath.Contains(lastPropPath))
                {
                    lastPropPath = p.propertyPath;
                    EditorGUILayout.PropertyField(p, drawChilderen);
                }
            }
        }
        else
        {
            lastPropPath = prop.propertyPath;
            EditorGUILayout.PropertyField(prop, drawChilderen);
        }
    }
}
