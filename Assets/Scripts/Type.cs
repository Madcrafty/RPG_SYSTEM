using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Type", menuName = "RPG/Type")]
public class Type : ScriptableObject
{
    //public string Name;
    public Type[] EffectiveAgainst;
    public float[] EffectiveMod;
    public Type[] RisistantTo;
    public float[] RisistMod;
    
    private List<Type> m_AltList = new List<Type>();
    private int m_listSize = 3;
    private int m_iterator = 0;
    public void ApplyChanges()
    {
        if (m_iterator != 0)
        {
            //name = Name;
            Type tmp = new Type();
            //tmp.Name = Name;
            //tmp.name = Name;
            tmp.EffectiveAgainst = EffectiveAgainst;
            tmp.EffectiveMod = EffectiveMod;
            tmp.RisistantTo = RisistantTo;
            tmp.RisistMod = RisistMod;
            m_AltList.Insert(0, tmp);
            m_iterator = 0;
            if (m_AltList.Count > m_listSize)
            {
                m_AltList.RemoveAt(m_listSize);
            }
        }
    }
    public void RevertChanges()
    {
        if (m_iterator < m_listSize - 1)
        {
            m_iterator++;
        }
        //Name = m_AltList[m_iterator].Name;
        //name = m_AltList[m_iterator].Name;
        EffectiveAgainst = m_AltList[m_iterator].EffectiveAgainst;
        EffectiveMod = m_AltList[m_iterator].EffectiveMod;
        RisistantTo = m_AltList[m_iterator].RisistantTo;
        RisistMod = m_AltList[m_iterator].RisistMod;
    }  
    public void RedoChanges()
    {
        if (m_iterator >= 0)
        {
            m_iterator--;
        }
        //Name = m_AltList[m_iterator].Name;
        //name = m_AltList[m_iterator].Name; 
        EffectiveAgainst = m_AltList[m_iterator].EffectiveAgainst;
        EffectiveMod = m_AltList[m_iterator].EffectiveMod;
        RisistantTo = m_AltList[m_iterator].RisistantTo;
        RisistMod = m_AltList[m_iterator].RisistMod;
    }
    public void SetIterator(int a_iter)
    {
        m_iterator = a_iter;
    }
    public int GetIterator()
    {
        return m_iterator;
    }
    public void SetUndoListLength(int a_listLength)
    {
        m_listSize = a_listLength;
    }
    public int GetUndoListLength()
    {
        return m_listSize;
    }
    private void OnValidate()
    {
        //Type type = (Type)target;
        if (m_iterator > 0)
        {
            Type tmp = m_AltList[m_iterator];
            m_AltList.Remove(tmp);
            m_AltList.Insert(0, tmp);          
        }
        m_iterator = -1;
    }
}
