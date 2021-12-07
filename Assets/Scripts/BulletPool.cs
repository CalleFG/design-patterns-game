using System.Collections.Generic;
using UnityEngine;

public class BulletPool : MonoBehaviour
{
    [SerializeField] private int poolAmount = 30;
    [SerializeField] private Bullet poolObject;
    private List<Bullet> pooledBullets;
    
    private void Start()
    {
        InitializePool();
    }

    public Bullet GetBullet()
    {
        foreach (Bullet obj in pooledBullets)
        {
            if (!obj.gameObject.activeInHierarchy)
            {
                return obj;
            }
        }

        return null;
    }
    
    private void InitializePool()
    {
        pooledBullets = new List<Bullet>(poolAmount);
        for (int i = 0; i < poolAmount; i++)
        {
            Bullet newBullet = Instantiate(poolObject);
            newBullet.gameObject.SetActive(false);
            pooledBullets.Add(newBullet);
        }
    }
}
