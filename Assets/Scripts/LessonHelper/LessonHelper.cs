using UnityEngine;
using Zenject;

namespace Code
{
    public sealed class LessonHelper : MonoBehaviour
    {
        private CharacterData[] _characterDatas;
        
        //TODO Inject CharacterPresentert
        //TODO make editor button Character.DealDamage

        // [Inject]
        // private void Construct(MoneyStorage moneyStorage, GemStorage gemStorage)
        // {
        //     _gemStorage = gemStorage;
        //     _moneyStorage = moneyStorage;
        // }
        //
        // public void AddMoney()
        // {
        //     _moneyStorage.AddMoney(_current);
        // }
        //
        // public void SpendMoney()
        // {
        //     _moneyStorage.SpendMoney(_current);
        // }
        //
        // public void AddGem()
        // {
        //     _gemStorage.AddGem(_current);
        // }
        //
        // public void SpendGem()
        // {
        //     _gemStorage.SpendGem(_current);
        // }
    }
}
