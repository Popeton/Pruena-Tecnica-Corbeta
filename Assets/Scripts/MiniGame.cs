using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class MiniGame : MonoBehaviour
{
    [SerializeField] private TMP_Text[] preguntas;
    [SerializeField] private TMP_Text[] respuestas;
    [SerializeField] private TMP_Text[] slots;
    [SerializeField] private GameObject[] buttons;

    private int preguntaActual;
    void Start()
    {
        preguntaActual = 1; 
    }

    // Update is called once per frame
    void Update()
    {
        if (preguntaActual == 1)
        {
            preguntas[0].gameObject.SetActive(true);
            respuestas[0].gameObject.SetActive(true);
            respuestas[1].gameObject.SetActive(true);
            respuestas[2].gameObject.SetActive(true);
            
        }
        else
        {
            preguntas[0].gameObject.SetActive(false);
            respuestas[0].gameObject.SetActive(false);
            respuestas[1].gameObject.SetActive(false);
            respuestas[2].gameObject.SetActive(false);
            preguntas[1].gameObject.SetActive(true);
            respuestas[3].gameObject.SetActive(true);
            respuestas[4].gameObject.SetActive(true);
            respuestas[5].gameObject.SetActive(true );
        }
    }

   public void CheckRespuesta1 (string letra)
   {
        if(preguntaActual == 1 && letra=="c")
        {
            
            slots[0].gameObject.SetActive(true);
            slots[1].gameObject.SetActive(false);
        }
        else
        {
            slots[0].gameObject.SetActive(false);
            slots[1].gameObject.SetActive(true);
        }

        
   }

    public void CheckRespuesta2(string letra)
    {
        if (preguntaActual == 2 && letra == "a")
        {

            slots[0].gameObject.SetActive(true);
            slots[1].gameObject.SetActive(false);
        }
        else
        {
            slots[0].gameObject.SetActive(false);
            slots[1].gameObject.SetActive(true);
        }


    }



    public void SiguientePregunta()
    {
        slots[0].gameObject.SetActive(false);
        slots[1].gameObject.SetActive(false);
        preguntaActual =2;
        buttons[0].gameObject.SetActive(false);
        buttons[1].gameObject.SetActive(false);
        buttons[2].gameObject.SetActive(false);
        buttons[3].gameObject.SetActive(true);
        buttons[4].gameObject.SetActive(true);
        buttons[5].gameObject.SetActive(true);
    }
}
