using System.Collections;
using System.Collections.Generic;
using Photon.Pun;
using UnityEngine;

public class AddScore1 : MonoBehaviourPunCallbacks
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
        if (Input.GetKeyDown(KeyCode.Z))
        {
            score = 50;
            Debug.Log("押下1");
            Debug.Log(score.ToString());
            addBool = true;
        }
    }
}
