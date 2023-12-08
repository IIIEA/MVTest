using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CharacterView : MonoBehaviour
{
  [SerializeField] private Slider _hpSlider;
  [SerializeField] private TextMeshProUGUI _hpText;

  public void SetUpView(float hp )
  {
    _hpSlider.maxValue = hp;
    UpdateHpSlider(hp);
  }

  public void UpdateHpSlider(float newHpValue)
  {
    _hpText.text = $"Health: {newHpValue}";
    _hpSlider.value = newHpValue;
  }
}