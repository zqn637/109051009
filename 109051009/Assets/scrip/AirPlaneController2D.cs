
using UnityEngine;

namespace Poly
{
    /// <summary>
    /// �������2D�Ҧ�
    /// </summary>
    public class MoveSystem : MonoBehaviour
    {
        [Header("���ʳt��")]
        [SerializeField,Range(0,10)]
        private float speed = -3.5f;
        [SerializeField, Range(0, 10)]
        private float speed = 4f;
        [Header("�Ϥ�")]
        [SerializeField]
        private Sprite pictureup;
        [SerializeField]
        private Sprite pictureMiddle;
        [SerializeField]
        private Sprite pictureDown;

    }



}
