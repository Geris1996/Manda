using UnityEngine;

public enum CellType
{
    PLAYER_HOME,
    START,
    BASE,
    SAVE,
    END,
    TELEPORT // Добавим для примера
}

public abstract class Cell : MonoBehaviour
{
    public int cellID; // Уникальный номер клетки на поле
    public CellType cellType; // Тип клетки

    // Инициализация клетки
    public virtual void Initialize(int index, CellType type)
    {
        this.cellID = index;
        this.cellType = type;
    }

    // Событие при попадании фишки на клетку
    public abstract void OnCellEvent();
}

public class TeleportCell : Cell
{
    public int targetCellID; // Куда телепортирует

    public override void Initialize(int index, CellType type)
    {
        base.Initialize(index, type);
        // targetCellID можно задавать через параметры конструктора или вручную
    }

    public override void OnCellEvent()
    {
        Debug.Log($"Фишка телепортирована на клетку {targetCellID}");
    }
}

public class PlayerHomeCell : Cell
{
    private Player player; // Игрок, которому принадлежит клетка


    public override void Initialize(int index, CellType type)
    {
        base.Initialize(index, type);

    }
    public override void OnCellEvent()
    {
        Debug.Log($"Фишка вернулась домой на клетку {cellID}");
    }
}
