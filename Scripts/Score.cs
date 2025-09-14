using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    [SerializeField] Text scoreText;
    int score;

    public void AddScore(int point)
    {
        score += point;
        GetComponent<AudioSource>().Play();
        scoreText.text = score.ToString();
    }
}
