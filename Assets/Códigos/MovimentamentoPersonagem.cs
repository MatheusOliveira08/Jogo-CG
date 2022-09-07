using UnityEngine;

public class MovimentamentoPersonagem : MonoBehaviour
{
    public Rigidbody rb;
    public float forçaPraFrente = 2000f;
    public float forçaProLado = 500f;
    public float forçaPraCima= 500f;

    // Start é chamado sempre antes do primeiro frame
    void Start()
    {
        
    }

    // Update é chamado uma vez por frame (então ele vai ser chamado constantemente)
    // Quando for mexer com física e derivados, uitilize o FixedUpdate, ele é melhor que o Update

    void FixedUpdate() //esse Time.deltaTime faz com que quanto maior for o FrameRate do pc, menor vai ser o valor
    {
        if (Input.GetKey("w"))
        {
            rb.AddForce(0, 0, forçaPraFrente * Time.deltaTime);
        }

        if (Input.GetKey("s"))
        {
            rb.AddForce(0, 0, -forçaPraFrente * Time.deltaTime);
        }

        if (Input.GetKey("d"))
        {
            rb.AddForce(forçaProLado * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(-forçaProLado * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("e") == true)
        {
            rb.AddForce(0, forçaPraCima * Time.deltaTime, 0);

            if(forçaPraCima > 900)
            {
                forçaPraCima = 0f;           
            }
        }
    }

}
