using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stat : MonoBehaviour
{
	string Name;
	int Value;
	//int EffectiveValue { get
	//	{
	//		int temp = Value;
	//		foreach (Stat item in Modifiers)
	//		{
	//			temp += item.EffectiveValue;
	//		}
	//		return temp;
	//	} 
	//}
	Stat[] Modifiers;
	int CalaculateEffectiveValue()
	{
		int temp = Value;
		foreach (Stat item in Modifiers)
		{
			temp += item.CalaculateEffectiveValue();
		}
		return temp;
	}
	//struct PrimaryStat
	//{
	//	string Name;
	//	int Value;
	//}
	//struct SecondaryStat
	//{

	//}
}
