using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class BallController : MonoBehaviour
{
    public Rigidbody rb;
    private int countRed, countBlue, countYellow, countPurple;
    public GameObject ball, cubeRed, cubeBlue, cubeYellow, cubePurple;
    public GameObject barrierRed, barrierBlue, barrieYellow, barrierPurple;
    public Text textRed;
    public Text textBlue;
    public Text textYellow;
    public Text textPurple;
    public Text winnerRed;
    public Text winnerBlue;
    public Text winnerPurple;
    public Text winnerYellow;


    void Start()
    {

        countRed = 15;
        countBlue = 15;
        countYellow = 15;
        countPurple = 15;
        textRed.text = "Lifes: " + countRed;
        textBlue.text = "Lifes: " + countBlue;
        textYellow.text = "Lifes: " + countYellow;
        textPurple.text = "Lifes: " + countPurple;

        rb.GetComponent<Rigidbody>();

    }

    void Update()
    {

    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Barrier")
        {
            print("Entra por el eje z negativo");
            foreach (ContactPoint contact in collision.contacts)
            {

                rb.AddForce(Vector3.back * 500f);

            }


        }
        else if (collision.gameObject.tag == "BarrierFront")
        {
            print("Entra por el eje z positivo");
            foreach (ContactPoint contact in collision.contacts)
            {
                rb.AddForce(Vector3.forward * 500f);
            }
        }
        else if (collision.gameObject.tag == "BarrierRed")
        {

            countRed = countRed - 1;
            textRed.text = "Lifes: " + countRed;
            if (countRed == 0)
            {
                cubeRed.SetActive(false);

            }
            if (countBlue == 0 && countPurple == 0 && countYellow == 0)
            {
                winnerRed.text = "Winner";

            }
        }

        else if (collision.gameObject.tag == "BarrierBlue")
        {
            countBlue = countBlue - 1;

            textRed.text = "Lifes: " + countBlue;

            if (countBlue == 0)
            {
                cubeBlue.SetActive(false);

            }
            if (countRed == 0 && countPurple == 0 && countYellow == 0)
            {
                winnerBlue.text = "Winner";

            }
        }
        else if (collision.gameObject.tag == "BarrierYellow")
        {
            countYellow = countYellow - 1;

            textRed.text = "Lifes: " + countYellow;

            if (countYellow == 0)
            {
                cubeYellow.SetActive(false);

            }
            if (countRed == 0 && countPurple == 0 && countBlue == 0)
            {
                winnerYellow.text = "Winner";

            }
        }
        else if (collision.gameObject.tag == "BarrierPurple")
        {
            countPurple = countPurple - 1;
            textRed.text = "Lifes: " + countPurple;

            if (countPurple == 0)
            {
                cubePurple.SetActive(false);

            }
            if (countRed == 0 && countBlue == 0 && countYellow == 0)
            {

                winnerPurple.text = "Winner";
            }
        }

    }


}
