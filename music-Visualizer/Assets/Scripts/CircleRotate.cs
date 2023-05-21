using UnityEngine;

public class CircleRotate : MonoBehaviour
{
    public float rotationSpeed = 10.0f;
    public float amplitudeMultiplier = 10.0f;
    public AudioVisualizer visualizer;

    private void Update()
    {
        float amplitude = visualizer.avarage * amplitudeMultiplier;
        transform.Rotate(0, 0, amplitude * rotationSpeed * Time.deltaTime);
    }
}
