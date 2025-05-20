using UnityEngine;
using TMPro;

public class Game_Manager : MonoBehaviour
{

    public static int playerCount = 2;

    public Player[] players; // ������ �������
    public Board board; // ������ �� ������ �����
    public Dice dice; // ������ �� ������ ������

    public Player currentPlayer;

    public TMP_Text playerCountText; // ������ �� ��������� ���� ��� ����������� ����� ������

    void Start()
    {
        playerCountText.text = "Players: " + playerCount.ToString(); // ���������� ���������� �������

        fillPlayers(); // ��������� ������ �������

        currentPlayer = players[0]; // ������������� ������� ������ ��� ��������
    }

    void fillPlayers()
    {
        players = new Player[playerCount]; // �������������� ������ �������
        for(int i = 0; i < playerCount; ++i)
        {
            GameObject playerObject = new GameObject("Player" + (i + 1));
            Player player = playerObject.AddComponent<Player>();
            player.playerName = "Player" + (i + 1); // ����������� ��� ������
            player.playerID = i + 1; // ����������� ���������� ����� ������
            players[i] = player; // ��������� ������ � ������
        }
    }

    public void NextTurn()
    {
        // ������ ����� ����
        int currentIndex = System.Array.IndexOf(players, currentPlayer);
        currentIndex = (currentIndex + 1) % players.Length;
        currentPlayer = players[currentIndex];
    }

    void Update()
    {

    }
}
