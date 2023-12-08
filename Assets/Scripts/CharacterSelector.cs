using System;
using System.Collections.Generic;
using UnityEngine;

public sealed class CharacterSelector : MonoBehaviour
{

  private Queue<CharacterModel> _playerData;
  private CharacterModel _selectedPlayer;
  public event Action<int> OnTakeDamage;
  public event Action<CharacterModel> selectedChanged;

  public CharacterModel SelectedPlayer => _selectedPlayer;

  public void Initialize(List<CharacterModel> characterModels)
  {
    _playerData = new Queue<CharacterModel>(characterModels);
    ChangeSelected();
  }

  // SRP
  // public void TakeDamage(int damage)
  // {
  //   if (_selectedPlayer.CurrentHealth <= 0)
  //   {
  //     _playerData.Dequeue();
  //     ChangeSelected();
  //     return;
  //   }
  //
  //   _selectedPlayer.DealDamage(damage);
  //   OnTakeDamage?.Invoke(damage);
  // }

  private void OnCharacterDie()
  {
    _selectedPlayer.OnDeath -= OnCharacterDie;
    ChangeSelected();
  }
  
  private void ChangeSelected()
  {
    _selectedPlayer = _playerData.Dequeue();
    _selectedPlayer.OnDeath += OnCharacterDie;
    selectedChanged?.Invoke(_selectedPlayer);
  }
}