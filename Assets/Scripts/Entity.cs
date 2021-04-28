using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Entity : MonoBehaviour
{
    Stat[] PrimaryStats;
    Stat[] SecondaryStats;
    Type[] Types;
    Attack[] Attacks;
    public Stat GetStat(string name)
    {
        foreach (Stat item in PrimaryStats)
        {
            if (name == item.name)
            {
                return item;
            }
        }
        foreach (Stat item in SecondaryStats)
        {
            if (name == item.name)
            {
                return item;
            }
        }
        return null;
    }
}
