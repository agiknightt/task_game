using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Boll))]
public class BollCollisionHandler : MonoBehaviour
{
    private Boll _boll;

    private void Start()
    {
        _boll = GetComponent<Boll>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent(out Coin coin))
        {
            _boll.IncreaseScore();
            coin.gameObject.SetActive(false);
        }
        if(collision.TryGetComponent(out Cactus cactus))
        {
            _boll.Die();
        }
    }
}
