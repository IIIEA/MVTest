using System;
using System.Collections.Generic;

public sealed class CharacterPresenter
{
  private readonly Queue<CharacterModel> playerData = new();
  private CharacterModel selectedPlayer;
  public event Action<int> OnTakeDamage;
  public event Action<CharacterModel> OnSelectedChanged;

  public void AddData(CharacterModel playerData)
  {
    this.playerData.Enqueue(playerData);
    if (selectedPlayer == null)
    {
      selectedPlayer = this.playerData.Dequeue();
    }
  }

  public void TakeDamage(int damage)
  {
    if (selectedPlayer.CurrentHealth <= 0)
    {
      playerData.Dequeue();
      ChangeSelected();
      return;
    }

    selectedPlayer.DealDamage(damage);
    OnTakeDamage?.Invoke(damage);
  }

  private void ChangeSelected()
  {
    selectedPlayer = playerData.Peek();
    OnSelectedChanged?.Invoke(selectedPlayer);
  }
}