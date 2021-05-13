using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(Type))]
public class TypeEditor : Editor
{

    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();
        Type type = (Type)target;
        if (GUILayout.Button("Apply Changes"))
        {
             type.ApplyChanges();
        }
        switch (type.GetIterator())
        {
            case -1:
                if (GUILayout.Button("Revert Changes"))
                {
                    type.RevertChanges();
                }
                break;
            default:
                if (GUILayout.Button("Undo Changes"))
                {
                    type.RevertChanges();
                }
                break;
        }

    }
}
