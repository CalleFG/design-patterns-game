using UnityEngine;

public abstract class BaseEnemy : MonoBehaviour
{
    public float health = 10.0f;
    public int pointWorth = 1;

    public void ScaleLevel(int level)
    {
        health *= level;
        pointWorth *= level;
    }
}
