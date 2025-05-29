using UnityEditor.PackageManager;
using UnityEngine.SceneManagement;
using UnityEngine;

namespace Shmup
{
    public class Loader : MonoBehaviour
    {
        public void Click()
        {
            SceneManager.LoadScene(1);
        }
    }
}
