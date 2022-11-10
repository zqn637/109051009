using UnityEngine;

public class DamageSystem : MonoBehaviour
{
    [SerializeField, Header("會造成傷害的目標")]
    private string nameTarget;
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name.Contains(nameTarget))
        {
            
            Destroy(gameObject);
        }
    }

}
