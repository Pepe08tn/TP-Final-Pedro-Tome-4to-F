using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AparecerObjetos : MonoBehaviour
{
    public GameObject[] Objetos;
    public int currentIndex = -1;

    // Start is called before the first frame update
    void Start()
    {
        BorrarObejetosIniciales();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.RightArrow))
        {
            currentIndex++; 
            if(currentIndex >= Objetos.Length)
            {
                currentIndex = 0;
            }
            BorrarObejetosIniciales();
            ActivarConElIndex(currentIndex);
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            currentIndex--;
            if (currentIndex >= Objetos.Length)
            {
                currentIndex =+ 5;
            }
            BorrarObejetosIniciales();
            ActivarConElIndex(currentIndex);
        }
    }

    void BorrarObejetosIniciales()
    {
        for(int i = 0; i < Objetos.Length; i++)
        {
            Objetos[i].SetActive(false);
        }
    }
    void ActivarConElIndex(int index)
    {
        Objetos[index].SetActive(true);
    }
}
