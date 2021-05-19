using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Entity : MonoBehaviour
{
    public GlobalSystem globalSystem;
    //public Stat[] PrimaryStats;
    //public Stat[] SecondaryStats;

    public float[] PrimaryValues;
    public float[] SecondaryValues;
    //Type[] Types;
    //Attack[] Attacks;
    //StatList statblock;
    
    private GlobalSystem oldSystem;
    private void OnEnable()
    {
        if (globalSystem != null)
        {
            globalSystem.m_UpdateInheritanceEvent.AddListener(GetGlobalStatList);
        }
    }
    private void OnDisable()
    {
        if (globalSystem != null)
        {
            globalSystem.m_UpdateInheritanceEvent.RemoveListener(GetGlobalStatList);
        }   
    }
    void GetGlobalStatList()
    {
        PrimaryValues = new float[globalSystem.StatList.Length];
        SecondaryValues = new float[globalSystem.StatList2.Length];
        //int i = 0;
        //while (i < newList.Length && i < PrimaryValues.Length)
        //{
        //    newList[i] = PrimaryStats[i];
        //    i++;
        //}
        //PrimaryStats = newList;
        //Stat[] newList = globalSystem.StatList;
        //int i = 0;
        //while (i < newList.Length && i < PrimaryStats.Length)
        //{
        //    newList[i] = PrimaryStats[i];
        //    i++;
        //}
        //PrimaryStats = newList;
        //newList = globalSystem.StatList2;
        //i = 0;
        //while (i < newList.Length && i < SecondaryStats.Length)
        //{
        //    newList[i] = SecondaryStats[i];
        //    i++;
        //}
        //SecondaryStats = newList;
        //if (PrimaryStats.Length != statblock.PrimaryStats.Length)
        //{
        //    Stat[] newList = new Stat[statblock.PrimaryStats.Length];
        //    int i = 0;
        //    while (i < newList.Length && i < PrimaryStats.Length)
        //    {
        //        newList[i] = PrimaryStats[i];
        //        i++;
        //    }
        //    PrimaryStats = newList;
        //}
        //if (SecondaryStats.Length != statblock.SecondaryStats.Length)
        //{
        //    Stat[] newList = new Stat[statblock.SecondaryStats.Length];
        //    int i = 0;
        //    while (i < newList.Length && i < SecondaryStats.Length)
        //    {
        //        newList[i] = SecondaryStats[i];
        //        i++;
        //    }
        //    SecondaryStats = newList;
        //}
    }

    private void OnValidate()
    {
        if (globalSystem != oldSystem)
        {
            if (globalSystem != null)
            {  
                globalSystem.m_UpdateInheritanceEvent.AddListener(GetGlobalStatList);
                GetGlobalStatList();
            }
            else
            {
                //PrimaryStats = null;
            }
            if (oldSystem != null)
            {
                oldSystem.m_UpdateInheritanceEvent.RemoveListener(GetGlobalStatList);
            }
            oldSystem = globalSystem;
        }
    }
    //public int GetStatValue(string name)
    //{
    //    int i = 0;
    //    foreach (Stat item in PrimaryStats)
    //    {
    //        if (name == item.name)
    //        {
    //            return item.CalcEffectiveValue(PrimaryValues[i]);
    //        }
    //        i++;
    //    }
    //    i = 0;
    //    foreach (Stat item in SecondaryStats)
    //    {
    //        if (name == item.name)
    //        {
    //            return item.CalcEffectiveValue(SecondaryValues[i]);
    //        }
    //        i++;
    //    }
    //    return 0;
    //}
    public void SetStatValue(int mod)
    {

    }
    public void TakeDamage(int damage)
    {

    }
}
