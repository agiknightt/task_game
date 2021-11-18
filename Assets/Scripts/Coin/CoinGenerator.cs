using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinGenerator : ObjectPool
{
    [SerializeField] private GameObject _template;
    [SerializeField] private float _secondBetweenSpawn;
    [SerializeField] private float _maxSpawnPositionY;
    [SerializeField] private float _minSpawnPositionY;

    private float _elapsedTime = 0;

    private void Start()
    {
        Initalize(_template);
    }

    private void Update()
    {
        _elapsedTime += Time.deltaTime;

        if(_elapsedTime > _secondBetweenSpawn)
        {
            if (TryGetObject(out GameObject coin))
            {
                _elapsedTime = 0;

                float spawnPositionY = Random.Range(_minSpawnPositionY, _maxSpawnPositionY);
                Vector3 spawnPoint = new Vector3(transform.position.x, spawnPositionY, transform.position.z);
                ResetCoins(coin);

                coin.transform.position = spawnPoint;

                DisableObjectAdroadScreen();
            }
        }
    }
    private void ResetCoins(GameObject coin)
    {
        coin.gameObject.SetActive(true);

        foreach (Transform item in coin.transform)
        {
            item.gameObject.SetActive(true);            
        }
    }
}
