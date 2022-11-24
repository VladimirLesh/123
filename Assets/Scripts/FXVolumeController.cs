using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FXVolumeController : MonoBehaviour
{
    [SerializeField] private AudioSource[] FX;
    [SerializeField] private GameObject sliderObj;
    [SerializeField] private Slider sliderFX;
    [SerializeField] private Text textFX;

    [Header("Keys")]
    [SerializeField] private string SaveVolumeKey;

    [Header("Tags")]
    [SerializeField] private string sliderTag;
    [SerializeField] private string textVolumeTag;

    [Header("Parameters")]
    [SerializeField] private float volume;

    private void Awake()
    {
        
        FX = FindObjectsOfType<AudioSource>();

        for (int i = 0; i < FX.Length; i++)
        {
            if (PlayerPrefs.HasKey(SaveVolumeKey))
            {
                this.volume = PlayerPrefs.GetFloat(this.SaveVolumeKey);
                this.FX[i].volume = this.volume;
            }
        }

        sliderObj = GameObject.FindWithTag(this.sliderTag);
        if (sliderObj != null)
        {
            this.sliderFX = sliderObj.GetComponent<Slider>();
            this.sliderFX.value = this.volume;
        }
        else
        {
            for (int i = 0; i < FX.Length; i++)
            {
                this.volume = 100f;
                PlayerPrefs.SetFloat(SaveVolumeKey, this.volume);
                this.FX[i].volume = this.volume;
            }                
        }
    }

    private void LateUpdate()
    {
        GameObject[] sliderObj = GameObject.FindGameObjectsWithTag(this.sliderTag);

        for (int i = 0; i < sliderObj.Length; i++)
        {
            if (sliderObj != null)
            {
                this.sliderFX = sliderObj[i].GetComponent<Slider>();
                this.volume = sliderFX.value;

                if (this.GetComponent<AudioSource>().volume != this.volume)
                {
                    PlayerPrefs.SetFloat(this.SaveVolumeKey, this.volume);
                }
            }

            GameObject textObj = GameObject.FindWithTag(this.textVolumeTag);
            if (textObj != null)
            {
                this.textFX = textObj.GetComponent<Text>();
                this.textFX.text = Mathf.Round(this.volume * 100) + "%";
            }

            this.FX[i].volume = this.volume;
            Debug.Log(sliderObj[i]);
        }
        
    }

}
