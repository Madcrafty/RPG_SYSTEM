using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(Entity))]
public class EntityEditor : Editor
{
    public bool showPosition = true;
    public string status = "Select a GameObject";

    GlobalSystem gs;
    float[] pv;
    float[] sv;
    int[] al;
    int[] tl;
    int atkSize;
    int typeSize;

    public override void OnInspectorGUI()
    {
        Entity entity = (Entity)target;
        gs = entity.globalSystem;
        pv = entity.PrimaryValues;
        sv = entity.SecondaryValues;
        al = entity.Attacks;
        tl = entity.Types;
        
        //EditorGUILayout.BeginHorizontal();
        //GUILayout.FlexibleSpace();
        //EditorGUILayout.EndHorizontal();
        //Rect scale = GUILayoutUtility.GetLastRect();

        //showPosition = EditorGUI.Foldout(new Rect(3, 3, scale.width - 6, 15), showPosition, status);
        //if (showPosition)
        //    if (Selection.activeTransform)
        //    {
        //        Selection.activeTransform.position = EditorGUI.Vector3Field(new Rect(3, 25, scale.width - 6, 40), "Position", Selection.activeTransform.position);
        //        status = Selection.activeTransform.name;
        //    }
        //EditorGUI.BeginFoldoutHeaderGroup()
        entity.globalSystem = EditorGUILayout.ObjectField("", entity.globalSystem, typeof(GlobalSystem), true) as GlobalSystem;
        if (entity.globalSystem != null)
        {
            EditorGUILayout.LabelField("PrimaryStats: ", "Some of that cool shit");
            EditorGUI.indentLevel++;
            for (int i = 0; i < entity.globalSystem.StatList.Length && i < entity.PrimaryValues.Length; i++)
            {
                entity.PrimaryValues[i] = EditorGUILayout.FloatField(entity.globalSystem.StatList[i].name, pv[i]);
            }
            EditorGUI.indentLevel--;

            EditorGUILayout.LabelField("SecondaryStats: ", "Some of that cool shit");
            EditorGUI.indentLevel++;
            for (int i = 0; i < entity.globalSystem.StatList2.Length && i < entity.SecondaryValues.Length; i++)
            {
                entity.SecondaryValues[i] = EditorGUILayout.FloatField(entity.globalSystem.StatList2[i].name, sv[i]);
            }
            EditorGUI.indentLevel--;
            
            EditorGUILayout.LabelField("Attacks: ", "Some of that cool shit");
            atkSize = Mathf.Clamp(EditorGUILayout.IntField("Size", atkSize), 0, entity.globalSystem.AttackList.Length);
            if (entity.Attacks.Length != atkSize)
            {
                int[] atkTemp = new int[atkSize];
                for (int i = 0; i < atkTemp.Length && i < entity.Attacks.Length; i++)
                {
                    atkTemp[i] = entity.Attacks[i];
                }
                entity.Attacks = atkTemp;
                al = entity.Attacks;
            }
            EditorGUI.indentLevel++;
            for (int i = 0; i < entity.Attacks.Length; i++)
            {
                entity.Attacks[i] = Mathf.Clamp(EditorGUILayout.IntField(entity.globalSystem.AttackList[al[i]].name, al[i]), 0, entity.globalSystem.AttackList.Length - 1);
            }
            EditorGUI.indentLevel--;

            EditorGUILayout.LabelField("Types: ", "Some of that cool shit");
            typeSize = Mathf.Clamp(EditorGUILayout.IntField("Size", typeSize), 0, entity.globalSystem.TypeList.Length);
            if (entity.Types.Length != typeSize)
            {
                int[] typeTemp = new int[typeSize];
                for (int i = 0; i < typeTemp.Length && i < entity.Types.Length; i++)
                {
                    typeTemp[i] = entity.Types[i];
                }
                entity.Types = typeTemp;
                tl = entity.Types;
            }
            EditorGUI.indentLevel++;
            for (int i = 0; i < entity.Types.Length; i++)
            {
                entity.Types[i] = Mathf.Clamp(EditorGUILayout.IntField(entity.globalSystem.TypeList[tl[i]].name, tl[i]), 0, entity.globalSystem.TypeList.Length - 1);
            }
            EditorGUI.indentLevel--;
        }

        //base.OnInspectorGUI();
    }
    //Values with the name of the stat next to them
    //Secondary Values will have one value as base and the other just shows the effective value
    //Types and attacks will allow you to select from the list in the GlobalSystem (maybe)
    // When selecting an attack to add it should open up another array field bellow selected field or 
    // in new editor window, When element is selected copy element to the attack array
    // Check if player wants to add more than one of the same move to the list
}
