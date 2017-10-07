using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Gunscript : MonoBehaviour {

	public Animator animator;
	private bool Isaiming = false;
	public Image crosshair;

	public float range = 100f;
	public float damage = 10f;
	public Camera fpscam;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		//running
		if (Input.GetKeyDown (KeyCode.LeftShift)) {
			animator.SetBool("IsRunning", true);
		}
		if (Input.GetKeyUp (KeyCode.LeftShift)) {
			animator.SetBool ("IsRunning", false);
		}
		//aiming
		if (Input.GetButtonDown("Fire2"))
			{
			Isaiming = !Isaiming;
			animator.SetBool ("IsAiming", Isaiming);
			crosshair.enabled = !Isaiming;



			}
		//Shooting
		if (Input.GetButtonDown ("Fire1")) {
			Shoot ();
		}

	}
	void Shoot ()
	{
		RaycastHit hit;
		if (Physics.Raycast (fpscam.transform.position, fpscam.transform.forward, out hit, range)) {
			Debug.Log(hit.transform.name + "Has been hit!");
		}
	}
}
