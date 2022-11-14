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

        Mejora1text.text = "Mejora 1 (+1) (25): " + Mejora1Precio+" #";
        Mejora2text.text = "Mejora 2 (Aumento) (125): " + Mejora2Precio + " #";
    }

    //Funcionamiento principal del clicker
    public void Hit()
    {
        currentScore += hitPower;
    }

    //MEJORAS

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
        if (currentScore >= Mejora2Precio)
        {
            currentScore -= Mejora2Precio;
            x +=5;
            Mejora1Precio +=125;
        }
    }
}
