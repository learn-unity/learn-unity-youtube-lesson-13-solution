using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishArea : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collider)
    {
        collider.gameObject.transform.position = new Vector3(0, -4f);
    }
}
