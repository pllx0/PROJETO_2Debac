using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : SingleTon<GameManager>
{

    public GameObject playerprefab;
    private GameObject player;
    public List<GameObject> enemies;


    public Transform Spawner;

    private void Start()
    {
        Init();
    }
    public void Init()
    {
        spawnPlayer();
    }

    public void spawnPlayer()
    {
        player = Instantiate(playerprefab);
        player.transform.position = Spawner.transform.position;
    }
}
