using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class jugador2_al2 : MonoBehaviour
{
    public bool saltop = true;
    public GameObject respawnm;
    public GameObject juego;
    private Controles controles;
	public void Awake()
    {
        controles = new Controles();
    }
    private void OnEnable() 
    {
        controles.Enable();
    }
    private void OnDisable() 
    {
        controles.Disable();
    }

    private float cameraverticalangle2;
    public bool muerte;
    public bool dimensiion;
    public float rotspeed = 180;
	public GameObject camara;
	private float cameraverticalangle;
	public Vector3 rotationinput;
    public float tiempogiro2;
    public float girovalor;
	private bool girotd_der = false;
	private bool girotd_izq = false;
    public float tempdano;
    public float tiempodisp;
    public float tempboton;
    public GameObject mod;

	public AudioSource disp;

    public int velocidad = 4;

	// Token: 0x0400000F RID: 15
	private Rigidbody _rb;

	public float jumpforce = 300f;
    public Text objetotext;
    public GameObject explosion;


	public float tiemposalto;
	public float tiempovel;

	public int velocidadmaxima = 9;

	public int velocidadaux;

    public manager_al2 manager;
    public jugador_al2 jugador;
    private Camera camaracom;
    public camara2_al2 camarascript; 
    public GameObject boxcam2;
    public GameObject giro;
    private float camaux = 0;
    private float camXc;
	private float camYc;
	private float movXc;
	private float movYc;
    private float UIXc;
	private float UIYc;	
	private float saltarc;
	private float dashc;
	private float interactuarc;
	private float dispararc;
	private float ruletac;
	private float ruletapressc;
	private float UIreducidoc;
	private float correrc;
	private float menu1c;
	private float menu2c;
	public float lateralc;
    public bool controlact;
    private float temp10;
    public GameObject pausa1;
    public GameObject select1;
    public GameObject tactil;
    public bool jugadorEntrando;
    public bool movPH;
    public float angulomod;
    private Vector3 movdire;
    private Vector3 posicionbase;
    public bool dest;

    // Start is called before the first frame update
    void Start()
    {
        posicionbase = transform.position;
        if(camara != null)
        {cameraverticalangle2 = camara.transform.eulerAngles.y;}

        manager = (manager_al2)FindFirstObjectByType(typeof(manager_al2));

        jugador = (jugador_al2)FindFirstObjectByType(typeof(jugador_al2));



        camarascript = (camara2_al2)FindFirstObjectByType(typeof(camara2_al2));

		camaracom = camarascript.transform.GetComponent<Camera>();


        velocidad = 6;

        


        if(manager.datosconfig.plat == 1)
        {
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;

        }
        if(manager.datosconfig.plat == 2)
        {

        }
        this._rb = base.GetComponent<Rigidbody>();
    }
    private void FixedUpdate()
	{

		
		if(controlact == true && movPH == true && manager.personaje == 2)
		{
			


			Vector3 movdirnow = (transform.TransformDirection(new Vector3 (movXc,0, movYc).normalized)) * velocidad;

			Vector3 moveDir =  movdirnow;

            // Raycast para detectar colisión en la dirección del movimiento
            if (Physics.Raycast(transform.position + new Vector3(0,1.5f,0),moveDir, out RaycastHit hit,Mathf.Infinity))
            {
				Debug.DrawRay(transform.position + new Vector3(0,1.5f,0),moveDir * 300, Color.yellow);
				if(hit.distance < 2)
                {moveDir = new Vector3(0,0,0);}
               
            }
			else
			{
				Debug.DrawRay(transform.position + new Vector3(0,1.5f,0),moveDir * 300, Color.red);
			}
			if (Physics.Raycast(transform.position + new Vector3(0,-1.5f,0),moveDir, out RaycastHit hit2, Mathf.Infinity))
            {
				Debug.DrawRay(transform.position + new Vector3(0,-1.5f,0),moveDir * 300, Color.yellow);
				if(hit2.distance < 2)
                {moveDir = new Vector3(0,0,0);}
            }
			else
			{
				Debug.DrawRay(transform.position + new Vector3(0,-1.5f,0),moveDir * 300, Color.red);
			}
			if (Physics.Raycast(transform.position,moveDir, out RaycastHit hit3,Mathf.Infinity))
            {
				Debug.DrawRay(transform.position + new Vector3(0,0,0),moveDir * 300, Color.yellow);
				if(hit3.distance < 2)
                {moveDir = new Vector3(0,0,0);}
            }
			else
			{
				Debug.DrawRay(transform.position + new Vector3(0,0,0),moveDir * 300, Color.red);
			}

			
			
			
			


			_rb.linearVelocity = new Vector3(moveDir.x,_rb.linearVelocity.y,moveDir.z);

			

		}
	}
    // Update is called once per frame
    void Update()
    {

    if(manager.personaje == 2)
    {
        
        camaracom.enabled = true;
    }
    else
    {
        camaracom.enabled = false;
    }
        
    if(manager.personaje == 2)
    {
		if(controlact == true)
		{

			


				
				camXc = controles.al2_3d.camX.ReadValue<float>();
				camYc = controles.al2_3d.camY.ReadValue<float>();
				


				



					movXc = controles.al2_3d.mov.ReadValue<Vector2>().x;
					movYc = controles.al2_3d.mov.ReadValue<Vector2>().y;
					saltarc = controles.al2_3d.saltar.ReadValue<float>();


			

			lateralc = controles.al2_3d.lateral.ReadValue<float>();
			UIXc = controles.al2_UI.UIX.ReadValue<float>();
			UIYc = controles.al2_UI.UIY.ReadValue<float>();	
			dispararc = controles.al2_3d.disparar.ReadValue<float>();	
			dashc = controles.al2_3d.dash.ReadValue<float>();
			interactuarc = controles.al2_3d.interactuar.ReadValue<float>();		
			
			
			UIreducidoc = controles.al2_3d.UIreducido.ReadValue<float>();
			menu1c = controles.al2_3d.menu1.ReadValue<float>();
			menu2c = controles.al2_3d.menu2.ReadValue<float>();


			
			

			if (menu1c > 0 && temp10 > 0.7f)
			{
				Time.timeScale = 0;
				manager.pauseact = true;
				pausa1.SetActive(true);
				controlact = false;
				menu1c = 0;
				temp10 = 0;
				if(manager.datosconfig.plat == 2)
				{
					tactil.SetActive(false);
				}
				Cursor.visible = true;
				Cursor.lockState = CursorLockMode.None;
			}

			else if (menu2c > 0 && temp10 > 0.7f)
			{
				Time.timeScale = 0;
				manager.pauseact = true;
				select1.SetActive(true);
				var pausatemp = select1.GetComponent<pausa_al2>();
				pausatemp.mapa_();
				pausatemp.RestoreOriginalControls();
				controlact = false;
				menu2c = 0;
				temp10 = 0;
				if(manager.datosconfig.plat == 2)
				{
					tactil.SetActive(false);
				}
				Cursor.visible = true;
				Cursor.lockState = CursorLockMode.None;
			}
			

			
		}
		else
		{
			
			camXc = controles.al2_3d.camX.ReadValue<float>();
			camYc = controles.al2_3d.camY.ReadValue<float>();
			dispararc = controles.al2_3d.disparar.ReadValue<float>();
			
			movXc = 0;
			movYc = 0;
			
			
		}
	}
        if(manager.personaje == 2)
        {
        if (saltarc > 0f && saltop == true && tiemposalto > 1.4f)
        {
                this._rb.AddForce(800 * Vector3.up);
                saltop = false;
                tiemposalto = 0;

        }



        if(dispararc > 0  && tiempodisp > 0.5f)
        {
            muerte = true;
        }
        if(interactuarc > 0 && tiempodisp > 0.5f)
        {
            _rb.linearVelocity = Vector3.zero;
            tiempodisp = 0;
            jugador.tiempodisp = 0;
            manager.personaje = 1;
		    
        }
        if(controlact == true && jugador.modo == "3D")
        {

					

					Vector3 movdirnow = new Vector3 (movXc,0, movYc).normalized;




						if (jugadorEntrando == true)
						{
								
								boxcam2.transform.localRotation = Quaternion.Euler(0.35f, 0, 0);
								this.jugadorEntrando = false;
						}				
						
						if(movXc != 0 || movYc != 0)
						{

							movPH = true;
							
							// Rotar el modelo en la dirección del movimiento
							angulomod = Mathf.Atan2(movXc, movYc) * Mathf.Rad2Deg;
							mod.transform.localRotation = Quaternion.Lerp(mod.transform.localRotation, 
																		Quaternion.Euler(mod.transform.localEulerAngles.x, angulomod, mod.transform.localEulerAngles.z),
																		10 * Time.deltaTime);
							
							// Rotar el personaje para que mire en la dirección de la cámara
							float camaraYRotation = camara.transform.eulerAngles.y;
							transform.rotation = Quaternion.Slerp(transform.rotation, 
																Quaternion.Euler(0, camaraYRotation, 0),
																1 * Time.deltaTime);
						}
						else
						{
							movPH = false;
						}
						
						// Gradualmente volver a la rotación normal cuando no está en modo planeta
						Quaternion rotacionNormal = Quaternion.Euler(0, transform.eulerAngles.y, 0);
						transform.rotation = Quaternion.Slerp(transform.rotation, rotacionNormal, Time.fixedDeltaTime * 3f);

						
						
						
						
						movdire = transform.TransformDirection(movdirnow * velocidad);
						float distaxe = movdire.magnitude * Time.fixedDeltaTime;
						movdire.Normalize();
						RaycastHit hit;
						Vector3 moveDirection = new Vector3(movXc, 0, movYc).normalized;

						
						
						if(movYc == 0f && movXc == 0f)
						{
							_rb.linearVelocity = new Vector3 (0,_rb.linearVelocity.y,0);
						}
						
						

	

						if(camXc != 0)
						{rotationinput.x = camXc * rotspeed * Time.deltaTime;}
						else{rotationinput.x = 0;}
						

						if(camYc != 0)
						{rotationinput.y = camYc * rotspeed * Time.deltaTime;}
						else{rotationinput.y = 0;}
						Debug.Log("camara");
						

							Vector3 horcam = Vector3.up * rotationinput.x;
							Vector3 vercam = new Vector3(0,0,0);

							
							vercam = Vector3.right * -rotationinput.y;

						
							camara.transform.localEulerAngles += vercam + horcam;

						Quaternion xRotationx = Quaternion.Euler(camara.transform.localEulerAngles.x,0,0);
						float angle_f = Quaternion.Angle(Quaternion.identity, xRotationx);
						float fixedAngle_f = angle_f;
						if (xRotationx.eulerAngles.x>180)
						{
							fixedAngle_f *= -1;
						}
						float clampedX = Mathf.Clamp(fixedAngle_f, -20, 50);
						camara.transform.localRotation = Quaternion.Euler(clampedX, camara.transform.localEulerAngles.y, camara.transform.localEulerAngles.z);
						



						camaux = camara.transform.eulerAngles.y;

							if (movXc != 0f && camXc != 0f|| movYc != 0 && camXc != 0f || movXc != 0f || movYc != 0)
							{
								transform.rotation = Quaternion.Slerp(transform.rotation,Quaternion.Euler(transform.eulerAngles.x,camaux,transform.eulerAngles.z),30f* Time.deltaTime);
								camara.transform.localRotation = Quaternion.Slerp(camara.transform.localRotation,Quaternion.Euler(camara.transform.localEulerAngles.x,giro.transform.localEulerAngles.y,camara.transform.localEulerAngles.z),30f* Time.deltaTime);	
							}
								


						
					

					

						

				
					
				


				

		}
		
        if(controlact == true && jugador.modo == "Cenital")
        {
           
        }

        if (controlact == true && jugador.modo == "2D" && this.dimensiion)
		{
            
		
			
			
			
			
		}
		if (controlact == true && jugador.modo == "2D" && !this.dimensiion)
		{
            
		}
    
        }
        if(temp10 < 15)
        {temp10 += 1 * Time.deltaTime;}
        if(tiemposalto < 15)
        {tiemposalto += 1 * Time.deltaTime;}
        if(tempdano < 15)
        {tempdano += 1 * Time.deltaTime;}
        if(tiempodisp < 15)
        {tiempodisp += 1 * Time.deltaTime;}
        if(tiempovel < 15)
        {tiempovel += 1 * Time.deltaTime;}
        if (muerte == true)
        {

            GameObject explosiont = Instantiate(explosion, transform.position, transform.rotation) as GameObject;
            explosiont.transform.localScale = this.gameObject.transform.localScale;
            Destroy(explosiont, 1f);
            dest = true;
            muerte = false;
            //ahora en on trigger stay si detecan que explosion player 2 tiene dest activo ejecutara el daño o evento


        }
        else if(dest == true)
        {
            transform.position = posicionbase;

            _rb.linearVelocity = Vector3.zero;
            tiempodisp = 0;
            jugador.tiempodisp = 0;
            manager.personaje = 1;
            dest = false;
        }

        camXc = 0;
		camYc = 0;


		saltarc = 0;
		dashc = 0;
		interactuarc = 0;

		
		dispararc = 0;
		lateralc = 0;
		correrc = 0;
		UIreducidoc = 0;
        
    }
    private void OnTriggerEnter(Collider col)
	{

        if (col.gameObject.tag == "enemigo")
		{
            GameObject explosiont = Instantiate(jugador.explosion, col.transform.position,col.transform.rotation) as GameObject;
            Destroy(explosiont, 1f);
            Destroy(col.gameObject);
			muerte = true;
        }
        if (col.gameObject.tag == "dañox2" && tempdano > 3)
		{
            tempdano = 0;
            muerte = true;
        }

	}


    private void OnCollisionEnter(Collision col)
	{
		if (col.gameObject.tag == "suelo")
		{
			saltop = true;

		}
        if (col.gameObject.tag == "lava")
		{
			saltop = true;
		}
        if (col.gameObject.tag == "respawn")
		{
			muerte = true;
		}
        if (col.gameObject.tag == "enemigo")
		{
            GameObject explosiont = Instantiate(jugador.explosion, col.transform.position,col.transform.rotation) as GameObject;
            Destroy(explosiont, 1f);
            Destroy(col.gameObject);
			muerte = true;
        }
        if (col.gameObject.tag == "dañox2")
		{
			muerte = true;
            
        }

	}
    private void OnCollisionStay(Collision col)
	{
        if (col.gameObject.tag == "suelo" || col.gameObject.tag == "lava" || col.gameObject.tag == "control" )
        {
            saltop = true;
		}
	}
    private void OnCollisionExit(Collision col)
	{

		if (col.gameObject.tag == "suelo")
        {

        }
        if (col.gameObject.tag == "suelo" || col.gameObject.tag == "lava" || col.gameObject.tag == "control" )
		{
			saltop = false;
		}
        

	}
    private void OnTriggerStay(Collider col)
	{
    

	}
}
