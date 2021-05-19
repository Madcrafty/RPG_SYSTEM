using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(Entity))]
public class EntityEditor : Editor
{
    public bool showPosition = true;
    public string status = "Select a GameObject";

    float[] pv;
    float[] sv;

    public override void OnInspectorGUI()
    {
        Entity entity = (Entity)target;
        pv = entity.PrimaryValues;
        sv = entity.SecondaryValues;
        EditorGUILayout.BeginHorizontal();
        GUILayout.FlexibleSpace();
        EditorGUILayout.EndHorizontal();
        Rect scale = GUILayoutUtility.GetLastRect();

        //showPosition = EditorGUI.Foldout(new Rect(3, 3, scale.width - 6, 15), showPosition, status);
        //if (showPosition)
        //    if (Selection.activeTransform)
        //    {
        //        Selection.activeTransform.position = EditorGUI.Vector3Field(new Rect(3, 25, scale.width - 6, 40), "Position", Selection.activeTransform.position);
        //        status = Selection.activeTransform.name;
        //    }
        //EditorGUI.BeginFoldoutHeaderGroup()
        EditorGUILayout.LabelField("PrimaryStats: ", "Some of that cool shit");
        EditorGUI.indentLevel++;
        for (int i = 0; i < entity.globalSystem.StatList.Length; i++)
        {
            entity.PrimaryValues[i] = EditorGUILayout.FloatField(entity.globalSystem.StatList[i].name, pv[i]);
        }
        EditorGUI.indentLevel--;

        EditorGUILayout.LabelField("SecondaryStats: ", "Some of that cool shit");
        EditorGUI.indentLevel++;
        for (int i = 0; i < entity.globalSystem.StatList2.Length; i++)
        {
            entity.SecondaryValues[i] = EditorGUILayout.FloatField(entity.globalSystem.StatList2[i].name, sv[i]);
        }
        EditorGUI.indentLevel--;
        //base.OnInspectorGUI();
    }
    //Values with the name of the stat next to them
    //Secondary Values will have one value as base and the other just shows the effective value
    //Types and attacks will allow you to select from the list in the GlobalSystem (maybe)
}
