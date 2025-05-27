using UnityEngine;
using UnityEngine.Splines;

namespace Shmup
{
    public class EnemyMove : MonoBehaviour
    {
        void Start()
        {
            transform.SetParent(Camera.main.transform, worldPositionStays: true);
        }

        void Update()
        {
            
        }
    }    
}


