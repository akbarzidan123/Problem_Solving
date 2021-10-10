using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBall_2 : MonoBehaviour
{
    public float forceX;// dorong bola terhadap sumbu X
    public float forceY;// dorong bola terhadap sumbu Y
    private Rigidbody2D rb;//inisialisasi componen rigidbody
    // Start is called before the first frame update
    void Start()
    {
         rb = GetComponent<Rigidbody2D>();
        //  PushBall();
    }

    // Update is called once per frame
    void Update()
    {
        //Soal nomer 4
        //GetKeyDown = Sekali pencet tombol, Getkey = Selama tombol dipencet(hold/press)
        Vector2 velocity = rb.velocity;
        //Input atas maka bola ke atas
        
        if(Input.GetKey(KeyCode.UpArrow))
        {
            velocity.y = forceY;
        }
        // input bawah maka bola akan kebawah
        else if(Input.GetKey(KeyCode.DownArrow))
        {
            velocity.y = -forceY;
        }
        // Kalo ga mencet apa apa bola balik ke speed 0
        else
        {
            velocity.y = 0;   
        }
        // input kanan maka bola akan kekanan
        if(Input.GetKey(KeyCode.RightArrow))
        {
            velocity.x = forceX;
        }
        //input kiri maka bola akan kekiri        
        else if(Input.GetKey(KeyCode.LeftArrow))
        {
            velocity.x = -forceX;
        }
        // Kalo ga mencet apa apa bola balik ke speed 0
        else
        {
            velocity.x = 0;
        }
        //End soal nomer 4
        rb.velocity = velocity;
    }
    void PushBall()
    {
        float directY = Random.Range(-forceY,forceY);//Masukkan gaya terhadap sumbu Y
        float leftOrRight = Random.Range(0,2);// random dari 0-1, semisal nila 0 maka kekiri semisal 1 kekanan

        if(leftOrRight < 1)
        {
            rb.AddForce(new Vector2(-forceX, directY));//forceX bernilai (-) karna bola bergerak kekiri
        }
        else
        {
            rb.AddForce(new Vector2(forceX, directY));//forceX bernilai (+) karna bola bergerak kekanan
        }
    }
}
