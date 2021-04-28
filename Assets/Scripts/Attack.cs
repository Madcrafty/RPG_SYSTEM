using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
    int Damage;
    Entity Target;
    Type Type;
    Status[] Status;
    [Range(0,1)]
    float StatusChances;
    
    float[] StatusWeights;
    int StatusLimit;
    float Accuracy;
}
