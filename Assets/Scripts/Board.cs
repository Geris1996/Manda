using UnityEngine;
using System.Collections.Generic; // Правильное пространство имён

enum Direction
{
    Up,
    Down,
    Left,
    Right
}

public class Board : MonoBehaviour
{
    public int boardSize = 64; // Размер доски

    Cell head;
    Cell end;

    void Start()
    {
        makeMain(); // Создание основной структуры доски
    }

    void makeMain()
    {
        Vector2Int currentPosition = new Vector2Int(0, -8);
        Direction currentDirection = Direction.Left;

        head = new Cell(currentPosition);

        Cell current = head;

        for (int i = 1; i < boardSize; ++i)
        {
            currentDirection = ChangeDirection(currentDirection, i);
            currentPosition = Move(currentPosition, currentDirection);

            Cell newCell = new Cell(currentPosition, i, current);
            current.next = newCell;
            current = current.next;
        }

        end = current;
        end.next = head;
        head.previous = end;
    }

    Direction ChangeDirection(Direction dir, int i)
    {
        switch (i)
        {
            case 4: case 12: case 24:
                return Direction.Up;
            case 8: case 52: case 60:
                return Direction.Left;
            case 20: case 28: case 40:
                return Direction.Right;
            case 36: case 44: case 56:
                return Direction.Down;
            default:
                return dir;
        }
    }

    Vector2Int Move(Vector2Int pos, Direction dir)
    {
        switch (dir)
        {
            case Direction.Up: return new Vector2Int(pos.x, pos.y + 1);
            case Direction.Down: return new Vector2Int(pos.x, pos.y - 1);
            case Direction.Left: return new Vector2Int(pos.x - 1, pos.y);
            case Direction.Right: return new Vector2Int(pos.x + 1, pos.y);
            default: return pos;
        }
    }

    void Update()
    {

    }
}
