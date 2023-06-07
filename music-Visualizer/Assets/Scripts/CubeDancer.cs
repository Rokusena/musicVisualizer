using UnityEngine;

public class CubeDancer : MonoBehaviour
{
    public float size = 1;
    public float power = 2;
    public float shrinkspeed = 1;
    private float finalSize;
    public Material blue;
    public Material yELLow;
    public Material green;
    public Material red;
    private Material barMaterial;
    private string collorNameCube;
    public GameObject cube;

    public AudioVisualizer visualizer;
    public AudioAnalyzer analyzer;

    private void Start()
    {
        collorNameCube = PlayerPrefs.GetString("backgroundCollor");
        if (collorNameCube == "Blue")
        {
            barMaterial = blue;
              
        }
        else if (collorNameCube == "Green")
        {
            barMaterial = green;
        }
        else if (collorNameCube == "Yellow")
        {
            barMaterial = yELLow;
        }
        else if (collorNameCube == "Red")
        {
            barMaterial = red;
        }
        else
        {
            barMaterial = blue;
          
        }
       
        Renderer barRenderer = GetComponent<Renderer>();
        if (barRenderer != null)
        {
            barRenderer.material = barMaterial;
        }
       


    }
    public void Update()
    {
        
       
        var musicPower = (1 + Mathf.Pow(visualizer.avarage, power) * size);

      

        if (musicPower > finalSize)
        {
            finalSize = musicPower;
        }
        else
        {
            finalSize -= shrinkspeed * Time.deltaTime;
        }

        transform.localScale = Vector3.one * finalSize;

        transform.Rotate(musicPower, musicPower, musicPower);
    }

    
}
