using UnityEngine;

public class PlayerFireSystemBase : FireSystemBase
{
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SpawnBullet();

        }
        
    }
}
