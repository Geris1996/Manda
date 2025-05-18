using UnityEngine;

public enum CellType
{
    PLAYER_HOME,
    START,
    BASE,
    SAVE,
    END,
    TELEPORT // ������� ��� �������
}

public abstract class Cell : MonoBehaviour
{
    public int cellID; // ���������� ����� ������ �� ����
    public CellType cellType; // ��� ������

    // ������������� ������
    public virtual void Initialize(int index, CellType type)
    {
        this.cellID = index;
        this.cellType = type;
    }

    // ������� ��� ��������� ����� �� ������
    public abstract void OnCellEvent();
}

public class TeleportCell : Cell
{
    public int targetCellID; // ���� �������������

    public override void Initialize(int index, CellType type)
    {
        base.Initialize(index, type);
        // targetCellID ����� �������� ����� ��������� ������������ ��� �������
    }

    public override void OnCellEvent()
    {
        Debug.Log($"����� ��������������� �� ������ {targetCellID}");
    }
}

public class PlayerHomeCell : Cell
{
    private Player player; // �����, �������� ����������� ������


    public override void Initialize(int index, CellType type)
    {
        base.Initialize(index, type);

    }
    public override void OnCellEvent()
    {
        Debug.Log($"����� ��������� ����� �� ������ {cellID}");
    }
}
