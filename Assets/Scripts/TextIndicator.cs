using System;
using TMPro;
using UnityEngine;

public class TextIndicator : MonoBehaviour
{
    [SerializeField] private Health _health;
    [SerializeField] private TMP_Text _text;

    private void Start()
    {
        UpdateInfo();
    }

    private void OnEnable()
    {
        _health.OnHealthChanged += UpdateInfo;
    }
    
    private void OnDisable()
    {
        _health.OnHealthChanged -= UpdateInfo;
    }

    private void UpdateInfo()
    {
        _text.text = (int)_health.CurrentHealth + "/" + (int)_health.MaxHealth;
    }
}