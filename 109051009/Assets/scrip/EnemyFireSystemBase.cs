using UnityEngine;

public class EnemyFireSystemBase : FireSystemBase
{
    [SerializeField, Header("生成間隙"), Range(0, 3)]
    private float interval = 1.5f;
    private void Awake()
    {

        InvokeRepeating("SpawnBullet", 0, interval);
    }
}
