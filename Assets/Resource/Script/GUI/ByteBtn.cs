using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace DefaultNamespace
{
    public class ByteBtn : MonoBehaviour
    {
        public Image img;
        public TextMeshProUGUI text;
        
        private readonly Color alpha = new Color(0,0,0,0);

        public void OnMouseEnter()
        {
            img.color = Color.white;
            text.color = Color.black;
        }

        public void OnMouseExit()
        {
            img.color = alpha;
            text.color = Color.white;
        }
    }
}