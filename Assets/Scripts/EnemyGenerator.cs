using UnityEngine;
using UnityEngine.Splines;
using UnityEngine.UIElements;

namespace Shmup
{
    public class EnemyGenerator : MonoBehaviour
    {
        public GameObject EnemyPrefab;
        public SplineContainer pathSpline;
        GameObject enemy;
        float span = 2f;
        float delta = 0;

        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            this.delta += Time.deltaTime;
            
            if (this.delta > this.span)
            {
                this.delta = 0;
                this.enemy = Instantiate(EnemyPrefab, pathSpline.EvaluatePosition(0), Quaternion.identity);
            }
        }
    }
}
