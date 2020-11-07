﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CheckButtonTask2Level4Behaviour : MonoBehaviour
{
    private int taskNumber = 2;
    private List<List<string>> expectedAnswers;
    private Text resultText;
    private Color wrongAnswerColor = new Color(1f, 0f, 0f, 1f);
    private Color correctAnswerColor = new Color(0f, 1f, 0f, 1f);
    private bool isKeyEarned = false;

    public void CheckAnswers()
    {
        expectedAnswers = GetExpectedAnswers();
        resultText = GameObject.Find("ResultText_Task" + taskNumber).GetComponent<Text>();
        var isCorrect = true;
        for (var i = 0; i < expectedAnswers.Count; i++)
        {
            var newAnswer = GameObject.Find("AnswerTask2_" + (i + 1)).GetComponent<InputField>();
            for (var j = 0; j < expectedAnswers[i].Count; j++)
            {
                if (!expectedAnswers[i].Contains(newAnswer.text))
                {
                    isCorrect = false;
                    newAnswer.textComponent.color = wrongAnswerColor;
                }
                else newAnswer.textComponent.color = correctAnswerColor;
            }
        }
        if (isCorrect)
        {
            resultText.text = "Задание выполнено!";
            if (!isKeyEarned)
            {
                GameObject.Find("KeyCounter").GetComponent<KeyCounterBehaviour>().keyCount++;
                isKeyEarned = true;
            }
        }
        else resultText.text = "Где-то есть ошибки. Исправь их и попробуй ещё раз!";
    }

    private List<List<string>> GetExpectedAnswers()
    {
        expectedAnswers = new List<List<string>>();
        expectedAnswers.Add(new List<string>() { "hile" });
        expectedAnswers.Add(new List<string>() { ">0", "> 0", ">=1", ">= 1" });
        expectedAnswers.Add(new List<string>() { "%" });
        expectedAnswers.Add(new List<string>() { "mult" });
        expectedAnswers.Add(new List<string>() { "%" });
        expectedAnswers.Add(new List<string>() { "//" });
        return expectedAnswers;
    }
}
