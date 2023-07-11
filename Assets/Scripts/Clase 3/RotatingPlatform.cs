using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatingPlatform : MonoBehaviour
{
    public float rotationDuration = 1f;
    public float waitDuration = 2f;

    private void Start()
    {
        StartCoroutine(Rotate());
    }

    private IEnumerator Rotate() 
    {
        while (true) 
        {
            yield return new WaitForSeconds(waitDuration);
            float targetRotation = transform.rotation.eulerAngles.z;
            float startTime = Time.time;
            while (Time.time - startTime < rotationDuration) 
            {
                float angle = Mathf.Lerp(transform.rotation.eulerAngles.z, 180, 
                    (Time.time - startTime) / rotationDuration);
                transform.rotation = Quaternion.Euler(0, 0, angle);
                yield return null;
            }

            transform.rotation = Quaternion.Euler(0, 0, targetRotation);
        }
    }
}
