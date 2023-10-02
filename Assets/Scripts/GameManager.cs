using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    protected bool gameHasEnd = false;
    public Rotator rotator;
    public Spawner spawner;
    protected Animator ani;

    private void Start()
    {
        ani = GetComponent<Animator>();
    }
    public void EndGame()
    {
        if (gameHasEnd) return;
        gameHasEnd = true;
        rotator.enabled= false;
        spawner.enabled= false;
        ani.SetTrigger("EndGame");
        Debug.Log("End");
        
    }

    public void ResetLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
