using UnityEngine;
using TMPro;

public class CircleCount : MonoBehaviour
{
    public TMP_Text textComponent;
    public int count;

    public void Update()
    {
        textComponent.text = count.ToString();
        PlayerPrefs.SetInt("CircleCount", count);
    }
    public void Add()
    {
        count++;
       
    }

    public void minus()
    {
        count--;
       
    }



}
