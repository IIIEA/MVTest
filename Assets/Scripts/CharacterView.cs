using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CharacterView : MonoBehaviour
{
  [SerializeField] private Slider _hpSlider;
  [SerializeField] private Button _nameButton;
  [SerializeField] private TextMeshProUGUI _hpText;
  [SerializeField] private TextMeshProUGUI _buttonText;

  public void SetUpView(string name, float hp)
  {
    _hpSlider.maxValue = hp;
    _buttonText.text = name;
    UpdateHpSlider(hp);
  }

  public void UpdateHpSlider(float newHpValue)
  {
    _hpText.text = $"Health: {newHpValue}";
    _hpSlider.value = newHpValue;
  }
}