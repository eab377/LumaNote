using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class ColorShift : MonoBehaviour
{
    PostProcessVolume volume;
    ColorGrading colorGrading;
    LensDistortion lensDistortion;
    public bool direction = true;
    public float shiftSpeed = 1f;
    public AudioSource music;
    public bool distortionCompleted = false;

    // Start is called before the first frame update
    void Start()
    {
        volume = this.GetComponent<PostProcessVolume>();
        volume.profile.TryGetSettings(out colorGrading);
        volume.profile.TryGetSettings(out lensDistortion);
    }

    // Update is called once per frame
    void Update()
    {
        if(music.time >= 47.058 && !distortionCompleted)
        {
            distortLens();
        }

        if (music.time >= 48.576)
        {   
            shift();
        }
    }

    void distortLens()
    {
        
        if(music.time >= 48.62)
        {
            if(lensDistortion.intensity.value < 0)
            {
                lensDistortion.intensity.value += 527.009222661f * Time.deltaTime;
            }
            else
            {
                lensDistortion.intensity.value = 0;
                distortionCompleted = true;
            }
        }
        else
        {
            lensDistortion.intensity.value -= 65.8761528327f * Time.deltaTime;
        }
    }

    void shift()
    {
        if (direction)
        {
            colorGrading.hueShift.value += shiftSpeed * Time.deltaTime;
            if (colorGrading.hueShift.value >= 180)
                direction = false;
        }
        else
        {
            colorGrading.hueShift.value -= shiftSpeed * Time.deltaTime;
            if (colorGrading.hueShift.value <= -180)
                direction = true;
        }
    }
}
