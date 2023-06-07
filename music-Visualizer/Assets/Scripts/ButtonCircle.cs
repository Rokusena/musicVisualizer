using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonCircle : MonoBehaviour
{
    public GameObject image;
    public GameObject Otherimage2;
    public GameObject Otherimage3;
    public GameObject Otherimage4;
    public bool chosen = false;
    public string imageName;

    void Update()
    {
        imageName = image.name;
        if (image.activeSelf == false)
        {
            chosen = false;
        }
    }

    public void click()
    {
        chosen = !chosen;
        image.SetActive(chosen);
        PlayerPrefs.SetString("CircleCollor", imageName);
        if (chosen)
        {
            Otherimage2.SetActive(false);
            Otherimage3.SetActive(false);
            Otherimage4.SetActive(false);
        }
    }
}
