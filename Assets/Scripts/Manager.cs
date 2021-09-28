using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Manager : MonoBehaviour
{
    public Text Result;
    public Image AIChoice;
    public Image OurChoice;

    public string[] Choices;
    public Sprite Rock, Paper, Scissors;

    public void Play(string myChoice)
    {
        string randomChoice = Choices[Random.Range(0, Choices.Length)];

        switch(randomChoice)
        {
            case "Rock":
                switch(myChoice)
                {
                    case "Rock":
                        OurChoice.sprite = Rock;
                        Result.text = "Tie!";
                        break;

                    case "Paper":
                        OurChoice.sprite = Paper;
                        Result.text = "The paper covers the rock, you win!";
                        break;

                    case "Scissors":
                        OurChoice.sprite = Scissors;
                        Result.text = "The rock destroys the scissors, you lose!";
                        break;
                    
                }

                AIChoice.sprite = Rock;
                
                break;

            case "Paper":
                switch (myChoice)
                {
                    case "Rock":
                        OurChoice.sprite = Rock;
                        Result.text = "The paper covers the rock, you lose!";
                        break;

                    case "Paper":
                        OurChoice.sprite = Paper;
                        Result.text = "Tie!";
                        break;

                    case "Scissors":
                        OurChoice.sprite = Scissors;
                        Result.text = "The scissors cuts the paper, you win!";
                        break;

                }

                AIChoice.sprite = Paper;
                break;

            case "Scissors":
                switch (myChoice)
                {
                    case "Rock":
                        OurChoice.sprite = Rock;
                        Result.text = "The rock destroys the scissors, you win!";
                        break;

                    case "Paper":
                        OurChoice.sprite = Paper;
                        Result.text = "The scissors cuts the paper, you lose!";
                        break;

                    case "Scissors":
                        OurChoice.sprite = Scissors;
                        Result.text = "Tie!";
                        break;

                }

                AIChoice.sprite = Scissors;
                break;

        }
    }
}
