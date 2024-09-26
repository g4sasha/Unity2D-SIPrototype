using UnityEngine;
using UnityEngine.UI;

public class HealthView : MonoBehaviour
{
    [SerializeField] private Text _healthField;
    [SerializeField] private string _healthFormat = "Health: {0}";

    private void Start()
    {
        Player.Instance.OnHealthChanged += Display;
        Display(Player.Instance.Health);
    }

    private void OnDestroy()
    {
        Player.Instance.OnHealthChanged -= Display;
    }

    public void Display(int health)
    {
        _healthField.text = string.Format(_healthFormat, health);
    }
}