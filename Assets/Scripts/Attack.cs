using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Attack", menuName = "RPG/Attack")]
public class Attack : ScriptableObject
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
            Target.TakeDamage(Damage);
            // Status chance
        }
    }
}
