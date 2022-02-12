using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TriggerCollider : MonoBehaviour
{

    //Creating the necessary variables
    private double _count;
    public Text countText;
    public Text winnerText;
    public GameObject diamond;
    public GameObject gold;
    public GameObject silverCylinder;

    //Occurs once the game has begun
    //Instantiates the count variable and spawns in objects
    void Start()
    {
        _count = 0;
        countText.text = "Count: " + _count.ToString();
        for (int j = 0; j < 2; j++)
        {
            Instantiate(diamond, new Vector3((-4f + 2 * j), -0.8f, -5.011f), Quaternion.identity);

        }
        for (int j = 0; j < 3; j++)
        {
            Instantiate(gold, new Vector3((-4.2f + 1.2f * j), -0.8f, -6.022f), Quaternion.identity);

        }
        for (int j = 0; j < 5; j++)
        {
            Instantiate(silverCylinder, new Vector3((-4.6f + 0.8f * j), -0.8f, -4), Quaternion.identity);
        }
    }

    //Applied to user-ball, to pick up the game objects and tracks the points
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pick Up"))
        {
            other.gameObject.SetActive(false);
            _count = _count + 1;
            countText.text = "Count: " + _count.ToString();
        }
        if (other.gameObject.CompareTag("Pick Up2"))
        {
            other.gameObject.SetActive(false);
            _count = _count + 2;
            countText.text = "Count: " + _count.ToString();
        }
        if (other.gameObject.CompareTag("Pick Up3"))
        {
            other.gameObject.SetActive(false);
            _count = _count + 3;
            countText.text = "Count: " + _count.ToString();
        }
        if (other.gameObject.CompareTag("Obstacle"))
        {
            Invoke("ResetScene", 0.1f);
        }
    }

    //Happens every single update, and checks to see whether the player has collected all 17 possible points
    void Update()
    { 
        if (_count == 17)
        {
            Invoke("ResetScene",2.0f);
            winnerText.text = "Congratulations!";
        }
    }

    //Method which is invoked to reset the scene
    public void ResetScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}