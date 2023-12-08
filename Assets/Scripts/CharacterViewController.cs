using System;

namespace DefaultNamespace
{
    public class CharacterViewController : IDisposable
    {
        private readonly CharacterView _characterView;
        private readonly CharacterSelector _characterSelector;

        public CharacterViewController(CharacterView characterView, CharacterSelector characterSelector)
        {
            _characterView = characterView;
            _characterSelector = characterSelector;
            _characterSelector.selectedChanged += CharacterSelectorSelectedChanged;
            _characterSelector.OnTakeDamage += CharacterSelectorOnTakeDamage;
        }

        private void CharacterSelectorOnTakeDamage(int damage)
        {
            _characterView.UpdateHpSlider(damage);
        }

        private void CharacterSelectorSelectedChanged(CharacterModel character)
        {
            CharacterData characterData = character.CharacterInfo;
            _characterView.SetUpView( characterData.MaxHealth);
        }

        public void Dispose()
        {
            _characterSelector.selectedChanged -= CharacterSelectorSelectedChanged;
            _characterSelector.OnTakeDamage -= CharacterSelectorOnTakeDamage;
        }
    }
}