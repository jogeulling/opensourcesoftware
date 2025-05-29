using UnityEditor.PackageManager;
using UnityEngine.SceneManagement;
using UnityEngine;

namespace Shmup
{
    public class GameOver : MonoBehaviour
    {
        // Update is called once per frame
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.R))
            {
                SceneManager.LoadScene(0);
            }
        }
    }
}
