using System;

namespace Core.UI
{
    using System.Collections;
    using UnityEngine;

    public class UIManager : MonoBehaviour
    {
        [SerializeField] UIPage[] pages = null;
        [SerializeField] private GameObject coreButtons;
        [SerializeField] private UIBackground coreBackground;
        Stack myStack = new Stack();

        void Start()
        {
            PushPage(pages[0]);
        }

        public void PushPage(UIPage page)
        {
            myStack.Push(page);
            SetupBackground(page);
            coreButtons.gameObject.SetActive(page.EnableCoreButtons);
            page.gameObject.SetActive(true);
        }

        private void SetupBackground(UIPage page)
        {
            switch (page.BackgroundType)
            {
                case UICoreEnums.BackgroundTypes.None:
                    coreBackground.SetupNoBackground();
                    break;
                case UICoreEnums.BackgroundTypes.Image:
                    coreBackground.SetupImageBackground(page.BackgroundImage);
                    break;
                case UICoreEnums.BackgroundTypes.Video:
                    coreBackground.SetupVideoBackground(page.BackgroundVideo);
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
    }
}