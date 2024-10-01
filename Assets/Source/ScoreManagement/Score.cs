using UnityEngine.UI;
using UnityEngine;

namespace ScoreManagement
{
    public class Score : MonoBehaviour
    {
        public int ScoreValue
        {
            get => _score;
            private set
            {
                _score = value;
                _scoreField.text = "Score: " + _score.ToString();
            }
        }
        
        [SerializeField] private Text _scoreField;
        private int _score;

        public void AddScore(int value) => ScoreValue += value;
    }
}