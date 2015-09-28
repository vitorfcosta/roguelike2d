using UnityEngine;
using System.Collections;

public class Wall : MonoBehaviour
{
	public Sprite dmgSprite;
	public int hp = 4;
	public AudioClip chopSound1;
	public AudioClip chopSound2;

	private SpriteRenderer spriteRenderer;


	
	void Awake ()
	{
		spriteRenderer = GetComponent <SpriteRenderer> ();
	
	}
	
	public void DamageWall (int Loss)
	{
		spriteRenderer.sprite = dmgSprite;
		hp -= Loss;
		if (hp <= 0)
			gameObject.SetActive(false);
		SoundManager.instance.RandomizeSfx (chopSound1, chopSound2);
	}

}
