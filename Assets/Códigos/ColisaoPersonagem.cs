using UnityEngine;

public class ColisaoPersonagem : MonoBehaviour
{
    public MovimentamentoPersonagem movimento;
    void OnCollisionEnter(Collision infoColisao)
    {
        if (infoColisao.collider.tag == "Obstaculo")
        {
            movimento.enabled = false;
        }
    }
}
