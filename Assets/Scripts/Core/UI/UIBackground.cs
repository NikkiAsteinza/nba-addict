using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

namespace Core.UI
{
public class UIBackground : MonoBehaviour
{
    [SerializeField] private Image imageBackground;
    [SerializeField] private VideoPlayer videoBackground;

    public void SetupNoBackground()
    {
        videoBackground.gameObject.SetActive(false);
        imageBackground.gameObject.SetActive(false);
    }
    
    public void SetupImageBackground(Sprite bg)
    {
        videoBackground.gameObject.SetActive(false);

        imageBackground.sprite = bg;
        imageBackground.gameObject.SetActive(true);
    }

    public void SetupVideoBackground(VideoClip clip)
    {
        imageBackground.gameObject.SetActive(false);
        
        videoBackground.clip = clip;
        videoBackground.gameObject.SetActive(true);
        videoBackground.Play();
    }
}}
