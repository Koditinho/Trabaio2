using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Pontuacao : MonoBehaviour
{
    float pontos = 0;
    public TextMeshProUGUI scoreText;

    public void AddPoint()
    {
        pontos++;
        scoreText.text = pontos.ToString();
    }

    void Start()
    {
        scoreText.text = "0";
    }
    // Update is called once per frame

}
