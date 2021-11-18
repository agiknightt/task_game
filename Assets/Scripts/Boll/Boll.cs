using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

[RequireComponent(typeof(BollMover))]
public class Boll : MonoBehaviour
{
    private Camera _camera;
    private BollMover _mover;
    private int _score;
    public event UnityAction GameOver;
    public event UnityAction<int> ChangedScore;
    private void Start()
    {
        _mover = GetComponent<BollMover>();
        _camera = Camera.main;
    }

    public void ResetPlayer()
    {
        _score = 0;
        _camera.transform.position = new Vector3(0, 0, -10);
        _mover.ResetBoll();
    }

    public void IncreaseScore()
    {        
        _score ++;
        ChangedScore?.Invoke(_score);
    }
    public void Die()
    {
        GameOver?.Invoke();
        Time.timeScale = 0;
    }
}
