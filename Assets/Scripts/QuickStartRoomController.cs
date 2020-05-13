using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class QuickStartRoomController : MonoBehaviourPunCallbacks
{
    [SerializeField]
    private int mulitplayerSceneIndex; //Number for the build index to the multiplayer scene

    public override void OnEnable()
    {
        PhotonNetwork.AddCallbackTarget(this);
    }
    public override void OnDisable()
    {
        PhotonNetwork.RemoveCallbackTarget(this);
    }

    public override void OnJoinedRoom()
    {
        UnityEngine.Debug.Log("Joined Game");
        StartGame();
    }
    private void StartGame()
    {
        if (PhotonNetwork.IsMasterClient)
        {
            UnityEngine.Debug.Log("Starting game");
            PhotonNetwork.LoadLevel(mulitplayerSceneIndex);
        }
    }

}
