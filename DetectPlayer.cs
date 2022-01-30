using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectPlayer : MonoBehaviour
{
    [SerializeField] private Material alarm;
    [SerializeField] private Material attention;
    [SerializeField] private Material allClear;

    SpriteRenderer renderer;
    Sensor sensor_1;
    Sensor sensor_2;


    // Start is called before the first frame update
    void Start()
    {
        renderer = this.GetComponent<SpriteRenderer>();
        sensor_1 = this.transform.Find("Inner_Area_of_Effect").GetComponent<Sensor>();
        sensor_2 = this.transform.Find("Outer_Area_of_Effect").GetComponent<Sensor>();

    }

    // Update is called once per frame
    void Update()
    {
        if (sensor_1.isDetecting)
        {
            renderer.material = alarm;
        } 
        else if (sensor_2.isDetecting)
        {
            renderer.material = attention;
        }
        else { 
            renderer.material = allClear;
        }

    }
}
