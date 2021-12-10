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
        Bullet newBullet = pool.GetBullet();
        if (newBullet != null)
        {
            newBullet.transform.SetPositionAndRotation(transform.position, transform.rotation);
            newBullet.ActivateBullet();
        }
    }
}
