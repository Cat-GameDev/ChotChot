using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public static int pinCount;
    public Text text;
    void Start()
    {
        pinCount= 0;
    }

    // Update is called once per frame
    void Update()
    {
        text.text = pinCount.ToString();
    }
}
