using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "GlobalSystem", menuName = "GlobalSystem", order = 5)]
public class GlobalSystem : ScriptableObject
{
    [SerializeField]
    public int[] memes;
    //[SerializeField]
    public Stat[] StatList;
    [SerializeField]
    Attack[] AttackList;
    [SerializeField]
    Status[] StatusList;
    [SerializeField]
    Type[] TypeList;
}
