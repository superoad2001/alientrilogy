using System;
using UnityEngine;

// Token: 0x02000004 RID: 4
public class camara_al3 : MonoBehaviour
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
		if(GetComponent<Camera>() != null)
		{
			camara = GetComponent<Camera>();
		}
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

		if(jugador.modo == "3D"|| jugador.modo == "2D" || jugador.modo == "Lobby" )
		{
			transform.position = Vector3.MoveTowards(transform.position,  boxcam2.transform.position + direction * distancia, Time.deltaTime * 120f);
			transform.rotation = Quaternion.LookRotation(boxcam2.transform.position - transform.position);
		}	
		else if(jugador.modo == "Nave" )
		{
			
			Vector3 var = jugador.transform.position + direction * distancia;
			var = var + transform.TransformDirection(new Vector3(0,5.920013f,0));
			transform.position = Vector3.MoveTowards(transform.position, var, Time.deltaTime * 120f);
		}
		else if(jugador.modo == "Coche")
		{
			transform.position = Vector3.MoveTowards(transform.position,  boxcam2.transform.position + direction * distancia, Time.deltaTime * 120f);

		}

		
		
			
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
		Vector3 center = position + direction * (camara.nearClipPlane - 0.5f);

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
