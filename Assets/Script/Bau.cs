using UnityEngine;

public class Bau : MonoBehaviour
{ 
[SerializeField] private int numeroBau;
[SerializeField] private bool bauTrancado = false;
private Animator animator;

private void Start()
{
    animator = GetComponent<Animator>();
}
public void AbrirPorta(int nChave = 0)
{
    if (nChave == 0 && !bauTrancado)
    {
        animator.SetTrigger("abrir");
    }
    else if (nChave == numeroBau && bauTrancado)
    {
        animator.SetTrigger("abrir");
        bauTrancado = false;
    }
}
public bool EstaTrancada()
{
    return bauTrancado;
}
}
