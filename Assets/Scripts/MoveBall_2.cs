using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MoveBall_2 : MonoBehaviour
{
    public float forceX;// dorong bola terhadap sumbu X
    public float forceY;// dorong bola terhadap sumbu Y
    private GameObject ball;
    private Rigidbody2D rb;//inisialisasi componen rigidbody
    public float moveSpeed = 10f;
    // Start is called before the first frame update
    void Start()
    {
        ball = GameObject.Find("Ball");
         rb = GetComponent<Rigidbody2D>();
         if(SceneManager.GetActiveScene().buildIndex == 2 || SceneManager.GetActiveScene().buildIndex == 3)
         {
            PushBall();
         }
    }

    // Update is called once per frame
    void Update()
    {
        //Soal nomer 4
        //GetKeyDown = Sekali pencet tombol, Getkey = Selama tombol dipencet(hold/press)
        if(SceneManager.GetActiveScene().buildIndex == 4 || SceneManager.GetActiveScene().buildIndex == 9)
        {

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
        if(SceneManager.GetActiveScene().buildIndex == 5 || SceneManager.GetActiveScene().buildIndex == 6||SceneManager.GetActiveScene().buildIndex == 7|| SceneManager.GetActiveScene().buildIndex == 8)
        {
            //Soal nomor 5
            Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            transform.position = Vector2.MoveTowards(transform.position, mousePosition, moveSpeed * Time.deltaTime);
            //End soal nomor 5
        }
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

     private void OnTriggerEnter2D(Collider2D other)
    {
        //Tele dari kanan ke kiri
        if(other.name == "Right")
        {
            Debug.Log("Teleport");
            ball.transform.position = new Vector2(-8.2f,ball.transform.position.y);
        }
        // Tele dari kiri ke kanan
        if(other.name == "Left")
        {
            Debug.Log("Teleport");
            ball.transform.position = new Vector2(8.2f,ball.transform.position.y);
        }    
        // Tele dari atas ke bawah
        if(other.name == "Up")
        {
            Debug.Log("Teleport");
            ball.transform.position = new Vector2(ball.transform.position.x,-4.05f);
        }    
        // Tele dari bawah ke atas
        if(other.name == "Down")
        {
            Debug.Log("Teleport");
            ball.transform.position = new Vector2(ball.transform.position.x,4.05f);
        }        
    }
}
