using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// ��������� ����� ������
public class PlayerBad : MonoBehaviour
{
    // ������ ����
    public Rigidbody2D player_telo;
    // �������� ����
    public BoxCollider2D playerbody;


    // �����
    public int health = 100;
    // �������� ������
    public Vector3 speedplayer;

    // �������� �� ����������
    public float speedX;
    public float speedY;


    void Start()
    {
        
    }

    // �������� �������� ������ ����
    void Update()
    {
        Movement();
    }

    // ��������
    void Movement()
    {
        float Fact = 10f;
        // ����������� ��������
        speedX = Input.GetAxis("Horizontal") * Fact;
        speedY = Input.GetAxis("Vertical") * Fact;

        speedplayer = new Vector3(speedX, speedY, 0f);

        gameObject.GetComponent<Rigidbody2D>().velocity = speedplayer;
    }

}
