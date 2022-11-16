using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Juego : MonoBehaviour
{
    //Funcionamiento principal del clicker
    public Text scoreText;
    public float currentScore;
    public float hitPower;
    public float scoreIncreasedPerSecond;
    public float x;

    //MEJORAS
    public int Mejora1Precio;
    public Text Mejora1text;

    public int Mejora2Precio;
    public Text Mejora2text;

    //TIENDA
    public int Tienda1Precio;
    public Text Tienda1text;

    public int Tienda2Precio;
    public Text Tienda2text;

    public int Tienda3Precio;
    public Text Tienda3text;

    //DINERO
    public int Dinero1Precio;
    public Text Dinero1text;


    //Funcionamiento principal del clicker
    void Start() 
    {
        currentScore = 0;
        hitPower =1;
        scoreIncreasedPerSecond =1;
        x =0f;
    }

    //Funcionamiento principal del clicker
    void Update()
    {
        scoreText.text = (int)currentScore + " #";
        scoreIncreasedPerSecond = x * Time.deltaTime;
        currentScore = currentScore + scoreIncreasedPerSecond;

        // MEJORAS

        Mejora1text.text = "Mejora (+1): " +Mejora1Precio+" #";
        Mejora2text.text = "Mejora (+5): " +Mejora2Precio+" #";

        //TIENDA

        Tienda1text.text = "Cañon: " + Tienda1Precio + " #";
        Tienda2text.text = "Pistola: " + Tienda2Precio + " #";
        Tienda3text.text = "M-98: " + Tienda3Precio + " #";

        //DINERO

        Dinero1text.text = "Dinero: " + Dinero1Precio + " $";
       
    }

    //Funcionamiento principal del clicker
    public void Hit()
    {
        currentScore += hitPower;
    }

    //MEJORAS-CODIGOS

    public void Mejora1() 
    {
        if(currentScore>=Mejora1Precio)
        {
            currentScore -= Mejora1Precio;
            x +=1;
            Mejora1Precio +=25;
        }
    }
    public void Mejora2()
    {
        if (currentScore>=Mejora2Precio)
        {
            currentScore -= Mejora2Precio;
            x +=5;
            Mejora2Precio +=125;
        }
    }

    //TIENDA-CODIGOS
    public void Tienda1()
    {
        if (currentScore>=Tienda1Precio)
        {
            currentScore -= Tienda1Precio;
            
            Dinero1Precio +=25;
        }
    }

    public void Tienda2()
    {
        if (currentScore>=Tienda2Precio)
        {
            currentScore -= Tienda2Precio;

            Dinero1Precio +=50;
        }
    }

    public void Tienda3()
    {
        if (currentScore>=Tienda3Precio)
        {
            currentScore -= Tienda3Precio;

            Dinero1Precio +=100;
        }
    }
}
