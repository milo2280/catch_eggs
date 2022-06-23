using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(restartGame());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator restartGame()
    {
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene("Gameplay");
    }
}
