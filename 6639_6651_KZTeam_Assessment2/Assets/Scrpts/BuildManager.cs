﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class BuildManager : MonoBehaviour
{
    public Text firstNumber;
    public Text secondNumber;
    private int trueAnswer;

    //-------showquestionui paremeter 0 = plus, 1 = minus, 2 = mult, 3 = euqual
    public void showQuestion()
    {
        int firstNumberTemp = 0;
        int secondNumberTemp = 0;

        List<Text> answers = new List<Text>();

        int TrueAnswerIndex;

        firstNumberTemp = (int)Random.Range(1, 99);
        secondNumberTemp = (int)Random.Range(1, 99);

        firstNumber.text = "" + firstNumberTemp;
        secondNumber.text = "" + secondNumberTemp;

        TrueAnswerIndex = (int)Random.Range(0, 3);

        answers.Add(Gm.instance.answer[0]);
        answers.Add(Gm.instance.answer[1]);
        answers.Add(Gm.instance.answer[2]);
        int preTemp = 0;
        foreach (Text answer in answers)
        {
            if (answer != answers[TrueAnswerIndex])
            {
                int temp;
                do
                {
                    temp = Random.Range(-2, 3);
                } while (temp == 0 || temp == preTemp);

                answer.text = "" + (firstNumberTemp + secondNumberTemp + temp);
                preTemp = temp;
            }
        }
        answers[TrueAnswerIndex].text = "" + (secondNumberTemp + firstNumberTemp);
        trueAnswer = secondNumberTemp + firstNumberTemp;
    }

    public void OnSubmitFirstAnswer()
    {
        if (int.Parse(Gm.instance.answer[0].text) == trueAnswer)
        {
            //answer correct, this turret shoot

        }
        else
        {
            //answer wrong, reset all numbers


            //Invoke("showQuestionUI",0.9f);
        }
    }
    public void OnSubmitSecondAnswer()
    {
        if (int.Parse(Gm.instance.answer[1].text) == trueAnswer)
        {
            //answer correct, this turret shoot

        }
        else
        {
            //answer wrong, reset all numbers


            //Invoke("showQuestionUI",0.9f);
        }
    }
    public void OnSubmitThridAnswer()
    {
        if (int.Parse(Gm.instance.answer[2].text) == trueAnswer)
        {
            //answer correct, this turret shoot

        }
        else
        {
            //answer wrong, reset all numbers


            //Invoke("showQuestionUI",0.9f);
        }
    }
}
