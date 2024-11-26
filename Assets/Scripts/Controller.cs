using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    public float velocidadMov = 5.0f;
    public float velocidadRotacion = 200.0f;
    private Animator anim;
    public float x, y;
    void Start()
    {
        anim = GetComponent<Animator>();
        
    }

    void Update()
    {
        x = Input.GetAxis("Horizontal");
        y = Input.GetAxis("Vertical");
        transform.Rotate(0, x * Time.deltaTime * velocidadRotacion, 0);//rotación
        transform.Translate(0, 0, y * Time.deltaTime * velocidadMov);//movimiento

        anim.SetFloat("Velx", x);
        anim.SetFloat("Vely", y);
        
    }
}
