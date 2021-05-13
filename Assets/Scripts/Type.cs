using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Type", menuName = "Type")]
public class Type : ScriptableObject
{
    public string Name;
    public Type[] EffectiveAgainst;
    public float[] EffectiveMod;
    public Type[] RisistantTo;
    public float[] RisistMod;
    
    private List<Type> m_AltList = new List<Type>();
    private int m_listSize = 3;
    private int m_iterator = 0;

    //private string m_name;
    //private Type[] m_effectiveAgainst;
    //private float[] m_effectiveMod;
    //private Type[] m_risistantTo;
    //private float[] m_risistMod;
    public void ApplyChanges()
    {
        Type tmp = new Type();
        tmp.Name = Name;
        tmp.EffectiveAgainst = EffectiveAgainst;
        tmp.EffectiveMod = EffectiveMod;
        tmp.RisistantTo = RisistantTo;
        tmp.RisistMod = RisistMod;
        m_AltList.Add(tmp);
        m_iterator = 0;
        if (m_AltList.Count > m_listSize)
        {
            m_AltList.RemoveAt(m_listSize);
        }
    }
    public void RevertChanges()
    {
        if (m_iterator < m_listSize - 1)
        {
            m_iterator++;
        }
        Name = m_AltList[m_iterator].Name;
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
    private void OnValidate()
    {
        //Type type = (Type)target;
        SetIterator(-1);
    }
}
