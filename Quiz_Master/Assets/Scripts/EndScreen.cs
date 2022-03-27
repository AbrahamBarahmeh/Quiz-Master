using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TextPro;

public class EndScreen : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI finalScoreText;
    ScoreKeeper scoreKeeper;
    
    void Start()
    {
        ScoreKeeper = findObjectOfType<ScoreKeeper>();
    }

    public void ShowFinalScore()
    {
        finalScoreText.TEXT ="Congratulations!\n Your score is" + scoreKeeper.CalculateScore() + "%";    }


}
