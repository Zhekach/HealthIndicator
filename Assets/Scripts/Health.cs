using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] private float _maxHealth = 10f;
    [SerializeField] private float _currentHealth;

    public float MaxHealth => _maxHealth;
    public float CurrentHealth => _currentHealth;

    private void Awake()
    {
        _currentHealth = _maxHealth;
    }

    public void GetDamage(float damage)
    {
        _currentHealth = Mathf.Clamp(_currentHealth - damage, 0, _maxHealth);

        if (_currentHealth == 0)
            Destroy(gameObject);
    }
    
    public void Heal(float heal)
    {
        _currentHealth = Mathf.Clamp(_currentHealth + heal, 0, _maxHealth);
    }
}
