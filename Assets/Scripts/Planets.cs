using System.Collections;
using System.Collections.Generic;
using planets;
using UnityEngine;

public abstract class Planets : MonoBehaviour, IPlanet
{

	[SerializeField] private float _distance;
	[SerializeField] private float _speed;
	
	public void Evolute()
	{
		throw new System.NotImplementedException();
	}
}
