using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class goldCollect : MonoBehaviour
{
    [SerializeField] goldTracker goldTracker;
    [SerializeField] AudioSource dingCollect;

    private void Start()
    {
        XRGrabInteractable grabbable = GetComponent<XRGrabInteractable>();
        grabbable.selectEntered.AddListener(collectGold);
    }

    public void collectGold(SelectEnterEventArgs args)
    {
        StartCoroutine(collectAndDelete());
    }

    private IEnumerator collectAndDelete()
    {
        goldTracker.goldCollected++;
        dingCollect.Play();
        yield return new WaitForSeconds(1.5f);
        Destroy(gameObject);
    }
}
