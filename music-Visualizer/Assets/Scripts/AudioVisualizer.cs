using UnityEngine;


public class AudioVisualizer : MonoBehaviour
{
    private AudioSource source;
    public AudioClip a1;
    public AudioClip a2;
    public AudioClip a3;
    public AudioClip a4;
    public AudioClip a5;
    public AudioClip a6;
    public AudioClip a7;
    public AudioClip a8;
    public AudioClip a9;
    public AudioClip a10;
    public AudioClip a11;
    public AudioClip a12;
    public AudioClip a13;
    public AudioClip a14;


    public float avarage;

    int songNumber;
    private AudioClip newSong;


    private void Start()
    {
        source = GetComponent<AudioSource>();

        songNumber = PlayerPrefs.GetInt("SongNumber");
        ChangeSong();
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
        
    
    }

    void ChangeSong()
    {
        if(songNumber == 1 )
        {
           newSong = a1;
        }
        else if(songNumber == 2)
        {
            newSong = a2;
        }
        else if (songNumber == 3)
        {
            newSong = a3;
        }
        else if (songNumber == 4)
        {
            newSong = a4;
        }
        else if (songNumber == 5)
        {
            newSong = a5;
        }
        else if (songNumber == 6)
        {
            newSong = a6;
        }
        else if (songNumber == 7)
        {
            newSong = a7;
        }
        else if (songNumber == 8)
        {
            newSong = a8;
        }
        else if (songNumber == 9)
        {
            newSong = a9;
        }
        else if (songNumber == 10)
        {
            newSong = a10;
        }
        else if (songNumber == 11)
        {
            newSong = a11;
        }
        else if (songNumber == 12)
        {
            newSong = a12;
        }
        else if (songNumber == 13)
        {
            newSong = a13;
        }
        else if (songNumber == 14)
        {
            newSong = a14;
        }

        source.clip = newSong;
            source.Play();
        
       
    }
}
