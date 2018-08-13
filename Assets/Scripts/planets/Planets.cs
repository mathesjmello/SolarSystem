using UnityEngine;

namespace planets
{
	public abstract class Planets : MonoBehaviour, IPlanet, IRotate
	{

        [SerializeField] private float _rotation;
        [SerializeField] private float _distance;
		[SerializeField] private float _speed;


		public void Evolute(float t)
		{
			transform.position= new Vector3(_distance*Mathf.Cos(t),0,_distance*Mathf.Sin(t));
		}
        public void Rotate(float r)
        {
            transform.rotation = new Quaternion (0, _rotation*r, 0,1);
        }

		private void Update()
		{
			Evolute((Time.time*_speed*TimeManeger.instance.MyTimeScale));
            Rotate(Time.time*TimeManeger.instance.MyTimeScale);
		}
	}
}
