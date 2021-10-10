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
         PushBall();
    }

    // Update is called once per frame
    void Update()
    {
        
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
