using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class Player : MonoBehaviour
    
{
    public int heatlh = 10;
    public int damage = 2;
    public int coins;
    public GameObject fireballPrefab;
    public Transform attackPoint;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
            Instantiate(fireballPrefab, attackPoint.position, attackPoint.rotation);
    }

    public void TakeDamage(int damage)
    {
        heatlh -= damage;
        print("Heatlh:" + heatlh);
    }

    public void CollectCoins()
    {
        coins += 1;
        print("Coins" + coins);
    }
}
