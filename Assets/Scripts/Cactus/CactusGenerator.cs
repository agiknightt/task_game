using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CactusGenerator : ObjectPool
{
    [SerializeField] private GameObject _template;
    [SerializeField] private float _secondBetweenSpawn;
    [SerializeField] private float _positionY;


    private float _elapsedTime = 0;

    private void Start()
    {
        Initalize(_template);
    }

    private void Update()
    {
        _elapsedTime += Time.deltaTime;

        if (_elapsedTime > _secondBetweenSpawn)
        {
            if (TryGetObject(out GameObject cactus))
            {
                _elapsedTime = 0;

                Vector3 spawnPoint = new Vector3(transform.position.x, _positionY, transform.position.z);
                cactus.gameObject.SetActive(true);

                cactus.transform.position = spawnPoint;

                DisableObjectAdroadScreen();
            }
        }
    }    
}
