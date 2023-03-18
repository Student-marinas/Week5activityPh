using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerhp : MonoBehaviour
{
    public Image healthBar;
    public float scaleFactor;
    public float currentHealth;
    private Color red;

    private void Start()
    {
        healthBar.type = Image.Type.Filled;
        red = new Color(249, 0, 0);
    }

    public void ChangeHealthBar()
    {
        // scaleFactor = hurtEnemy.damageToGive / currentHealth;
        healthBar.fillAmount = scaleFactor;
        healthBar.color = red;
    }
}
