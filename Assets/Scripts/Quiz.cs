using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
public class Quiz : MonoBehaviour
{
   [SerializeField] TextMeshProUGUI questionText;
   [SerializeField] QuesionSO quesion;
   [SerializeField] GameObject[] answerButtons;
   int correctAnswerIndex;
   [SerializeField] Sprite defaultAnswerSprite;
   [SerializeField] Sprite correctAnswerSprite;
    void Start()
    {
        questionText.text = quesion.GetQuestion();

        for(int i = 0; i < answerButtons.Length; i++)
        {
        TextMeshProUGUI buttonText = answerButtons[i]. GetComponentInChildren<TextMeshProUGUI>();
        buttonText.text = quesion.GetAnswer(i);
        }
    }

    public void OnAnswerSelected(int index)
    {

        if(index == question.GetCorrectAnswerIndex())
        {
            questionText.text = "Correct!";
            Image buttonImage = answerButtons[index].GetComponent<Image>();
            buttonImage.sprite = correctAnswerSprite;
        }
        else
        {
            correctAnswerIndex = question.GetCorrectAnswerIndex();
            string correctAnswer = question.GetAnswer(correctAnswerIndex);
            questionText.text = "Sorry, the correct answer was;\n" + correctAnswer;
        }
    }
}