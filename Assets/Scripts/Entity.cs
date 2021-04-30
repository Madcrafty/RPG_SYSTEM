using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Entity : MonoBehaviour
{
    Stat[] PrimaryStats;
    Stat[] SecondaryStats;
    Type[] Types;
    Attack[] Attacks;
    StatList statblock;
    //void GetGlobalStatList()
    //{
    //    if (PrimaryStats.Length != statblock.PrimaryStats.Length)
    //    {
    //        Stat[] newList = new Stat[statblock.PrimaryStats.Length];
    //        int i = 0;
    //        while (i < newList.Length && i < PrimaryStats.Length)
    //        {
    //            newList[i] = PrimaryStats[i];
    //            i++;
    //        }
    //        PrimaryStats = newList;
    //    }
    //    if (SecondaryStats.Length != statblock.SecondaryStats.Length)
    //    {
    //        Stat[] newList = new Stat[statblock.SecondaryStats.Length];
    //        int i = 0;
    //        while (i < newList.Length && i < SecondaryStats.Length)
    //        {
    //            newList[i] = SecondaryStats[i];
    //            i++;
    //        }
    //        SecondaryStats = newList;
    //    }
    //}
    public Stat GetStat(string name)
    {
        foreach (Stat item in PrimaryStats)
        {
            if (name == item.Name)
            {
                return item;
            }
        }
        foreach (Stat item in SecondaryStats)
        {
            if (name == item.Name)
            {
                return item;
            }
        }
        return null;
    }
}
