using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorDeMoeda : MonoBehaviour
{
    public GameObject coinParticle;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Jogador"))
        {
            Pontuacao pontos = other.GetComponent<Pontuacao>();
            pontos.AddPoint();
            Instantiate(coinParticle,
                this.transform.position,
                Quaternion.Euler(-90,0,0)
            );
            Destroy(this.gameObject);
        }
    }
}
