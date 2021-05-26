using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Entity : MonoBehaviour
{
    public GlobalSystem globalSystem;

    // Universal Values:
    public int health;
    public int experience;
    // Global Values:
    public float[] PrimaryValues = new float[0];
    public float[] SecondaryValues = new float[0];
    public int[] Attacks = new int[0];
    public int[] Types = new int[0];
    // Current Active Effects
    public Status[] ActiveStatuses = new Status[0];
    
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
    public int GetStatValue(int index)
    {
        if (index < globalSystem.StatList.Length && index >= 0)
        {
            return globalSystem.StatList[index].CalcEffectiveValue(PrimaryValues[index]);
        }
        else if (index > globalSystem.StatList.Length && index < globalSystem.StatList.Length + globalSystem.StatList2.Length)
        {
            index -= globalSystem.StatList.Length;
            return globalSystem.StatList2[index].CalcEffectiveValue(SecondaryValues[index]);
        }
        Debug.LogError("Index: " + index + " is out of range");
        return 0;
    }
    public int GetStatValue(string Name)
    {
        int i = 0;
        foreach (Stat item in globalSystem.StatList)
        {
            if (Name == item.name)
            {
                return item.CalcEffectiveValue(PrimaryValues[i]);
            }
            i++;
        }
        i = 0;
        foreach (Stat item in globalSystem.StatList)
        {
            if (Name == item.name)
            {
                return item.CalcEffectiveValue(SecondaryValues[i]);
            }
            i++;
        }
        Debug.LogError("Stat: " + Name + " could not be found");
        return 0;
    }
    public void SetStatValue(int index, int mod)
    {
        if (index < globalSystem.StatList.Length && index >= 0)
        {
            PrimaryValues[index] = mod;
            return;
        }
        else if (index > globalSystem.StatList.Length && index < globalSystem.StatList.Length + globalSystem.StatList2.Length)
        {
            index -= globalSystem.StatList.Length;
            SecondaryValues[index] = mod;
            return;
        }
        Debug.LogError("Index: " + index + " is out of range");
    }
    public void SetStatValue(string Name, int mod)
    {
        int i = 0;
        foreach (Stat item in globalSystem.StatList)
        {
            if (Name == item.name)
            {
                PrimaryValues[i] = mod;
                return;
            }
            i++;
        }
        i = 0;
        foreach (Stat item in globalSystem.StatList)
        {
            if (Name == item.name)
            {
                SecondaryValues[i] = mod;
                return;
            }
            i++;
        }
        Debug.LogError("Stat: " + Name + " could not be found");
    }
    public void TakeDamage(int damage)
    {
        health -= damage;
    }
    public virtual void Die()
    {

    }
    public void AddStatus()
    {

    }
    public void RemoveStatus()
    {

    }
}
