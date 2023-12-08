using System;

namespace DefaultNamespace
{
    public class CharacterViewController : IDisposable
    {
        private readonly CharacterView _characterView;
        private readonly CharacterPresenter _characterPresenter;

        public CharacterViewController(CharacterView characterView, CharacterPresenter characterPresenter)
        {
            _characterView = characterView;
            _characterPresenter = characterPresenter;
            _characterPresenter.OnSelectedChanged += CharacterPresenterOnOnSelectedChanged;
            _characterPresenter.OnTakeDamage += CharacterPresenterOnOnTakeDamage;
        }

        private void CharacterPresenterOnOnTakeDamage(int damage)
        {
            _characterView.UpdateHpSlider(damage);
        }

        private void CharacterPresenterOnOnSelectedChanged(CharacterModel character)
        {
            CharacterData characterData = character.CharacterInfo;
            _characterView.SetUpView(characterData.Name, characterData.MaxHealth);
        }

        public void Dispose()
        {
            _characterPresenter.OnSelectedChanged -= CharacterPresenterOnOnSelectedChanged;
            _characterPresenter.OnTakeDamage -= CharacterPresenterOnOnTakeDamage;
        }
    }
}