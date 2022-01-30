using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ShowText : MonoBehaviour
{
    //public static ShowText Instance;

    //private void Awake()
    //{
    //    Instance = this;
    //}

    //public void Show(string str) {
    //    GetComponent<Text>().text = str;
    //}

    private void Awake()
    {
        gameObject.SetActive(false);
        EventCenter.AddListener<string>(EventType.ShowText, Show);
    }

    private void OnDestroy()
    {
        EventCenter.RemoveListener<string>(EventType.ShowText, Show);
    }

    private void Show(string str)
    {
        gameObject.SetActive(true);
        GetComponent<Text>().text = str;
    }
}
