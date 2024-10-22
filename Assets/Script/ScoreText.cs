using System.Collections;
using System.Collections.Generic;
using TMPro; // TextMeshProUGUI »ç¿ë
using UnityEngine;
using UnityEngine.UI;

public class ScoreText : MonoBehaviour
{
    public ScoreButton scoreButton;
    private TextMeshProUGUI scoreText;
    void Awake()
    {
        scoreText = GetComponent<TextMeshProUGUI>();

        scoreButton.scoreButton.onClick.AddListener(RefreshUI);
    }
    public void RefreshUI()
    {
        scoreText.text = $"Score : {scoreButton.score}";
    }
}
