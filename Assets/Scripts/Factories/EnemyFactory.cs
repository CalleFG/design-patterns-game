using System;
using UnityEngine;

public enum EnemyType
{
    Weak = 1,
    Normal = 2,
    Boss = 3
}

public class EnemyFactory : MonoBehaviour
{
    [SerializeField] private BaseEnemy weakPrefab;
    [SerializeField] private BaseEnemy normalPrefab;
    [SerializeField] private BaseEnemy bossPrefab;

    public BaseEnemy GetEnemy(EnemyType type, int level)
    {
        BaseEnemy newEnemy;
        switch (type)
        {
            case EnemyType.Weak:
                newEnemy = Instantiate(weakPrefab);
                break;
            case EnemyType.Normal:
                newEnemy = Instantiate(normalPrefab);
                break;
            case EnemyType.Boss:
                newEnemy = Instantiate(bossPrefab);
                break;
            default:
                throw new ArgumentOutOfRangeException(nameof(type), type, null);
        }
        newEnemy.ScaleLevel(level);
        return newEnemy;
    }
}
