using System;

public class CharacterModel
{
  public event Action OnDeath;
  
  public int CurrentHealth { get; private set; }

  public CharacterData CharacterInfo { get; private set; }

  public CharacterModel(int currentHealth, CharacterData characterData)
  {
    CurrentHealth = currentHealth;
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