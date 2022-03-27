using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Quiz : MonoBehaviour
{
    [Header("Questions")]
   [SerializeField] TextMeshProUGUI questionText;
   [SerializeField] List<QuestionSO> questions = new List<QuestionSO>();
    QuestionSO currentquestion;

   [Header("Answers")]
   [SerializeField] GameObject[] answerButtons;
   int correctAnswerIndex;

   [Header("Button Colors")]
   [SerializeField] Sprite defaultAnswerSprite;
   [SerializeField] Sprite correctAnswerSprite;

   [Header("Timer")]
   [SerializeField] Image timerImage;
   Timer timer;

   [Header("ProgressBar")
   [SerializeField] Slider ProgressBar;




    void Start()
    {
        timer = findObjectOfType<Timer>();
        scoreKeeper = findObjectOfType<scoreKeeper>();
       ProgressBar.maxValue = questions.Count;
       ProgressBar.value = 0;
    }

    void Update()
    {
        timerImage.fillAmount = timer.fillFraction;
        if(timer.loadNextQuestion)
        {
            GetNextQuestion();
            timer.loadNextQuestion = false;

            
        }
        else if(!hasAnsweredEarly && !timer.isAnsweringQuestion)
        {

        }
    }

        public void OnAnswerSelected(int index)

        void DisplayQuestion()


    {
        questionText.text = question.GetQuestion();

        for(int i = 0; i < answerButtons.Length; i++)
        {
            TextMeshProUGUI buttonText = answerButtons[i].GetComponentChildren<TextMeshProUGUI>();
            buttonText.text = question.GetAnswer(i);

        }
        void SetButtonState(bool state)
        {
             for(int i = 0; i < answerButtons.Length; i++)
             {
                 Button button = answerButtons[i].GetCompeonent<Button>();
                 button.interactable = state;
             }
        }
        

           
             
        

     
    

    }

    public void OnAnswerSelected(int index)
    {
        if (index == question.GetCorrectAnswerIndex())
        {
            questionText.text = "Correct!";
            Image buttonImage = answerButtons[index].GetComponent<Image>();
            buttonImage.sprite = correctAnswerSprite;
        }
        else
        {
            correctAnswerIndex = question.GetCorrectAnswerIndex();
            string correctAnswer = question.GetAnswer(correctAnswerIndex);
            questionText.text = "Sorry,  the correct answer was; \n" + correctAnswer;
            buttonImage = answerButtons[correcrAnswerIndex].GetComponent<Image>();
            buttonImage.sprite = correctAnswerSprite;
        }
    }

    SetButtonState(false);


    voidGetNextQuestion()
    {
        if (questions,Count > 0)
        SetButtonState(true);
        SetDefaultButtonSprites();
        GetRandomQuestion();
        DisplayQuestion();
    }
    void GetRandomQuestion()
    {

        int index = Random.Range(o, questions.Count);
        currentQuestion = questions[index];

        if(questions.Contains(currentQuestion))
        {
            questions.Remove(currentQuestion);
        }
    }


    void SetDefaultButtonSprites()
    {
        for(int i = 0; i < answerButtons.Length; i++)
        {
            Image buttonImage = answerButtons[i].GetComponent<image>();
            buttonImage.sprite = defaultAnswerSprite;
        }
    }






}
