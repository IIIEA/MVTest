using UnityEngine;

[CreateAssetMenu(menuName = "Player/Data", fileName = "PlayerData")]
public class CharacterData : ScriptableObject
{
    [SerializeField]
    private string _name;
    [SerializeField] private int maxHealth;
    public string Name => _name;
    public int MaxHealth => maxHealth;
}