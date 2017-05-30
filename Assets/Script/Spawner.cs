using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    public float maxXSpawn;
    public float minXSpawn;
    public float zSpawn= 529f;
    public float launchRangeMinTime;
    public float launchRangeMaxTime;
    public GameObject[] enemyPrefab;
    //public GameObject enemyPrefab2;

    private float _nextLaunchTime;
    private float _ySpawn = -27.0f;
    private GameController _gameController;
    private Quaternion _launchRotation;

    void Start()
    {
        SetNextLaunch();
        _gameController = this.GetComponent<GameController>();
        _launchRotation = Quaternion.Euler(new Vector3(0.0f, 180.0f, 0.0f));
    }

    void SetNextLaunch()
    {
        float launchInterval = Random.Range(launchRangeMinTime, launchRangeMaxTime);
        _nextLaunchTime = Time.time + launchInterval;
    }


    void Update()
    {
        if (Time.time > _nextLaunchTime/* && !_gameController.isGameOver && _gameController.isMenu == 1*/)
        {
            Vector3 launchPosition = new Vector3(Random.Range(minXSpawn, maxXSpawn), _ySpawn, zSpawn);
            Instantiate(enemyPrefab[UnityEngine.Random.Range(0, enemyPrefab.Length)], launchPosition, _launchRotation);
            SetNextLaunch();
        }
    }
}