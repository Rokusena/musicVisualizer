using UnityEngine;

public class ButtonManiger : MonoBehaviour
{
    public GameObject image;
    public int number;
    public GameObject OtherImage;
    public GameObject OtherImage2;
    public GameObject OtherImage3;
    public GameObject OtherImage4;
    public GameObject OtherImage5;
    public GameObject OtherImage6;
    public GameObject OtherImage7;
    public GameObject OtherImage8;
    public GameObject OtherImage9;
    public GameObject OtherImage10;
    public GameObject OtherImage11;
    public GameObject OtherImage12;
    public GameObject OtherImage13;

    public bool active = false;
    void Update()
    {
        if (!image.activeSelf)
        {
            active = false;
        }
    }

    public void checkMusic()
    {
        active = !active; 
        image.SetActive(active);
        PlayerPrefs.SetInt("SongNumber", number);
        if (active)
        {
            OtherImage.SetActive(false);
            OtherImage2.SetActive(false);
            OtherImage3.SetActive(false);
            OtherImage4.SetActive(false);
            OtherImage5.SetActive(false);
            OtherImage6.SetActive(false);
            OtherImage7.SetActive(false);
            OtherImage8.SetActive(false);
            OtherImage9.SetActive(false);
            OtherImage10.SetActive(false);
            OtherImage11.SetActive(false);
            OtherImage12.SetActive(false);
            OtherImage13.SetActive(false);
        }
    }
    

}
