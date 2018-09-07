using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PlayerOne : MonoBehaviour
{
    public int lifes;
    public float speed;
    public Text lifesText;
    public GameObject wall;



    void Start()
    {
        lifes = 15;
    }

    void Update()
    {


        if (Input.GetKey(KeyCode.D))
        {
            gameObject.transform.position += Vector3.right * speed * Time.deltaTime;

        }
        if (Input.GetKey(KeyCode.A))
        {
            gameObject.transform.position += Vector3.left * speed * Time.deltaTime;

        }





    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Ball"))
        {
            other.gameObject.SetActive(false);
            lifes -= lifes;
            SetCountText();
        }
    }


    void SetCountText()
    {
        lifesText.text = "Puntaje: " + lifes.ToString();
        if (lifes == 0)
        {
            gameObject.SetActive(false);

        }
    }

}
