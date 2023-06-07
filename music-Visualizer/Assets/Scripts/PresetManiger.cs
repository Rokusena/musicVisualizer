using UnityEngine;

public class PresetManiger : MonoBehaviour
{
    public GameObject spawnwe;
    public GameObject cube;
    public Material blue;
    public Material yELLow;
    public Material green;
    public Material red;


    private void Start()
    {
            int a1 = PlayerPrefs.GetInt("backgroundactive");
        if(a1 == 1)
        {
            spawnwe.SetActive(true);
        }
        else
        {
            spawnwe.SetActive(false);
        }
     

      




    }





}
