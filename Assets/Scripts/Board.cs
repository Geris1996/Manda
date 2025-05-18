using UnityEngine;
using System.Collections.Generic; // Правильное пространство имён

public class Board : MonoBehaviour
{
    public List<Cell> board;
    public int playerNum;

    void Start()
    {
        board = new List<Cell>();
    }

    void Update()
    {

    }
}
