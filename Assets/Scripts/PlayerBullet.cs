using UnityEngine;

namespace Shmup
{
    public class PlayerBullet : MonoBehaviour
    {
        public float damage = 10f;
      
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
        
        }

        // Update is called once per frame
        void Update()
        {
        
        }

        void OnTriggerEnter2D(Collider2D other)
        {
            Destroy(other.gameObject);
            if (other.CompareTag("Enemy"))
            {
                Destroy(gameObject);
            }
        }
    }
}
