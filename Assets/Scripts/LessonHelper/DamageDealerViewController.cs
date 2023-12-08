namespace Code
{
    public class DamageDealerViewController
    {
        private DamageDealer _damageDealer;
        private UIButton _uiButton;
        
        public DamageDealerViewController(DamageDealer damageDealer, CharacterSelector characterSelector, UIButton button)
        {
            _damageDealer = damageDealer;
            _uiButton = button;
            _uiButton.Initialize(_damageDealer.DealDamage);
            characterSelector.selectedChanged += OnCharacterSelected;
            OnCharacterSelected(characterSelector.SelectedPlayer);
        }

        private void OnCharacterSelected(CharacterModel obj)
        {
            var characterName = obj.CharacterInfo.Name;
            _uiButton.UpdateView(characterName);
        }
    }
}