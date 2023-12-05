using Photon.Pun;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawnerplayer : MonoBehaviour
{
    [SerializeField] private GameObject playerpref;
    [SerializeField] private float minX;
    [SerializeField] private float maxX;
    [SerializeField] private float minZ;
    [SerializeField] private float maxZ;
    // Start is called before the first frame update
    void Start()
    {
        Vector3 randomPosition = new Vector3(Random.Range(minX, maxX), 0.51f, Random.Range(minZ, maxZ));
        PhotonNetwork.Instantiate(playerpref.name, randomPosition, Quaternion.identity);
    }
}
