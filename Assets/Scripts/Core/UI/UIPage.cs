using UnityEngine.Video;

namespace Core.UI
{
    using UnityEngine;
    public class UIPage : MonoBehaviour
    {
        [SerializeField] protected UICoreEnums.PageTypes pageType = UICoreEnums.PageTypes.Intro;
        [SerializeField] protected bool enableCoreButtons = false;
        [SerializeField] protected UICoreEnums.BackgroundTypes backgroundType = UICoreEnums.BackgroundTypes.None;
        [SerializeField] protected Sprite specificBackgroundImage = null;
        [SerializeField] protected VideoClip specificBackgroundVideo = null;

        public bool EnableCoreButtons => enableCoreButtons;
        public UICoreEnums.BackgroundTypes BackgroundType => backgroundType;
        public Sprite BackgroundImage => specificBackgroundImage;
        public VideoClip BackgroundVideo => specificBackgroundVideo;
    }
}

