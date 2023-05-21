using UnityEngine;


public class AudioVisualizer : MonoBehaviour
{
    private AudioSource source;

   public float avarage;

    private void Start()
    {
        source = GetComponent<AudioSource>();
    }
    void Update()
    {
        float[] samples = new float[735];
        source.clip.GetData(samples, source.timeSamples);

        float sum= 0;
       foreach(var sample in samples)
        {
            sum += Mathf.Abs(sample);
        }
        avarage = sum / 735;
        print(avarage);
    
    }
}
