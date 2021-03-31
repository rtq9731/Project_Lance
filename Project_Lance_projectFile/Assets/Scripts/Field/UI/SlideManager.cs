using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SlideManager : MonoBehaviour
{

    public enum SliderType
    {
        SpeedSilder,
        HPSilder,
        HorseSteminaGauge
    };

    [Serializable]
    public class SliderClass
    {
        public SliderType type;
        public Slider slider;
    }

    [SerializeField]
    private List<SliderClass> sliders;

    new Dictionary<SliderType, SliderClass> sliderMap = new Dictionary<SliderType, SliderClass>();

    private void Start()
    {
        foreach(var item in sliders)
        {
            sliderMap[item.type] = item;
        }

    }

    private void Update()
    {
        SetSpeedGauge();
    }

    private void SetSpeedGauge()
    {
        // sliderMap[SliderType.HPSilder].slider.value = FieldManager.Instance.HP;
        sliderMap[SliderType.SpeedSilder].slider.value = FieldManager.Instance.SpeedOfPlayer / 10;
    }

}
