using System;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag.Equals("Obstacle"))
        {
            Debug.Log("We hit the obstacle");

            movement.enabled = false;

            FindObjectOfType<GameManager>().EndGame();

            //StartCoroutine(Restart(5));
        }
    }

    //IEnumerator Restart(int waitSeconds)
    //{
    //    while (waitSeconds > 0) {
    //        Debug.LogFormat("Restart in {0}", waitSeconds);

    //        yield return new WaitForSeconds(1);
    //        waitSeconds -= 1;
    //    }

    //    SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    //}
}
