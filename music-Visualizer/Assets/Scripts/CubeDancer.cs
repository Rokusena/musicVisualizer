using UnityEngine;

public class CubeDancer : MonoBehaviour
{
    public float size = 1;
    public float power = 2;
    public float shrinkspeed = 1;
    private float finalSize;

    public AudioVisualizer visualizer;
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
