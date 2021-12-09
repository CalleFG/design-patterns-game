using UnityEngine;

public abstract class BaseEnemy : MonoBehaviour
{
    protected float health = 10.0f;
    protected int pointWorth = 1;

    public void ScaleLevel(int level)
    {
        health *= level;
        pointWorth *= level;
    }
}
