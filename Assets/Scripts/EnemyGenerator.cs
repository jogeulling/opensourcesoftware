using UnityEngine;
using UnityEngine.Splines;

namespace Shmup
{
    public class EnemyGenerator : MonoBehaviour
    {
        public GameObject EnemyPrefab;
        public SplineContainer pathSpline;
        GameObject enemy;
        float span = 2f;
        float delta = 0;
        float speed = 3.0f;
        public int maxEnemy = 0;

        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            this.delta += Time.deltaTime;
            
            if (this.delta > this.span && this.maxEnemy <= 3)
            {
                this.delta = 0;
                this.maxEnemy += 1;

                this.enemy = Instantiate(EnemyPrefab, pathSpline.EvaluatePosition(0f), Quaternion.identity);

                var splineAnim = this.enemy.GetComponent<SplineAnimate>();
                if (splineAnim == null) splineAnim = this.enemy.AddComponent<SplineAnimate>();


                splineAnim.Container = pathSpline;
                splineAnim.ObjectUpAxis = SplineAnimate.AlignAxis.ZAxis;
                splineAnim.ObjectForwardAxis = SplineAnimate.AlignAxis.YAxis;
                splineAnim.AnimationMethod = SplineAnimate.Method.Speed;
                splineAnim.MaxSpeed = this.speed;
                splineAnim.Restart(true);
            }
        }

        void LateUpdate()
        {
            Vector3 pos = transform.position;
            pos.z = 0f;
            transform.position = pos;
        }
    }
}
