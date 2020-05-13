using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using System;
using System.IO;

public class PhotonPlayerScript : MonoBehaviour
{

    private PhotonView PV;
    public GameObject myAvatar;
    // Start is called before the first frame update
    void Start()
    {
        PV = GetComponent<PhotonView>();
        int spawnPicker = System.Random.Range(0,GameSetUp.GS.spawnpoints.Length);
        if (PV.IsMine)
        {
           myAvatar = PhotonNetwork.Instantiate(Path.Combine("PhotonPrefabs", "PlayerAvatar"), GameSetUp.GS.spawnPoints[spawnPicker].position, GameSetUp.GS.spawnPoints[spawnPicker].rotation,0);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
