using UnityEngine;

public class AudioAnalyzer : MonoBehaviour
{
   

    public int numSamples = 1024; 
    public float updateInterval = 0.1f; 
    public float sampleRate; 
    public float updateTimer; 
   

    public float[] spectrumData; 
    private float[] spectrumBuffer; 
    private float[] spectrumValues; 

    private void Start()
    {

       
        sampleRate = AudioSettings.outputSampleRate;

        
        spectrumData = new float[numSamples];
        spectrumBuffer = new float[numSamples];
        spectrumValues = new float[numSamples / 2];
    }

    private void Update()
    {
       
        updateTimer += Time.deltaTime;

        
        if (updateTimer >= updateInterval)
        {
            
            updateTimer = 0f;

            
            AnalyzeAudio();
        }
    }

    private void AnalyzeAudio()
    {
        
        GetComponent<AudioSource>().GetSpectrumData(spectrumData, 0, FFTWindow.BlackmanHarris);

        
        for (int i = 0; i < numSamples; i++)
        {
            spectrumBuffer[i] = Mathf.Max(spectrumBuffer[i] * 0.8f, spectrumData[i]);
            spectrumData[i] = spectrumBuffer[i];
        }

        
        for (int i = 0; i < spectrumValues.Length; i++)
        {
            
            float average = 0f;
            int sampleCount = (int)Mathf.Pow(2, i) * 2;
            for (int j = 0; j < 1024; j++)
            {
                average += spectrumData[j] * (j + 1);
            }
            average /= sampleCount;

            
            spectrumValues[i] = Mathf.Clamp01(average * (sampleCount / sampleRate));
        }

        
    }
}


