using UnityEngine;

namespace Shmup
{
    public class EnemyGenerator : MonoBehaviour
    {
        public GameObject EnemyPrefab;
        float span = 1.0f;
        float delta = 0;

        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
        
        }

        // Update is called once per frame
        void Update()
        {
            this.delta += Time.deltaTime;
            if (this.delta > this.span) {
                this.delta = 0;
                GameObject createEnemy = Instantiate(EnemyPrefab);
            }
        }
    }
}
