
using UnityEngine;

namespace Poly
{
    /// <summary>
    /// 飛機控制器2D模式
    /// </summary>
    public class MoveSystem : MonoBehaviour
    {
        [Header("移動速度")]
        [SerializeField,Range(0,10)]
        private float speed = -3.5f;
        [SerializeField, Range(0, 10)]
        private float speed = 4f;
        [Header("圖片")]
        [SerializeField]
        private Sprite pictureup;
        [SerializeField]
        private Sprite pictureMiddle;
        [SerializeField]
        private Sprite pictureDown;

    }



}
