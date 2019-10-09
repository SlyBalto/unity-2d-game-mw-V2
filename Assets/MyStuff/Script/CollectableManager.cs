using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CollectableManager : MonoBehaviour
{
    public static CollectableManager Instance;

    private int _totalPizzas;
    private int _collectedPizzas;

    public TextMeshProUGUI pizzaCount;

    private void Awake()
    {
        Instance = this;
    }
    void DisplayPizzaCount()
    {
        pizzaCount.SetText(_collectedPizzas + " / " + _totalPizzas);
    }

    private void Start()
    {
        _totalPizzas = FindObjectsOfType<Collectable>().Length;
        DisplayPizzaCount();
    }
    public void HandlePizzaCollected()
    {
        _collectedPizzas++;
        DisplayPizzaCount();
        if(_collectedPizzas == _totalPizzas)
        {
            YouWinMenu.Instance.Show();
        }

        SoundManager.Instance.PlayCoinCollectSound();
    }
}
