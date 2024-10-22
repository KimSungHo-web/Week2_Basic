using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreButton : MonoBehaviour
{
    public Button scoreButton;
    public int score = 0;
    public Action<int> OnScoreChanged;
    void Awake()
    {
        scoreButton = GetComponent<Button>();
        scoreButton.onClick.AddListener(PointUp);
    }

    public void PointUp()
    {
        score += 1;
        Debug.Log(score);
        OnScoreChanged.Invoke(score);
    }
}