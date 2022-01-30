using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sensor : MonoBehaviour
{
    private Collider sensor;
    [SerializeField] private string tag = "Player";
    public bool isDetecting;
    private GameObject objectToFind;
    // Start is called before the first frame update
    void Start()
    {
        sensor = this.GetComponent<Collider>();
    }

    // Update is called once per frame
    void Update()
    {
        if (objectToFind == null)
        {
            isDetecting = false;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag(tag))
        { 
            isDetecting = true;
            objectToFind = collision.gameObject;
        }   
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag(tag))
        { 
            isDetecting = false;
            objectToFind = null;
        }

    }
}
