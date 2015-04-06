﻿using UnityEngine;
using System.Collections;

public class BusterBhv : MonoBehaviour {
	public float m_speed;
	public float m_power;
	public float m_lift;
	public float m_lifeSpan;

	void Die()
	{
		Destroy(gameObject);
	}

	void OnTriggerEnter(Collider a_other)
	{
		a_other.gameObject.SendMessageUpwards("onBusterHit", this, SendMessageOptions.DontRequireReceiver);
	}

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		m_lifeSpan -= Time.deltaTime;
		if (m_lifeSpan <= 0)
			Die ();
		transform.position += transform.forward * Time.deltaTime * m_speed;
	}
}