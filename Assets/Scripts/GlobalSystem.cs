using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu(fileName = "GlobalSystem", menuName = "RPG/GlobalSystem", order = 5)]
public class GlobalSystem : ScriptableObject
{
    [SerializeField]
    public Stat[] StatList = new Stat[0];
    [SerializeField]
    public Stat[] StatList2 = new Stat[0];
    [SerializeField]
    public Attack[] AttackList = new Attack[0];
    [SerializeField]
    public Status[] StatusList = new Status[0];
    [SerializeField]
    public Type[] TypeList = new Type[0];
    public UnityEvent m_UpdateInheritanceEvent = new UnityEvent();

    private void OnValidate()
    {
        m_UpdateInheritanceEvent.Invoke();
    }
    public void Update()
    {

    }
}
