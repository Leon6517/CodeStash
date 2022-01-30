using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestingEventSubscriber : MonoBehaviour
{
    void Start()
    {
        TestingEvents testingEvents = GetComponent<TestingEvents>();
        //subscribe
        testingEvents.OnSpacePressed += TestingEvents_OnSpacePressed;
    }

    private void TestingEvents_OnSpacePressed(object sender, System.EventArgs e)
    {
        Debug.Log("Space Pressed");
        TestingEvents testingEvents = GetComponent<TestingEvents>();
        //unsubscribe
        testingEvents.OnSpacePressed -= TestingEvents_OnSpacePressed;
    }
}
