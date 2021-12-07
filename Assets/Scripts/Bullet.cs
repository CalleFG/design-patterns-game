using System.Collections;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private float damage = 10.0f;
    [SerializeField] private float lifetime = 5.0f;
    [SerializeField] private float speed = 10.0f;

    private void FixedUpdate()
    {
        transform.Translate(Vector3.forward * (Time.deltaTime * speed));
    }

    public void ActivateBullet()
    {
        gameObject.SetActive(true);
        StartCoroutine(LifetimeTimer());
    }
    
    private IEnumerator LifetimeTimer()
    {
        yield return new WaitForSeconds(lifetime);
        DisableBullet();
    }

    private void OnTriggerEnter(Collider other)
    {
        IDamageable hit = other.GetComponent<IDamageable>();
        if (hit != null)
        {
            hit.TakeDamage(damage);
        }
        DisableBullet();
    }

    private void DisableBullet()
    {
        gameObject.SetActive(false);
    }
}
