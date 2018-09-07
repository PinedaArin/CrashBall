using UnityEngine;

public class BallSpawmerManager : MonoBehaviour
{
    public Rigidbody ball;
    [Header("Spawn Points")]
    public Transform[] spawmPoints;

    public void CreateNewBall()
    {
        Transform currentSpawmPoint = transform;

        if (spawmPoints.Length > 0)
        {
            currentSpawmPoint = spawmPoints[Random.Range(0, spawmPoints.Length - 1)];
        }

        Rigidbody newBall = Instantiate(ball, currentSpawmPoint.position, Quaternion.identity) as Rigidbody;

        Vector3 direction = transform.position - currentSpawmPoint.position;

        newBall.AddForce(direction * 300f);
    }
}