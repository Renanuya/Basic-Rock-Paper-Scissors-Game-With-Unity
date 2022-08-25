using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockPaperScissors : MonoBehaviour
{
    public string player1, player2;
    
    void Start()
    {
        if (player1 == "Rock" && player2 == "Paper")
        {
            Debug.Log("Player2 win the game!");
        }
        else if (player1 == "Rock" && player2 == "Scissors")
        {
            Debug.Log("Player1 win the game!");
        }
        else if (player1 == "Rock" && player2 == "Rock")
        {
            Debug.Log("The match ended in a draw!");
        }
        else if (player1 == "Paper" && player2 == "Scissors")
        {
            Debug.Log("Player2 win the game!");
        }
        else if (player1 == "Paper" && player2 == "Rock")
        {
            Debug.Log("Player1 win the game!");
        }
        else if (player1 == "Paper" && player2 == "Paper")
        {
            Debug.Log("The match ended in a draw!");
        }
        else if (player1 == "Scissors" && player2 == "Rock")
        {
            Debug.Log("Player2 win the game!");
        }
        else if (player1 == "Scissors" && player2 == "Paper")
        {
            Debug.Log("Player1 win the game!");
        }
        else if (player1 == "Scissors" && player2 == "Scissors")
        {
            Debug.Log("The match ended in a draw!");
        }

    }

    /*
    ROCK PAPER
    ROCK SCISSORS
    ROCK ROCK
    PAPER ROCK
    PAPER SCISSORS
    PAPER PAPER
    SCISSORS ROCK
    SCISSORS PAPER
    SCISSORS SCISSORS
    */

}
