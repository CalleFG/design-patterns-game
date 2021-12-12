using System.Collections.Generic;
using UnityEngine;

public class BulletPool : MonoBehaviour
{
    [SerializeField] private int poolAmount = 30;
    [SerializeField] private Bullet poolObject;

    private Queue<Bullet> bulletQueue;
    
    private void Start()
    {
        InitializePool();
    }

    public Bullet SpawnBullet(Vector3 position, Quaternion rotation)
    {
        Bullet newBullet = bulletQueue.Dequeue();
        newBullet.ActivateBullet();
        newBullet.transform.SetPositionAndRotation(position, rotation);
        
        bulletQueue.Enqueue(newBullet);

        return newBullet;
    }
    
    private void InitializePool()
    {
        bulletQueue = new Queue<Bullet>(poolAmount);
        for (int i = 0; i < poolAmount; i++)
        {
            Bullet newBullet = Instantiate(poolObject);
            newBullet.gameObject.SetActive(false);
            bulletQueue.Enqueue(newBullet);
        }
    }
}
