using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Finish : MonoBehaviour
{
    private AudioSource finish;

    private bool levelCompelted = false;
    private void Start()
    {
        finish = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player" && !levelCompelted)
        {
            finish.Play();
            levelCompelted = true;
            Invoke("Complete", 1f);
            
        }
    }

    private void Complete()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
