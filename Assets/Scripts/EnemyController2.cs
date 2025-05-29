using UnityEngine;

namespace Shmup
{
    public class EnemyController2 : MonoBehaviour
    {
        public GameObject path;
        public EnemyGenerator enemyGen;
        public int endCount;
        public float enemyHealth = 30f;
        public float damage = 10f;
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            this.path = GameObject.Find("Path2");
            this.enemyGen = this.path.GetComponent<EnemyGenerator>();
        }

        void OnTriggerEnter2D(Collider2D other)
        {
            if (other.CompareTag("bullet"))
            {
                this.enemyHealth -= this.damage;

                if (this.enemyHealth <= 0)
                {
                    this.enemyGen.OnEnemyDestroyed();
                    Destroy(gameObject);
                }
                
            }
        }
    }
}
