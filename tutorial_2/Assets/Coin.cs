using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Coin : MonoBehaviour
{
    // Start is called before the first frame update
    public int coins;
    void Start()
    {
        
    }
    public void OnTriggerEnter(Collider Col)
    {
        if(Col.gameObject.tag == "Coin")
        {
            Debug.Log("YES");
            coins++;
            Score.scoreValue = coins;
            Col.gameObject.SetActive(false);
            if (coins == 7)
            {
                Cursor.lockState = CursorLockMode.None;
                SceneManager.LoadScene("EndScene");
            }
        }
    }
    // Update is called once per frame
    void Update()
    {
 
    }
}
