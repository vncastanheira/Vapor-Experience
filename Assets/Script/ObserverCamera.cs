using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Camera))]
public class ObserverCamera : MonoBehaviour
{
				bool isLocked = true;

				void Update()
				{
								SetCursorMode();
								if (isLocked)
								{
												float mouseX = Input.GetAxis("Mouse X");
												float mouseY = Input.GetAxis("Mouse Y");
												transform.parent.rotation *= Quaternion.Euler(0f, mouseX, 0f);
												transform.localRotation *= Quaternion.Euler(-mouseY, 0f, 0f);
												transform.localRotation = ClampRotation(transform.localRotation, -90f, 90f);
								}
				}

				void SetCursorMode()
				{
								if (isLocked)
								{
												Cursor.lockState = CursorLockMode.Locked;
												Cursor.visible = false;
								}
								else
								{
												Cursor.lockState = CursorLockMode.None;
												Cursor.visible = true;
								}
				}

				Quaternion ClampRotation(Quaternion q, float minAngle, float maxAngle)
				{
								q.x /= q.w;
								q.y /= q.w;
								q.z /= q.w;
								q.w = 1.0f;

								float angleX = 2.0f * Mathf.Rad2Deg * Mathf.Atan(q.x);

								angleX = Mathf.Clamp(angleX, minAngle, maxAngle);

								q.x = Mathf.Tan(0.5f * Mathf.Deg2Rad * angleX);

								return q;
				}
}
