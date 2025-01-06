using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundVisibility : MonoBehaviour
{
    private void OnEnable()
    {
        gameObject.SetActive(true);
        GetComponent<Renderer>().enabled = true;
    }
}
