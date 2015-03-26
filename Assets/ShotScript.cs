﻿using UnityEngine;

/// <summary>
/// Поведение снаряда
/// </summary>
public class ShotScript : MonoBehaviour
{
	// 1 – Переменная дизайнера
	
	/// <summary>
	/// Причиненный вред
	/// </summary>
	public int damage = 1;
	
	/// <summary>
	/// Снаряд наносит повреждения игроку или врагам?
	/// </summary>
	public bool isEnemyShot = false;
	
	void Start()
	{
		Destroy(gameObject, 20); // 20 секунд
    }
}