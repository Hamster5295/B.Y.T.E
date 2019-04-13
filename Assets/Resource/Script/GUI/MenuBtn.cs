using UnityEditor;
using UnityEngine;

namespace Resource.Script.GUI
{
    public class ExitBtn : MonoBehaviour
    {
        public void OnMouseDown()
        {
#if UNITY_EDITOR
            EditorApplication.isPlaying = false;
#else
                Application.Quit();
#endif
        }

    }
}