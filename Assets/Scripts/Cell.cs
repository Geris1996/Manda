using UnityEngine;

public class Cell
{
    public GameObject quadObject;

    public int cellID;

    public Cell next;
    public Cell previous;

    public Cell(Vector2Int gridPos, int id = 0, Cell prev = null)
    {
        cellID = id;
        CreateQuadForCell(gridPos, id);
        next = null;
        previous = prev;
    }

    void CreateQuadForCell(Vector2Int gridPos, int index)
    {
        quadObject = GameObject.CreatePrimitive(PrimitiveType.Quad);

        quadObject.transform.position = new Vector3(gridPos.x, 0, gridPos.y);
        quadObject.transform.rotation = Quaternion.Euler(90, 0, 0);

        quadObject.name = $"CellQuad_{index}";
    }
}
