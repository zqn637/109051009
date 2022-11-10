
using UnityEngine;

namespace Poly
{ 
    /// <summary>
    /// 
    /// </summary>
    public class MoveSystem : MonoBehaviour
    {
        [SerializeField,Header("移動速度"),Range(-10,0)]
        private float speed = -3.5f;
    }



}

