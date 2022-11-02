using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ManaBar : MonoBehaviour
{
	// Start is called before the first frame update
	public Slider mana;

    public float timeSkill = 0;
    public void SetMaxMana(float Mana)
	{
		mana.maxValue = Mana;
		mana.value = Mana;
	}
    public void setMana(float Mana)
	{
		mana.value = Mana;
	}
}
