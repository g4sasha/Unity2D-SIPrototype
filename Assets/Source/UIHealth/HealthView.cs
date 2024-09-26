using UnityEngine;
using UnityEngine.UI;

namespace Source.UIHealth
{
    public class HealthView : MonoBehaviour
    {
        [SerializeField] private Text _healthField;
        [SerializeField] private string _healthFormat = "Health: {0}";

        private void Start()
        {
            Player.Player.Instance.OnHealthChanged += Display;
            Display(Player.Player.Instance.Health);
        }

        private void OnDestroy()
        {
            Player.Player.Instance.OnHealthChanged -= Display;
        }

        public void Display(int health)
        {
            _healthField.text = string.Format(_healthFormat, health);
        }
    }
}