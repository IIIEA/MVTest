using System;
using TMPro;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

namespace Code
{
    public class UIButton : MonoBehaviour
    {
        [SerializeField] private Button button;
        [SerializeField]
        private TMP_Text buttonText;
        public Action action;

        private void Awake()
        {
            enabled = false;
        }

        public void Initialize(Action onButtonClicked)
        {
            action = onButtonClicked;
            enabled = true;
        }

        public void UpdateView(string text)
        {
            buttonText.text = text;
        }

        private void OnButtonClicked()
        {
            button.onClick.AddListener(() => action?.Invoke());
        }

        private void OnEnable()
        {
            if(action is null)
                return;
            
            button.onClick.AddListener(OnButtonClicked);
        }

        private void OnDisable()
        {
            if(action is null)
                return;
            
            button.onClick.RemoveListener(OnButtonClicked);
        }
    }
}