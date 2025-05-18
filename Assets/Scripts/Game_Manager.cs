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
    }

    public void NextTurn()
    {
        // ������ ����� ����
        int currentIndex = System.Array.IndexOf(players, currentPlayer);
        currentIndex = (currentIndex + 1) % players.Length;
        currentPlayer = players[currentIndex];
    }



    // Update is called once per frame
    void Update()
    {

    }
}
