using UnityEngine;

public class PlayerMoviment : MonoBehaviour

{
    private Rigidbody rb;
    private float inputH;
    private float inputV;
    private Animator animator;
    private bool estaNoChao = true;
    private Vector3 anguloRotacao = new Vector3(0, 90, 0);
    [SerializeField] private float velocidade;
    [SerializeField] private float forcaPulo;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        andar();
        girar();
        pular();
    }

    private void andar()
    {
        inputV = Input.GetAxis("Vertical");
        Vector3 moveDirection = transform.forward * inputV;
        Vector3 moveForward = rb.position + moveDirection * velocidade * Time.deltaTime;
        rb.MovePosition(moveForward);

        if (Input.GetKey(KeyCode.W))
        {
            animator.SetBool("andar", true);
            animator.SetBool("andarTras", false);
        }
        else if(Input.GetKey(KeyCode.S)) 
        {
            animator.SetBool("andarTras", true);
            animator.SetBool("andar", false);
        }
        else
        {
            animator.SetBool("andarTras", false);
            animator.SetBool("andar", false);
        }
    }

    private void girar()
    {
        inputH = Input.GetAxis("Horizontal");
        Quaternion deltaRotation =
            Quaternion.Euler(anguloRotacao * inputH * Time.deltaTime);
        rb.MoveRotation(rb.rotation * deltaRotation);

        if (Input.GetKey(KeyCode.A) ||
                    Input.GetKey(KeyCode.D) ||
                        Input.GetKey(KeyCode.LeftArrow) ||
                            Input.GetKey(KeyCode.RightArrow))
        {
            animator.SetBool("andar", true);
        }
        
    }

    private void pular()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector3.up * forcaPulo, ForceMode.Impulse);
            estaNoChao = false;
            animator.SetTrigger("pular");
        }
    }

    private void correr()
    {

    }

    private void morrer()
    {

    }

    private void Iinteragir()
    {

    }

    private void pegar()
    {

    }
    private void atacar()
    {

    }
    private void perfurar()
    {

    }
}
