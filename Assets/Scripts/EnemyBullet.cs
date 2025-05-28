using UnityEngine;
using UnityTimer;

namespace Shmup
{
    public class EnemyBullet : MonoBehaviour
    {
        public float speed = 5f;
        public float damage = 10f;
        public float lifeTime = 5f;
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            Timer.Register(2f, () => Destroy(gameObject));
        }

        // Update is called once per frame
        void Update()
        {
            transform.position += transform.forward * speed * Time.deltaTime;
        }

        void OnTriggerEnter2D(Collider2D other)
        {
            if (other.CompareTag("Player"))
            {
                Destroy(gameObject);
            }
        }
    }
}
