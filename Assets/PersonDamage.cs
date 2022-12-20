using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PersonDamage : MonoBehaviour
{
    public int maxHealth=2;
    public int currentHealth;

    public HealthBar healthBar;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }

    // Update is called once per frame
    void Update()
    {
        if(currentHealth == 0)
        {
            Cursor.lockState = CursorLockMode.None;
            SceneManager.LoadScene("EndScene");
        }

    }

    void TakeDamage(int damage)
    {
        currentHealth = currentHealth - damage;
        healthBar.SetHealth(currentHealth);
    }

    /*void AreaDamage(Vector3 center, float radius)
    {
        Collider[] hitColliders = Physics.OverlapSphere(center, radius);
        foreach (var hitCollider in hitColliders)
        {
            TakeDamage(1);
        }
    }*/
    public void OnTriggerEnter(Collider Col)
    {
        if (Col.gameObject.tag == "Enemy")
        {
            TakeDamage(1);
        }
    }
}   