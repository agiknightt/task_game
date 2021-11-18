using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class BollMover : MonoBehaviour
{
    [SerializeField] private Vector3 _startPosition;
    [SerializeField] private float _speed;
    [SerializeField] private float _tapForce;

    private Rigidbody2D _rigidbody;

    private void Start()
    {
        transform.position = _startPosition;
        _rigidbody = GetComponent<Rigidbody2D>();

        ResetBoll();
    }
    private void Update()
    {
        transform.position += new Vector3(_speed * Time.deltaTime, 0,0);
        
        if (Input.GetMouseButtonDown(0) && _startPosition.y >= transform.position.y)
        {
            _rigidbody.velocity = new Vector2(_speed, _startPosition.y);
            _rigidbody.AddForce(Vector2.up * _tapForce, ForceMode2D.Force);
        }
    }

    public void ResetBoll()
    {
        transform.position = _startPosition;
        _rigidbody.velocity = Vector2.zero;
    }
}
