using UnityEngine;

namespace Shmup
{
    public class CameraController : MonoBehaviour
    {
        [SerializeField] Transform player;
        [SerializeField] float speed = 2f;
        GameObject backgroundend;
        GameObject cameraend;
        bool clear = false;
        float threshold = 0.1f;
        void Start()
        {
            this.backgroundend = GameObject.Find("Backgroundendpoint");
            this.cameraend = GameObject.Find("Cameraendpoint");

            transform.position = new Vector3(player.position.x, player.position.y, transform.position.z);
        }
        void Update()
        {
            Clear();
        }
        void Clear()
        {
            // Move the camera along the battlefield at a constant speed
            if (this.clear == false)
            {
                transform.position += Vector3.up * (speed * Time.deltaTime);
            }

            if (Vector3.Distance(this.cameraend.transform.position, this.backgroundend.transform.position) < threshold)
            {
                Debug.Log("Game Clear");
                this.clear = true;
            }
        }

    }
    
}