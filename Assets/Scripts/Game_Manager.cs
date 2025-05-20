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

        fillPlayers(); // Заполняем массив игроков

        currentPlayer = players[0]; // Устанавливаем первого игрока как текущего
    }

    void fillPlayers()
    {
        players = new Player[playerCount]; // Инициализируем массив игроков
        for(int i = 0; i < playerCount; ++i)
        {
            GameObject playerObject = new GameObject("Player" + (i + 1));
            Player player = playerObject.AddComponent<Player>();
            player.playerName = "Player" + (i + 1); // Присваиваем имя игроку
            player.playerID = i + 1; // Присваиваем уникальный номер игроку
            players[i] = player; // Добавляем игрока в массив
        }
    }

    public void NextTurn()
    {
        // Логика смены хода
        int currentIndex = System.Array.IndexOf(players, currentPlayer);
        currentIndex = (currentIndex + 1) % players.Length;
        currentPlayer = players[currentIndex];
    }

    void Update()
    {

    }
}
