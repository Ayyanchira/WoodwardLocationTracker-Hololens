using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class CustomNetworkManager : NetworkManager {

    public GameObject playerPrefab;
    public void connectAsClient()
    {
        NetworkManager.singleton.StartClient();
    }

    public override void OnClientConnect(NetworkConnection conn)
    {
        short playerCount = (System.Int16)conn.playerControllers.Count;
        ClientScene.AddPlayer(conn, playerCount);
        base.OnClientConnect(conn);
    }
}
