using UnityEngine;

public class DroppedGunData : MonoBehaviour
{
    [Header("Info")]
	public new string name;
	
	[Space]
	
	public float damage;
	public float maxDistance;
	
	[Header("Shooting")]
	public bool autoShoot;
	
	[Header("Recoil")]
	public float recoilX;
	public float recoilY;
	public float recoilZ;
	
	public float snappiness;
	public float returnSpeed;
	
	[Range(0f, 8f)]
	public float shootForce;
	
	[Header("Reloading")]
	public int currentAmmo;
	public int magSize;
	
	public float fireRate;
	public float reloadTime;
	
	[HideInInspector]
	public bool isReloading;
}
