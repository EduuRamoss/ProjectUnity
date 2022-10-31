using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerCollision : MonoBehaviour
{
    [SerializeField] GameManager _gameManager;
    [SerializeField] Transform iniPos;

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Danger"))
        {
            _gameManager.currentLifes -= 1;
            SceneManager.LoadScene(1);
        }
    }
}
