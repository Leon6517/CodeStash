using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//using DG.Tweening;


public class BtnClick : MonoBehaviour
{
    //public Text text;
    private void Awake()
    {
        GetComponent<Button>().onClick.AddListener(() =>
        {
            //text.text = "Welcome to my space";
            EventCenter.Broadcast(EventType.ShowText,"Welcome to my space");
            //ShowText.Instance.Show("Welcome to my space");
        });
    }


}
