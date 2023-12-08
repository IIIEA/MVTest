using System;
using System.Collections.Generic;

public sealed class CharacterPresenter
{
  private readonly Queue<CharacterModel> _playerData = new();
  private CharacterModel _selectedPlayer;
  public event Action<int> OnTakeDamage;
  public event Action<CharacterModel> OnSelectedChanged;

  public void AddData(CharacterModel playerData)
  {
    this._playerData.Enqueue(playerData);
    if (_selectedPlayer == null)
    {
      _selectedPlayer = this._playerData.Dequeue();
    }
  }

  public void TakeDamage(int damage)
  {
    if (_selectedPlayer.CurrentHealth <= 0)
    {
      _playerData.Dequeue();
      ChangeSelected();
      return;
    }

    _selectedPlayer.DealDamage(damage);
    OnTakeDamage?.Invoke(damage);
  }

  private void ChangeSelected()
  {
    _selectedPlayer = _playerData.Peek();
    OnSelectedChanged?.Invoke(_selectedPlayer);
  }
}