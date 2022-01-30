using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestingEvents : MonoBehaviour
{
    public event EventHandler OnSpacePressed;
    // Start is called before the first frame update
    void Start()
    {
        //OnSpacePressed += TestingEvents_OnSpacePressed;
    }

    //private void TestingEvents_OnSpacePressed(object sender, EventArgs e)
    //{
    //    throw new NotImplementedException();
    //}

    //private void Testing_OnSpacePressed(object sender, EventArgs e)
    //{
    //    Debug.Log("Space Pressed !");
    //}

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) {
            //只要subscriber按下Space, 就触发事件
            //if(OnSpacePressed != null)
            //    OnSpacePressed(this,EventArgs.Empty);
            OnSpacePressed?.Invoke(this, EventArgs.Empty);
        }
        
    }
}
