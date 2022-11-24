using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundVolueController : MonoBehaviour
{
    [SerializeField] private AudioSource music;
    [SerializeField] private Slider slider;
    [SerializeField] private Text text;

    [Header("Keys")]
    [SerializeField] private string SaveVolumeKey;

    [Header("Tags")]
    [SerializeField] private string sliderTag;
    [SerializeField] private string textVolumeTag;

    [Header("Parameters")]
    [SerializeField] private float volume;

    private void Awake()
    {
        if (PlayerPrefs.HasKey(SaveVolumeKey))
        {
            this.volume = PlayerPrefs.GetFloat(this.SaveVolumeKey);
            this.music.volume = this.volume;
        }

        GameObject sliderObj = GameObject.FindWithTag(this.sliderTag);
        if (sliderObj != null)
        {
            this.slider = sliderObj.GetComponent<Slider>();
            this.slider.value = this.volume;           
        }
        else
        {
            this.volume = 100f;
            PlayerPrefs.SetFloat(SaveVolumeKey, this.volume);
            this.music.volume = this.volume;
        }
    }

    private void LateUpdate()
    {
        GameObject sliderObj = GameObject.FindWithTag(this.sliderTag);
        if (sliderObj != null)
        {
            this.slider = sliderObj.GetComponent<Slider>();
            this.volume = slider.value;

            if (this.GetComponent<AudioSource>().volume != this.volume)
            {
                PlayerPrefs.SetFloat(this.SaveVolumeKey, this.volume);
            }
        }

        GameObject textObj = GameObject.FindWithTag(this.textVolumeTag);
        if (textObj != null)
        {
            this.text = textObj.GetComponent<Text>();
            this.text.text = Mathf.Round(this.volume * 100) + "%";
        }

        this.music.volume = this.volume;
    }

}
