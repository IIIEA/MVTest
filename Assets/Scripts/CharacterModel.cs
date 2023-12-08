using System;

public class CharacterModel
{
  public event Action OnDeath;
  
  public int MaxCurrentHealth { get; private set; }
  public int CurrentHealth { get; private set; }

  public CharacterModel(int currentHealth)
  {
    MaxCurrentHealth = currentHealth;
    CurrentHealth = currentHealth;
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