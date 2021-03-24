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
        HPSilder
    };

    [Serializable]
    public class SliderClass
    {
        public SliderType type;
        public Slider slider;
    }

    [SerializeField]
    private List<SliderClass> Sliders;

    new Dictionary<SliderType, Slider> SliderMap = new Dictionary<SliderType, Slider>();
    
}
