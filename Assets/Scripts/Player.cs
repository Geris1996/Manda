using UnityEngine;

public class Player : MonoBehaviour
{
    public int playerID = 1; // Уникальный номер игрока
    public string playerName; // Имя игрока
    public Piece[] pieces; // Массив фишек игрока

    public bool isMyTurn; // Флаг, указывающий, чей сейчас ход

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }
}
