using UnityEngine;

public class MovimentamentoPersonagem : MonoBehaviour
{
    public Rigidbody rb;
    public float for�aPraFrente = 2000f;
    public float for�aProLado = 500f;
    public float for�aPraCima= 500f;

    // Start � chamado sempre antes do primeiro frame
    void Start()
    {
        
    }

    // Update � chamado uma vez por frame (ent�o ele vai ser chamado constantemente)
    // Quando for mexer com f�sica e derivados, uitilize o FixedUpdate, ele � melhor que o Update

    void FixedUpdate() //esse Time.deltaTime faz com que quanto maior for o FrameRate do pc, menor vai ser o valor
    {
        if (Input.GetKey("w"))
        {
            rb.AddForce(0, 0, for�aPraFrente * Time.deltaTime);
        }

        if (Input.GetKey("s"))
        {
            rb.AddForce(0, 0, -for�aPraFrente * Time.deltaTime);
        }

        if (Input.GetKey("d"))
        {
            rb.AddForce(for�aProLado * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(-for�aProLado * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("e") == true)
        {
            rb.AddForce(0, for�aPraCima * Time.deltaTime, 0);

            if(for�aPraCima > 900)
            {
                for�aPraCima = 0f;           
            }
        }
    }

}
