using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleSpawner : MonoBehaviour
{
    public GameObject prefab;
    public float range;
    public int count;
    public float speed;
    public Material blue;
    public Material yELLow;
    public Material green;
    public Material red;
    private Material barMaterial;
    private string collorNameCircle;



    void Start()
    {
        count = PlayerPrefs.GetInt("CircleCount");
        collorNameCircle = PlayerPrefs.GetString("CircleCollor");
        if (collorNameCircle == "Blue")
        {
            barMaterial = blue;
        }
        else if (collorNameCircle == "Green")
        {
            barMaterial = green;
        }
        else if (collorNameCircle == "Yellow")
        {
            barMaterial = yELLow;
        }
        else if (collorNameCircle == "Red")
        {
            barMaterial = red;
        }
        else
        {
            barMaterial = yELLow;
        }


        for (var angle = 0; angle<360; angle+=360/count)
        {
            var obj = Instantiate(prefab, transform);
            var x = Mathf.Cos(angle * Mathf.Deg2Rad);
            var y = Mathf.Sin(angle * Mathf.Deg2Rad);
            obj.transform.localPosition = new Vector3(x* range, y* range, 0);
        }


        Renderer barRenderer = prefab.GetComponent<Renderer>();
        barRenderer.material = barMaterial;
    }
}
