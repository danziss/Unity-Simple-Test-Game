using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Life : MonoBehaviour
{

    [SerializeField] int life;

    public void OnCollisionEnter2D (Collision2D other){
        life = life - 1;
        if (life <= 0){
            Scene scene = SceneManager.GetActiveScene();
            SceneManager.LoadScene(scene.name);
        }
    }
}
