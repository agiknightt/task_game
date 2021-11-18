using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    [SerializeField] private Boll _boll;
    [SerializeField] private Text _score;

    private void OnEnable()
    {
        _boll.ChangedScore += OnScoreChanged;
    }
    private void OnDisable()
    {
        _boll.ChangedScore -= OnScoreChanged;
    }
    private void OnScoreChanged(int score)
    {
        _score.text = score.ToString();
    }
}
