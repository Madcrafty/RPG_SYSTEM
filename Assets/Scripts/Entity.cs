using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Entity : MonoBehaviour
{
    public GlobalSystem globalSystem;
    //public Stat[] PrimaryStats;
    //public Stat[] SecondaryStats;

    public float[] PrimaryValues = new float[0];
    public float[] SecondaryValues = new float[0];
    public int[] Attacks = new int[0];
    public int[] Types = new int[0];
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
        float[] tmp = new float[globalSystem.StatList.Length];
        float[] tmp2 = new float[globalSystem.StatList2.Length];
        int[] tmp3 = new int[globalSystem.AttackList.Length];
        int[] tmp4 = new int[globalSystem.TypeList.Length];

        for (int i = 0; i < tmp.Length && i < PrimaryValues.Length; i++)
        {
            tmp[i] = PrimaryValues[i];
        }
        PrimaryValues = tmp;
        for (int i = 0; i < tmp2.Length && i < SecondaryValues.Length; i++)
        {
            tmp2[i] = SecondaryValues[i];
        }
        SecondaryValues = tmp2;
        for (int i = 0; i < tmp3.Length && i < Attacks.Length; i++)
        {
            tmp3[i] = Attacks[i];
        }
        Attacks = tmp3;
        for (int i = 0; i < tmp4.Length && i < Types.Length; i++)
        {
            tmp4[i] = Types[i];
        }
        Types = tmp4;
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
