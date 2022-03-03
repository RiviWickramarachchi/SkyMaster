using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    private static ScoreManager instance;

    [SerializeField] private Text scoreText;
    [SerializeField] private Text highScoreText;
    // Start is called before the first frame update

   

    int score = 0;

    public static ScoreManager GetInstance { get => instance;}

    private void Awake()
    {
        instance = this;
    }

    void Start()
    {
        scoreText.text = score.ToString();
    }

    public void addPoint()
    {
        score = score + 1;
        scoreText.text = score.ToString();
    }
    
}
