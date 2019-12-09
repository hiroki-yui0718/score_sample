using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using Photon.Pun;

public class ChangeScript : MonoBehaviourPunCallbacks
{
    private int score = 0;
    public Text text;
    // Start is called before the first frame update
    void Start()
    {
        
    }

   
    // Update is called once per framezzz
    void Update()
    {
        if (AddScore1.addBool == true || AddScore2.addBool == true) //④当たり判定
        {
            PhotonView photonView = GetComponent<PhotonView>(); //①必ずPhotonViewをマウンド
            if (photonView.IsMine == false) //②なぜかTrueにならない
            {
                Debug.Log("True1");
                photonView.RPC(nameof(ScoreSync), RpcTarget.All, AddScore1.score, AddScore2.score);
            }
        }
        
    }
    [PunRPC]
    void ScoreSync(int score1,int score2) 
    {
        Debug.Log("True2");
        score += score1 + score2;　//③変数+変化を指定
        text.text = score.ToString();
        AddScore1.addBool = false; //⑤当たり判定・足し算初期化
        AddScore2.addBool = false;
        AddScore1.score = 0; 
        AddScore2.score = 0;
    }
    
}
