using UnityEngine;

public class Enablebackground : MonoBehaviour
{
    public bool picked;
    public GameObject imige;

    void Update()
    {
        if(picked)
        {
            imige.SetActive(true);
            PlayerPrefs.SetInt("backgroundactive", 1);
        }
        else
        {
            imige.SetActive(false);
            PlayerPrefs.SetInt("backgroundactive", 0);
        }
       
    }

    public void clicked()
    {
        picked = !picked;
    }


}
