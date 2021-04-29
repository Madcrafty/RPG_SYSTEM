using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

//[CustomEditor(typeof(Stat))]
//public class StatEditor : Editor
//{
//    public string Name;
//    public int Value;
//    public override void OnInspectorGUI()
//    {
//        // Initialise Menus
//        Stat myTarget = (Stat)target;
//        Name = myTarget.Name;
//        Value = myTarget.Value;
//        Name = EditorGUILayout.TextField("Name", Name);
//        Value = Mathf.Clamp(EditorGUILayout.IntField("Value", Value), 0, 100);
//    }

//    // Update is called once per frame
//    void Update()
//    {

//    }
//}
[CustomPropertyDrawer(typeof(Stat))]
public class StatDrawer : PropertyDrawer
{
    // Draw the property inside the given rect
    public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
    {
        // Using BeginProperty / EndProperty on the parent property means that
        // prefab override logic works on the entire property.
        EditorGUI.BeginProperty(position, label, property);

        // Draw label
        position = EditorGUI.PrefixLabel(position, GUIUtility.GetControlID(FocusType.Passive), label);

        // Don't make child fields be indented
        var indent = EditorGUI.indentLevel;
        EditorGUI.indentLevel = 0;

        // Calculate rects
        var nameRect = new Rect(position.x, position.y, 30, position.height);
        var unitRect = new Rect(position.x + 35, position.y, 50, position.height);

        // Draw fields - passs GUIContent.none to each so they are drawn without labels
        EditorGUI.PropertyField(nameRect, property.FindPropertyRelative("Name"), GUIContent.none);
        EditorGUI.PropertyField(unitRect, property.FindPropertyRelative("Value"), GUIContent.none);

        // Set indent back to what it was
        EditorGUI.indentLevel = indent;

        EditorGUI.EndProperty();
    }
}