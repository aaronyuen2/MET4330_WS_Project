using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public PlayerController playerController;
    public float waitToRespawn;

    public GameObject deathExplosion;

    [SerializeField] private int coinCount;

    void Start()
    {
        playerController = FindObjectOfType<PlayerController>();
    }

    public void AddCoin(int coinToAdd)
    {
        coinCount += coinToAdd;
    }

    public void RespawnPlayer()
    {
        StartCoroutine("RespawnPlayerCo");
    }

    public IEnumerator RespawnPlayerCo()
    {
        playerController.gameObject.SetActive(false);
        Instantiate(deathExplosion, playerController.transform.position, playerController.transform.rotation);
        yield return new WaitForSeconds(waitToRespawn);
        playerController.transform.position = playerController.respawnPosition;
        playerController.gameObject.SetActive(true);
    }
}


