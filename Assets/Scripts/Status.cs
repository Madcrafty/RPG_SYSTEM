using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Status", menuName = "RPG/Status")]
public class Status : ScriptableObject
{
    string Name;
    Entity Target;
    Type Type;
    float Duration;
    int Potency;

    void Condition()
    {

    }
}
