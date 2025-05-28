using System;
using UnityEngine;

// Token: 0x02000004 RID: 4
public class camara_al1 : MonoBehaviour
{
	public manager_al1 manager;
	public float distancia;
	public RaycastHit hitcam;
	public GameObject boxcam1;
	public GameObject boxcam2;
	private Vector3 poscam;
	public jugador_al1  jugador;
	public float maxdis = 16;
	public Vector2 newPlaneSize;
	public Camera camara;
	// Token: 0x06000009 RID: 9 RVA: 0x0000227D File Offset: 0x0000047D
	private void Start()
	{
		
		manager = (manager_al1)FindFirstObjectByType(typeof(manager_al1));
		jugador = (jugador_al1)FindFirstObjectByType(typeof(jugador_al1));
		boxcam1 = jugador.camara;
		boxcam2 = jugador.boxcam2;
		camara = GetComponent<Camera>();
		CalculatePlaneSize();

	}

	// Token: 0x0600000A RID: 10 RVA: 0x00002280 File Offset: 0x00000480
	private void Update()
	{
		

			
			


	}
	private void LateUpdate()
	{

		distancia = maxdis;
		Vector3 direction = -boxcam2.transform.forward;
		Vector3[] points = Getcamcolpo(direction);
		foreach(Vector3 point in points)
		{
			if(Physics.Raycast(point,direction,out hitcam,maxdis))
			{
				Debug.DrawRay(point,direction,Color.red, maxdis );
				distancia = Mathf.Min(distancia,(hitcam.point - boxcam2.transform.position).magnitude);
			}
			else
			{
				Debug.DrawRay(point,direction,Color.green, maxdis );
				distancia = maxdis;
			}
		}
		transform.position = boxcam2.transform.position + direction * distancia;
		transform.rotation = Quaternion.LookRotation(boxcam2.transform.position - transform.position);
		
			
	}
	private void CalculatePlaneSize()
	{
		float height = (Mathf.Tan(camara.fieldOfView * Mathf.Deg2Rad / 2) * camara.nearClipPlane);
		float width = (height * camara.aspect);

		newPlaneSize = new Vector2(width,height);
	}
	private Vector3[] Getcamcolpo(Vector3 direction)
	{
		Vector3 position = boxcam2.transform.position;
		Vector3 center = position + direction * (camara.nearClipPlane + 0.1f);

		Vector3 right = transform.right * newPlaneSize.x;
		Vector3 up = transform.up  * newPlaneSize.y;
		return new Vector3[]
		{
			center -right + up,
			center +right + up,
			center -right - up,
			center +right - up
		};
	}

}
