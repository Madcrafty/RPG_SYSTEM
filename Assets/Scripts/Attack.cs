using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
    int Damage;
    Entity[] Targets;
    Type Type;
    Status[] Status;
    [Range(0,1)]
    float StatusChances;
    
    float[] StatusWeights;
    int StatusLimit;
    float Accuracy;

    void Perform()
    {
        foreach (Entity Target in Targets)
        {
            // Check if it hits
            // Temp damage calcuation
            Target.GetStat("HP").Value -= Damage;
            // Status chance
        }
    }
}
