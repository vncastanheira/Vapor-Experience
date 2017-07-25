using UnityEngine;

public class Rotate : MonoBehaviour
{
				public float Speed;
				
				private void Update()
				{
								transform.Rotate(Vector3.up, Speed * Time.deltaTime);
				}
}
