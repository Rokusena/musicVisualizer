using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleSpawner : MonoBehaviour
{
    public GameObject prefab;
    public float range;
    public int count;
    public float speed;
    void Start()
    {
        for(var angle = 0; angle<360; angle+=360/count)
        {
            var obj = Instantiate(prefab, transform);
            var x = Mathf.Cos(angle * Mathf.Deg2Rad);
            var y = Mathf.Sin(angle * Mathf.Deg2Rad);
            obj.transform.localPosition = new Vector3(x* range, y* range, 0);
        }
    }
}
