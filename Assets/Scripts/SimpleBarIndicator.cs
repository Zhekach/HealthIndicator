using UnityEngine;
using UnityEngine.UI;

public class SimpleBarIndicator : HealthIndicator
{
    [SerializeField] private Slider _slider;

    private void Start()
    {
        base.Start();
        _slider.maxValue = Health.MaxHealth;
    }
    
    protected override void UpdateInfo()
    {
        _slider.value = Health.CurrentHealth;

        if (Health.CurrentHealth == 0)
            _slider.fillRect.gameObject.SetActive(false);
        else
            _slider.fillRect.gameObject.SetActive(true);
    }
}