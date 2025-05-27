using UnityEngine;
using UnityEngine.Splines;

namespace Shmup
{
    public class EnemySplineMover : MonoBehaviour
{
    public SplineContainer pathSpline;
    public float moveSpeed = 5f;
    private float t = 0f;
    private Vector3 offset; // Spline이 Scene 내에서 가진 월드 Offset
        void Start()
        {
            
        }

        void Update()
    {
        offset = this.pathSpline.transform.position;
        if (pathSpline == null) return;
        t += (moveSpeed / pathSpline.CalculateLength()) * Time.deltaTime;
        t = Mathf.Clamp01(t);

        // Spline 경로 위치 + SplineContainer의 현재 위치(= 카메라 위치) 반영
        Vector3 localPos = pathSpline.EvaluatePosition(t);
        transform.position = localPos + pathSpline.transform.position;

        if (t >= 1f)
            Destroy(gameObject);
    }
}    
}


