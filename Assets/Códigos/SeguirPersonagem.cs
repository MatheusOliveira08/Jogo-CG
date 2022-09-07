using UnityEngine;

public class SeguirPersonagem : MonoBehaviour
{
    public Transform personagem;
    public Vector3 deslocamento;

    // Update is called once per frame
    void Update()
    {
        transform.position = personagem.position + deslocamento;
    }
}
