using UnityEngine;

public class Enemy : BaseEnemy, IDamageable
{
    public void TakeDamage(float amount)
    {
        health -= amount;
        if (health <= 0)
        {
            Die();
        }
    }

    public void Update()
    {
        transform.Translate(Vector3.forward * (Time.deltaTime * 1.0f));
    }

    private void Die()
    {
        ScoreManager.Instance.AddPoints(pointWorth);
        Destroy(gameObject);
    }
}
