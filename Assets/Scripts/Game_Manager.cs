using UnityEngine;
using TMPro;

public class Game_Manager : MonoBehaviour
{

    public static int playerCount = 2;

    public Player[] players; // Массив игроков
    public Board board; // Ссылка на объект доски
    public Dice dice; // Ссылка на объект кубика

    public Player currentPlayer;

    public TMP_Text playerCountText; // Ссылка на текстовое поле для отображения имени игрока

    void Start()
    {
        playerCountText.text = "Players: " + playerCount.ToString(); // Отображаем количество игроков
    }

    public void NextTurn()
    {
        // Логика смены хода
        int currentIndex = System.Array.IndexOf(players, currentPlayer);
        currentIndex = (currentIndex + 1) % players.Length;
        currentPlayer = players[currentIndex];
    }



    // Update is called once per frame
    void Update()
    {

    }
}
