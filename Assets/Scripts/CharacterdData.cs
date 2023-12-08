using UnityEngine;

[CreateAssetMenu(menuName = "Player/Data", fileName = "PlayerData")]
public class CharacterData : ScriptableObject
{
    [field: SerializeField] public string Name { get; private set; }
    [field: SerializeField] public int MaxHealth { get; private set; }
}