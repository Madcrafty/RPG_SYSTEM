using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "GlobalSystem", menuName = "GlobalSystem", order = 5)]
public class GlobalSystem : ScriptableObject
{
    public int memes;
    Stat[] StatList;
    Attack[] AttackList;
    Status[] StatusList;
    Type[] TypeList;
}
