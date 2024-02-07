using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.UI
{
    public class ClueWindow : AbstractWindowUI
    {
        [SerializeField]
        private Image clueImage;

        public void LoadClueImage(Sprite sprite)
        {
            clueImage.sprite = sprite;
        }
    }
}