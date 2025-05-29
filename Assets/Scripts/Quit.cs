using UnityEngine;

namespace Shmup
{
    public class Quit : MonoBehaviour
    {
        public void Click()
        {
            OnQuitButton();
        }

        public void OnQuitButton()
        {
             #if UNITY_EDITOR
                UnityEditor.EditorApplication.isPlaying = false;
            #else
                Application.Quit();
            #endif
        }
    }
}
