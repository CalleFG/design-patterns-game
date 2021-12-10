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
                newEnemy = Instantiate(weakPrefab);
                newEnemy.pointWorth = 1;
                newEnemy.health = 10.0f;
                break;
            case EnemyType.Normal:
                newEnemy = Instantiate(normalPrefab);
                newEnemy.pointWorth = 5;
                newEnemy.health = 40.0f;
                break;
            case EnemyType.Boss:
                newEnemy = Instantiate(bossPrefab);
                newEnemy.pointWorth = 15;
                newEnemy.health = 100.0f;
                break;
            default:
                throw new ArgumentOutOfRangeException(nameof(type), type, null);
        }
        newEnemy.ScaleLevel(level);
        return newEnemy;
    }
}
