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
    float HitStatusChance;
    
    float[] StatusWeights;
    int StatusLimit;
    float Accuracy;

    void Perform()
    {
        foreach (Entity Target in Targets)
        {
            // Check if it hits
            float HitChance = Accuracy - Target.GetStatValue("Evasion");
            float rng = Random.Range(0, 101) / 100f;
            if (rng < HitChance)
            {
                // Temp damage calcuation
                Target.TakeDamage(Damage);
                // Status chance
                float rngStatus = Random.Range(0, 101) / 100f;
                if (rngStatus < HitStatusChance)
                {
                    Target.ApplyStatus();
                }
            }
        }
    }
}
