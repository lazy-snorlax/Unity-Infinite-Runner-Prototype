using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    private PlatformManager _platformManager;

    private void OnEnable()
    {
        _platformManager = GameObject.FindObjectOfType<PlatformManager>();
        if (_platformManager == null)
        {
            Debug.LogError("Cannot find Platform Manager: 0100");
        }
        else
        {
            Debug.Log("Platform Manager is Active: 0101");
        }
    }

    private IEnumerator OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            yield return new WaitForSeconds(0.01f);
            _platformManager.RecyclePlatform(this.transform.parent.gameObject);
        }
    }
}
