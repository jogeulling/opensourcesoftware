using UnityEngine;
using UnityTimer;
namespace Shmup
{
    public class PlayerBullet : MonoBehaviour
    {
        public float damage = 10f;
        public float speed = 0f;
        private Timer distroytime;
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            this.distroytime = Timer.Register(2f, () => Destroy(gameObject));
        }

        // Update is called once per frame
        void Update()
        {
            transform.position += Vector3.up * (this.speed * Time.deltaTime);
        }

        void OnTriggerEnter2D(Collider2D other)
        {
            if (other.CompareTag("Enemy"))
            {
                this.distroytime.Cancel();
                Destroy(gameObject);
            }
        }
    }
}
