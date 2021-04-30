using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class Stat : MonoBehaviour
{
	public string Name = "";
	public int Value = 0;
	int[] Modifiers;
	public int EffectiveValue { get
		{
			int temp = Value;
			if (Modifiers != null)
			{
				foreach (int item in Modifiers)
				{
					temp += item;
				}
			}
			return temp;
		}
	}
}
