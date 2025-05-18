using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Dice : MonoBehaviour
{

    public TMP_Text firstText;
    public TMP_Text secondText;
    public TMP_Text player;

    public Player currentPlayer;
    public Game_Manager gameManager;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    public void OnRollDiceButton()
    {

        if(firstText != null)
        {
            firstText.text = RollDice().ToString();
        }
        if (secondText != null)
        {
            secondText.text = RollDice().ToString();
        }

        gameManager.NextTurn();
    }


    private int RollDice()
    {
        return Random.Range(1, 7);
    }

    // Update is called once per frame
    void Update()
    {
        currentPlayer = gameManager.currentPlayer;
        if (player != null)
        {
            player.text = currentPlayer.playerName;
        }
    }
}
