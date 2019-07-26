using System.Collections;
using System.Collections.Generic;
using DefaultNamespace;
using UnityEngine;

public class SizeModifier : MonoBehaviour
{
    [SerializeField] private BlobSizeSwitcher _switcher;
    [SerializeField] private int _modifier;
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.enabled == false)
        {
            return;
        }

        if (other.gameObject.CompareTag("Blob"))
        {
            other.gameObject.GetComponent<Collider2D>().enabled = false;
            _switcher.ChangeBlob(_modifier, GetInstanceID());
            gameObject.SetActive(false);
        }
    }
}
