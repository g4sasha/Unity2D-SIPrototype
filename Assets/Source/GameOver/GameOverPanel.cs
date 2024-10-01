using Source.Unit;
using UnityEngine;

public class GameOverPanel : MonoBehaviour
{
    [SerializeField] private Unit _player;

    private void Start()
    {
        Hide();
        _player.OnDied += Show;
    }

    private void OnDestroy()
    {
        _player.OnDied -= Show;
    }

    public void Show()
    {
        Debug.Log("Game Over");
        gameObject.SetActive(true);
        Time.timeScale = 0;
    }

    public void Hide()
    {
        gameObject.SetActive(false);
        Time.timeScale = 1;
    }
}