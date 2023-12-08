using System;

[Serializable]
public class CharacterModel
{
  public event Action OnDeath;
  
  public int CurrentHealth { get; private set; }

  public CharacterData CharacterInfo { get; private set; }

  public CharacterModel(CharacterData characterData)
  {
    CurrentHealth = characterData.MaxHealth;
    CharacterInfo = characterData;
  }

  public void DealDamage(int damage)
  {
    CurrentHealth -= damage;
    if (CurrentHealth <= 0)
      Die();
  }

  private void Die()
  {
    OnDeath?.Invoke();
  }
}