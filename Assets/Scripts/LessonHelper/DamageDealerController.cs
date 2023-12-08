namespace Code
{
    public class DamageDealerController
    {
        private CharacterSelector _characterSelector;
        private DamageDealer _damageDealer;

        public DamageDealerController(CharacterSelector characterSelector, DamageDealer damageDealer)
        {
            _characterSelector = characterSelector;
            _damageDealer = damageDealer;
            _characterSelector.selectedChanged += _damageDealer.OnCharacterChanged;
        }

        ~DamageDealerController()
        {
            _characterSelector.selectedChanged -= _damageDealer.OnCharacterChanged;
        }
    }
}