using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    
    Quiz quiz;
    EndScreen EndScreen;

    void Start()
    {
        quiz = findObjectOfType<Quiz>();
        EndScreen = findObjectOfType<EndScreen>();

        quiz.GameObject.SetActive(true);
        EndScreen.gameObject.SetActive(false);
        
    }

    
    void Update()
    {
        if(quiz.isComplete
        {
            quiz.gameObject.SetActive(false);
            endScreen.gameObject.SetActive(true);
        })
    }
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
