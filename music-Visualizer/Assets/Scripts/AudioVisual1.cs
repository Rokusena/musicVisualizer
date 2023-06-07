using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioVisual1 : MonoBehaviour
{
    public float maxHeight = 10f; 
    public int numBars = 64;
    public float spacing = 0.1f;
    public AudioAnalyzer analyzer;


    public Material blue;
    public Material yELLow;
    public Material green;
    public Material red;
    private Material barMaterial;
    private string Materialname;

    private GameObject[] visualizerBars; 

    private void Start()
    {
      
        AudioSource audioSource = GetComponent<AudioSource>();

        Materialname = PlayerPrefs.GetString("backgroundCollor");

        if(Materialname == "Blue")
        {
            barMaterial = blue;
        }
        else if (Materialname == "Green")
        {
            barMaterial = green;
        }
        else if (Materialname == "Yellow")
        {
            barMaterial = yELLow;
        }
        else if(Materialname == "Red")
        {
            barMaterial = red;
        }
        else
        {
            barMaterial = red;
        }




        visualizerBars = new GameObject[numBars];
        for (int i = 0; i < numBars; i++)
        {
            GameObject bar = GameObject.CreatePrimitive(PrimitiveType.Cube);
            bar.transform.SetParent(transform);
            bar.transform.localScale = new Vector3(1f, 0.1f, 1f);
            bar.transform.localPosition = new Vector3((float)i * spacing, 0f, 0f);

            Renderer barRenderer = bar.GetComponent<Renderer>();
            barRenderer.material = barMaterial;

            visualizerBars[i] = bar;
        }
    }

    private void Update()
    {
       
        

        
        for (int i = 0; i < numBars; i++)
        {
            
            float scale = analyzer.spectrumData[i] * maxHeight;
            visualizerBars[i].transform.localScale = new Vector3(1f, scale, 1f);
        }
    }
}
