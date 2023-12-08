using UnityEngine;

namespace Code
{
    
    public class DamageDealer : MonoBehaviour
    {
        [SerializeField] private int damageAmount;
        private CharacterModel _characterModel;
        
        public void OnCharacterChanged(CharacterModel characterModel)
        {
            _characterModel = characterModel;
        }
        
        public void DealDamage()
        {
            _characterModel.DealDamage(damageAmount);
        }
    }
}