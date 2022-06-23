using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ground : MonoBehaviour
{
    public int life = 3;
    public GameManager GM;
    public GameObject gameOver;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Egg"))
        {
            life--;
            Destroy(collision.gameObject);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (life == 0)
        {
            GM.StopSpawn();
            gameOver.SetActive(true);
        }
    }
}
