using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(Type))]
public class TypeEditor : Editor
{
    private void OnEnable()
    {
        EditorApplication.hierarchyChanged += ChangeName;
    }
    private void OnDisable()
    {
        EditorApplication.hierarchyChanged -= ChangeName;
    }
    void ChangeName()
    {
        //(Type)target.name
    }
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();
        Type type = (Type)target;
        if (GUILayout.Button("Apply Changes"))
        {
            GUI.FocusControl(null);
            type.ApplyChanges();
        }
        if (type.GetIterator() == -1)
        {
            if (GUILayout.Button("Revert Changes"))
            {
                GUI.FocusControl(null);
                type.RevertChanges();
            }
        }
        else if (type.GetIterator() == 0)
        {
            if (GUILayout.Button("Undo Changes"))
            {
                GUI.FocusControl(null);
                type.RevertChanges();
            }
        }
        else if (type.GetIterator() == type.GetUndoListLength() - 1)
        {
            if (GUILayout.Button("Redo Changes"))
            {
                GUI.FocusControl(null);
                type.RedoChanges();
            }
        }
        else
        {
            if (GUILayout.Button("Undo Changes"))
            {
                GUI.FocusControl(null);
                type.RevertChanges();
            }
            if (GUILayout.Button("Redo Changes"))
            {
                GUI.FocusControl(null);
                type.RedoChanges();
            }
        }
    }
}
