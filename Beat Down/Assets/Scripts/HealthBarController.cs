using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBarController : MonoBehaviour
{
    // Start is called before the first frame update

    Slider healthBar;
    GameObject player;
    PlayerHealth playerHealth;

    void Start()
    {
        healthBar = GetComponent<Slider>();
        player = GameObject.FindWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        playerHealth = player.GetComponent<PlayerHealth>();
        healthBar.value = playerHealth.health;
    }
}
