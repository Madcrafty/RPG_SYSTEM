using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//[System.Serializable]
[CreateAssetMenu(fileName = "Stat", menuName = "RPG/Stat")]
public class Stat : ScriptableObject
{
	//[SerializeField]
	public int Value;
	//[SerializeField]
	//public int[] Modifiers;
	public Stat[] Modifiers;
	public int EffectiveValue { get
		{
			int temp = Value;
			if (Modifiers != null)
			{
				foreach (Stat item in Modifiers)
				{
					temp += item.EffectiveValue;
				}
			}
			return temp;
		}
	}
	public int CalcEffectiveValue (float value)
    {
		int temp = Value;
		if (Modifiers != null)
		{
			foreach (Stat item in Modifiers)
			{
				temp += item.EffectiveValue;
			}
		}
		return temp;
	}
}
