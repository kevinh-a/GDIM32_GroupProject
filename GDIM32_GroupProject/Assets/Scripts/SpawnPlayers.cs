using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class SpawnPlayers : MonoBehaviour
{

    public GameObject playerPrefab;
    public GameObject player2Prefab;


    public float minX;
    public float maxX;
    public float minY;
    public float maxY;

    private void Start()
    {
        if (PhotonNetwork.CurrentRoom.PlayerCount == 1)
        {
            // If the current player is the first, instantiate playerPrefab
            Vector2 randomPosition = new Vector2(Random.Range(minX, maxX), Random.Range(minY, maxY));
            PhotonNetwork.Instantiate(playerPrefab.name, randomPosition, Quaternion.identity);
        }
        else if (PhotonNetwork.CurrentRoom.PlayerCount == 2)
        {
            // If the current player is the second, instantiate player2Prefab
            Vector2 randomPosition = new Vector2(Random.Range(minX, maxX), Random.Range(minY, maxY));
            PhotonNetwork.Instantiate(player2Prefab.name, randomPosition, Quaternion.identity);
        }
        //work on adding in second player 2 prefab
        //Vector2 randomPosition = new Vector2(Random.Range(minX, maxX), Random.Range(minY, maxY));
        //PhotonNetwork.Instantiate(playerPrefab.name, randomPosition, Quaternion.identity);

    }
}
