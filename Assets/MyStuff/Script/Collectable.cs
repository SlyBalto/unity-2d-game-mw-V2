using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets._2D;

public class Collectable : MonoBehaviour
{
    private bool _hasbeencollected = false;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!_hasbeencollected && collision.gameObject.GetComponent<PlatformerCharacter2D>())
        {
            HandleCollected();
        }
    }
    void HandleCollected() {

        _hasbeencollected = true;
        CollectableManager.Instance.HandlePizzaCollected();
        Destroy(gameObject);
    }
}
