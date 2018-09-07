using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuScreen : MonoBehaviour {

    public GameObject gamePlayHUD;

    public BallSpawmerManager ballSpawmer;

    private void Start()
    {
        GameObject spawmer = GameObject.Find("BallSpawmer");

        if(spawmer != null)
        {
            ballSpawmer = spawmer.GetComponent<BallSpawmerManager>();
        }else
        {
            Debug.LogError("No hay un Spawmer de bolas en la escena, perrote :v");
        }

    }


    public void StartGame ()
    {
        //1 debo encender el hud de game play
        gamePlayHUD.SetActive(true);
        // debo instanciar la bola
        ballSpawmer.CreateNewBall();
        // 2 debo apagar el hud del main Menu
        gameObject.SetActive(false);
    }


}
