using UnityEngine;
using UnityEngine.SceneManagement;

public class Lunar : MonoBehaviour
{
    public float forçaMuitoAlta = 2000f; 
    //private Rigidbody rb;
    
    void Start()
    {
        //rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //rb.AddForce(Vector3.up * forçaMuitoAlta, ForceMode.Impulse);
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // Aplica o impulso no personagem
            Rigidbody rb = other.GetComponent<Rigidbody>();
            if (rb != null)
            {
                rb.AddForce(Vector3.up * forçaMuitoAlta, ForceMode.Impulse);
            }

            // Aguarda alguns segundos para carregar a cena lunar
            StartCoroutine(CarregarCenaLunar());
        }
    }

    private System.Collections.IEnumerator CarregarCenaLunar()
    {
        yield return new WaitForSeconds(2.5f); // dá tempo do personagem subir
        SceneManager.LoadScene("CenaLunar"); 
    }

}
