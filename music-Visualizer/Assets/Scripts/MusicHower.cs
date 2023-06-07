using UnityEngine;

public class MusicHower : MonoBehaviour
{
    private AudioSource audioSource;
    public GameObject image;

    void Start()
    {    
        audioSource = GetComponent<AudioSource>();
    }

   public void OnMouseEnter()
    {
        audioSource.Play();
        image.SetActive(true);
    }
    public void OnMouseExit()
    {
        audioSource.Stop();
        audioSource.time = 0f;
        image.SetActive(false);
    }
}
