using Code;
using UnityEngine;

public class DamageDealerInstaller : MonoBehaviour
{
    [SerializeField] private UIButton _uiButton;
    [SerializeField] private CharacterSelector _characterSelector;
    [SerializeField] private DamageDealer _damageDealer;
    private void Awake()
    {
        DamageDealerController damageDealerController = new DamageDealerController(_characterSelector, _damageDealer);
        DamageDealerViewController damageDealerViewController =
            new DamageDealerViewController(_damageDealer, _characterSelector, _uiButton);
    }
}
