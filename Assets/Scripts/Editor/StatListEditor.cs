using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(StatList))]
public class StatListEditor : Editor
{
    int PrimaryStatsLength;
    Stat[] PrimaryStats;
    int SecondaryStatsLength;
    Stat[] SecondaryStats;
    public override void OnInspectorGUI()
    {
        // Initialise Menus
        StatList myTarget = (StatList)target;
        PrimaryStatsLength = myTarget.PrimaryStatsLength;
        PrimaryStats = myTarget.PrimaryStats;
        SecondaryStatsLength = myTarget.PrimaryStatsLength;
        SecondaryStats = myTarget.SecondaryStats;
        //Primary Stats
        myTarget.PrimaryStatsLength = Mathf.Clamp(EditorGUILayout.IntField("Primary Stats Length", PrimaryStatsLength), 0, 100);
        if (myTarget.PrimaryStats.Length != PrimaryStatsLength)
        {
            Stat[] newList = new Stat[PrimaryStatsLength];
            int i = 0;
            while (i < newList.Length && i < myTarget.PrimaryStats.Length)
            {
                newList[i] = myTarget.PrimaryStats[i];
                i++;
            }
            while (i < newList.Length)
            {
                newList[i] = new Stat();
                i++;
            }
            myTarget.PrimaryStats = newList;
        }
        foreach (Stat stat in myTarget.PrimaryStats)
        {
            stat.Name = EditorGUILayout.TextField("Name", stat.Name);
            stat.Value = Mathf.Clamp(EditorGUILayout.IntField("Value", PrimaryStatsLength), 0, 999);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
