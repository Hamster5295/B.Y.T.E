using TMPro;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

namespace DefaultNamespace
{
    public class ByteBtn : MonoBehaviour
    {
        public Image img;
        public TextMeshProUGUI text;
        public AudioSource source;
        public AudioClip clip;
        
        private readonly Color _alpha = new Color(0,0,0,0);
        private bool _hasAudioClip;

        private void Start()
        {
            if (clip == null)
            {
                _hasAudioClip = false;
            }
            else
            {
                source.clip = clip;
                _hasAudioClip = true;
            }
        }

        public void OnMouseEnter()
        {
            img.color = Color.white;
            text.color = Color.black;
            if(_hasAudioClip)
                source.Play();
            
        }

        public void OnMouseExit()
        {
            img.color = _alpha;
            text.color = Color.white;
        }
    }
}