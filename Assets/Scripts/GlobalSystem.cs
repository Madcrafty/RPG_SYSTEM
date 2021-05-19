using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu(fileName = "GlobalSystem", menuName = "RPG/GlobalSystem", order = 5)]
public class GlobalSystem : ScriptableObject
{
    [SerializeField]
    public Stat[] StatList;
    [SerializeField]
    public Stat[] StatList2;
    [SerializeField]
    Attack[] AttackList;
    [SerializeField]
    Status[] StatusList;
    [SerializeField]
    Type[] TypeList;
    public UnityEvent m_UpdateInheritanceEvent = new UnityEvent();

    private void OnValidate()
    {
        m_UpdateInheritanceEvent.Invoke();
    }
    public void Update()
    {

    }
}
