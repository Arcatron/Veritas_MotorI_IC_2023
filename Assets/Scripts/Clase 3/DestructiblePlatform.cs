using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestructiblePlatform : MonoBehaviour
{
    public float duration;
    public GameObject platform;

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            StartCoroutine(Reactivate());
            platform.gameObject.SetActive(false);
        }
    }

    private IEnumerator Reactivate() 
    {
        yield return new WaitForSeconds(duration);
        platform.gameObject.SetActive(true);
    }
}
