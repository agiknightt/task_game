using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BollTracker : MonoBehaviour
{
    [SerializeField] private Boll _boll;
    [SerializeField] private float _xOffset;

    private void Update()
    {
        transform.position = new Vector3(_boll.transform.position.x - _xOffset, 0, transform.position.z);
    }
}
