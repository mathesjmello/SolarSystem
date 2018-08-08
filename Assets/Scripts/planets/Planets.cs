using UnityEngine;

namespace planets
{
	public abstract class Planets : MonoBehaviour, IPlanet
	{

		[SerializeField] private float _distance;
		[SerializeField] private float _speed;


		public void Evolute(float t)
		{
			transform.position= new Vector3(_distance*Mathf.Cos(t),0,_distance*Mathf.Sin(t));
		}

		private void Update()
		{
			Evolute((Time.time*_speed));
		}
	}
}
