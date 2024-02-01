using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;

    public float cooldown = 1f; 
    private float cooldownTimer = 1f; 

    // Update is called once per frame
    void Update()
    {
        cooldownTimer -= Time.deltaTime;

        if (Input.GetKeyDown(KeyCode.Space) && cooldownTimer < 0f)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            cooldownTimer = cooldown;
        }
    }
}
