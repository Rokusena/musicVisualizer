using UnityEngine;

public class ButtonBackground : MonoBehaviour
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
        PlayerPrefs.SetString("backgroundCollor",imageName );
        if (chosen)
        {
            Otherimage2.SetActive(false);
            Otherimage3.SetActive(false);
            Otherimage4.SetActive(false);
        }
    }
}
