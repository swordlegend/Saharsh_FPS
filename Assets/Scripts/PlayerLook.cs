using UnityEngine;

public class PlayerLook : MonoBehaviour
{
	[SerializeField] private float sensX = 100f;
	[SerializeField] private float sensY = 100f;

	[SerializeField] private Transform cam;
	[SerializeField] Transform orientation;
	
	[SerializeField] private WallRun wallRun;	

	private float mouseX;
	private float mouseY;

	private float multiplier = 0.01f;

	private float xRotation;
	private float yRotation;

	private void Start()
	{
		Cursor.lockState = CursorLockMode.Locked;
		Cursor.visible = false;
	}

	private void LateUpdate()
	{
		mouseX = Input.GetAxisRaw("Mouse X");
		mouseY = Input.GetAxisRaw("Mouse Y");
		 
		yRotation += mouseX * sensX * multiplier;
		xRotation -= mouseY * sensY * multiplier;

		xRotation = Mathf.Clamp(xRotation, -90f, 90f);

		cam.transform.rotation = Quaternion.Euler(xRotation, yRotation, wallRun.tilt);
		orientation.transform.rotation = Quaternion.Euler(0f, yRotation, 0f);
	}
}