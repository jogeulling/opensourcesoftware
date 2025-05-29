using UnityEditor.PackageManager;
using UnityEngine.SceneManagement;
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

            if (this.player != null)
            {
                transform.position = new Vector3(player.position.x, player.position.y, transform.position.z);
            }
        }
        void Update()
        {
            // Move the camera along the battlefield at a constant speed
            if (this.clear == false)
            {
                transform.position += Vector3.up * (speed * Time.deltaTime);
            }

            Clear();

            if (this.clear == true)
            {
                SceneManager.LoadScene(3);
            }
        }
        void Clear()
        {
            if (Vector3.Distance(this.cameraend.transform.position, this.backgroundend.transform.position) < threshold)
            {
                this.clear = true;
            }
        }

    }
    
}