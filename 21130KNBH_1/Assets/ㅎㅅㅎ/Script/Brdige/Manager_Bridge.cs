using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class Manager_Bridge : MonoBehaviour
{
    public GameObject bridge_Pannel;
    public GameObject gameClear_Pannel;
    public GameObject gameOver_Pannel;

    public GameObject player;
    public PhotonView PV;

    private void Start()
    {
        //PV = GetComponent<PhotonView>();
    }
    // Update is called once per frame
    void Update()
    {
        if (PV.IsMine)
        {
            if (player.transform.position.y <= -12)
            {
                bridge_Pannel.SetActive(true);

                if (player.transform.position.y >= -5)
                {
                    gameOver_Pannel.SetActive(false);
                }
                else
                {
                    gameOver_Pannel.SetActive(true);
                }
            }
        }
    }

    //돌아가기 버튼 함수 
    public void Back_Btn()
    {
        Launcher.Instance.player_DisConnect();
    }
}
