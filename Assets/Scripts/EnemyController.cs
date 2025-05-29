using UnityEngine;

namespace Shmup
{
    public class EnemyController : MonoBehaviour
    {
        public float enemyHealth = 30f;
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
            if (other.CompareTag("bullet"))
            {
                this.enemyHealth -= this.damage;

                if (this.enemyHealth <= 0)
                {
                    Destroy(gameObject);    
                }
                
            }
        }
    }
}
