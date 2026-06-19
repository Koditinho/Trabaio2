using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorDeMoeda : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Jogador"))
        {
            Pontuacao pontos = other.GetComponent<Pontuacao>();
            pontos.AddPoint();
            Destroy(this.gameObject);
        }
    }
}
