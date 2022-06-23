using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private GameObject egg;

    [SerializeField]
    private Basket basket;
    [SerializeField]
    private Ground ground;

    [SerializeField]
    private Text score;
    [SerializeField]
    private Text life;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnEgg", 2, 2);
    }

    // Update is called once per frame
    void Update()
    {
        score.text = basket.score.ToString();
        life.text = ground.life.ToString();
    }

    void SpawnEgg()
    {
        float posX = Random.Range(-2.4f, 2.4f);
        Instantiate(egg, new Vector3(posX, 5.6f, 0), Quaternion.identity);
    }

    public void StopSpawn()
    {
        CancelInvoke();
    }
}
