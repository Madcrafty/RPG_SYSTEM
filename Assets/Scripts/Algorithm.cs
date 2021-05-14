using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Algorithm", menuName = "RPG/Algorithm")]
public class Algorithm : ScriptableObject
{
    public int variables;
    public string formula;
    int Formula(int[] Variables)
    {
        string tmp = string.Format(formula, Variables);
        
        return 1;
    }
    float Formula(float[] Variables)
    {
        string tmp = string.Format(formula, Variables);

        return 1;
    }
}
