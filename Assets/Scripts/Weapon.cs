using UnityEngine;

[RequireComponent(typeof(BulletPool))]

public class Weapon : MonoBehaviour
{
    private BulletPool pool;

    private void Awake()
    {
        pool = gameObject.GetComponent<BulletPool>();
    }

    public void Fire()
    {
        Transform cacheTransform = transform;
        pool.SpawnBullet(cacheTransform.position, cacheTransform.rotation);
    }
}
