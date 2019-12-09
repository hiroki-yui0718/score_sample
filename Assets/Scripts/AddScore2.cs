using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddScore2 : MonoBehaviour
{
    public static int score = 0;
    public static bool addBool = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.X))
        {
            score = 100;
            Debug.Log("押下2");
            Debug.Log(score.ToString());
            addBool = true;　
        }
        
    }
}
