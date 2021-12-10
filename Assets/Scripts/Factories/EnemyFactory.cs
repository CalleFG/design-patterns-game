using System;
using UnityEngine;

public enum EnemyType
{
    Weak = 0,
    Normal = 1,
    Boss = 2
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
                newEnemy = CreateEnemy(weakPrefab, 1, 10.0f);
                break;
            case EnemyType.Normal:
                newEnemy = CreateEnemy(normalPrefab, 5, 40.0f);
                break;
            case EnemyType.Boss:
                newEnemy = CreateEnemy(bossPrefab, 10, 80.0f);
                break;
            default:
                throw new ArgumentOutOfRangeException(nameof(type), type, null);
        }
        newEnemy.ScaleLevel(level);
        return newEnemy;
    }

    private BaseEnemy CreateEnemy(BaseEnemy prefab, int pointWorth, float health)
    {
        BaseEnemy newEnemy = Instantiate(prefab);
        newEnemy.pointWorth = pointWorth;
        newEnemy.health = health;
        return newEnemy;
    }
}
