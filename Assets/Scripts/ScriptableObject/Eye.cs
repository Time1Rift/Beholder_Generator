using UnityEngine;

[CreateAssetMenu(menuName = "Eye/Create new Eye", order = 51)]
public class Eye : ScriptableObject
{
    [field: SerializeField, Multiline(30)] public string Text { get; private set; }
    [field: SerializeField] public string Name { get; private set; }
}