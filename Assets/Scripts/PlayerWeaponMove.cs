using UnityEngine;
using UnityTimer;
namespace Shmup
{
    public class PlayerWeaponMove : MonoBehaviour
    {
        public float speed = 0f;
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            Timer.Register(2f, () => Destroy(gameObject));
        }

        // Update is called once per frame
        void Update()
        {
            transform.position += Vector3.up * (this.speed * Time.deltaTime);
        }
    }
}
