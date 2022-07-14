using UnityEngine;

enum DayOfWeek 
{
    Moday,
    Tuesday,
    Wednesday,
}

enum Direction
{
    North,
    South,
    West,
    East,
}

public class EnumPractice : MonoBehaviour
{
    [SerializeField] DayOfWeek day;
    [SerializeField] Direction direction;

    [SerializeField] Vector2 directionVec;

    void OnValidate()
    {
        directionVec = DirectionToVector(direction);
    }

    Vector2 DirectionToVector(Direction direction)
    {
        Vector2 result = Vector2.zero;

        if (direction == Direction.East)
            result = new Vector2(1, 0);

        else if (direction == Direction.West)
            result = new Vector2(-1, 0);

        else if (direction == Direction.North)
            result = new Vector2(0, 1);

        else if (direction == Direction.South)
            result = new Vector2(0, -1);

        return result;
    }
}
