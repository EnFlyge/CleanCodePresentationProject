using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// Публичный класс игрока
public class PlayerBad : MonoBehaviour
{
    // физика тела
    public Rigidbody2D player_telo;
    // коллизия тела
    public BoxCollider2D playerbody;


    // жизнь
    public int health = 100;
    // скорость игрока
    public Vector3 speedplayer;

    // скорость по координате
    public float speedX;
    public float speedY;


    void Start()
    {
        
    }

    // проверка движения каждый кадр
    void Update()
    {
        Movement();
    }

    // движение
    void Movement()
    {
        float Fact = 10f;
        // направление движения
        speedX = Input.GetAxis("Horizontal") * Fact;
        speedY = Input.GetAxis("Vertical") * Fact;

        speedplayer = new Vector3(speedX, speedY, 0f);

        gameObject.GetComponent<Rigidbody2D>().velocity = speedplayer;
    }

}
