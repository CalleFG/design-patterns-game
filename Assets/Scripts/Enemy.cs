using UnityEngine;

public class Enemy : MonoBehaviour, IDamageable
{
    [SerializeField] private float health = 10.0f;
    [SerializeField] private int pointWorth = 1;
    
    public void TakeDamage(float amount)
    {
        health -= amount;
        if (health <= 0)
        {
            Die();
        }
    }

    private void Die()
    {
        ScoreManager.Instance.AddPoints(pointWorth);
        Destroy(gameObject);
    }
}
