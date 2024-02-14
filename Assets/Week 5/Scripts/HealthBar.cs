using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public Slider slider;
    public void TakeDamage(int damage)
    {
        slider.value -= damage;
    }

    public void SetInitialHealth(int HP)
    {
        slider.value = HP;
    }
}
