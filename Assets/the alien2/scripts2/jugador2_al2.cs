using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Rewired;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class jugador2_al2 : MonoBehaviour
{
    public bool saltop = true;
    [SerializeField]private int playerID = 0;
	[SerializeField]private Player player;

	public AudioSource audio1;
    public AudioSource audio2;
    public int vida = 2;
    public bool muerte;
    public Text vidas;
    public int vidaaux;
    public bool dimensiion;
    public float rotspeed = 180;
	public GameObject camara;
	private float cameraverticalangle;
	public Vector3 rotationinput;
    public float tiempogiro2;
    public float girovalor;
	private bool girotd_der = false;
	private bool girotd_izq = false;
    public int objeto;
    public float tempdano;
    public bool salto2;
    public AudioSource saltodo;
    public int blanco;
    public float tiempodisp;
    public GameObject balaprefab;
    public float tempboton;
	public float balavel = 20;
    public Animator anim;
    public GameObject mod;

	public AudioSource disp;

    public int velocidad = 4;

	// Token: 0x0400000F RID: 15
	private Rigidbody _rb;

	public float jumpforce = 300f;
    public Text objetotext;


	public float tiemposalto;
	public float tiempovel;

	public int velocidadmaxima = 9;

	public int velocidadaux;

    public int dir = 1;
	public float lhorizontalc;
	public float lverticalc;
	public float rhorizontalc;
	public float rverticalc;
	public float jumpc;
	public float mc;
	public float nc;
    public float rbc;
    public float lbc;
    public Joystick joyl;
	public Joystick joyr;
    public GameObject tactil;
    // Start is called before the first frame update
    void Start()
    {
        player = ReInput.players.GetPlayer(playerID);
        manager_al2 manager = UnityEngine.Object.FindObjectOfType<manager_al2>();
        if(manager.datosconfig.plat == 1)
        {
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;
            tactil.SetActive(false);

        }
        if(manager.datosconfig.plat == 2)
        {
            tactil.SetActive(true);

        }
        this._rb = base.GetComponent<Rigidbody>();
        vidaaux = vida;
    }
    public void cA()
	{
		jumpc = 1;
	}
	public void cB()
	{
		mc = 1;
	}
	public void cX()
	{
		nc = 1;
	}
    public void crb()
	{
		lbc = 1;
	}
    public void clb()
	{
		rbc = 1;
	}
    public void detA()
	{
		jumpc = 0;
	}
    // Update is called once per frame
    void Update()
    {
        
        manager_al2 manager = UnityEngine.Object.FindObjectOfType<manager_al2>();
        if(manager.datosconfig.plat == 1)
        {
        if(player.GetAxis("lhorizontal") > 0)
        {lhorizontalc = 1;}
        else if(player.GetAxis("lhorizontal") < 0)
        {lhorizontalc = -1;}
        else{lhorizontalc = 0;}

        if(player.GetAxis("lvertical") > 0)
        {lverticalc = 1;}
        else if(player.GetAxis("lvertical") < 0)
        {lverticalc = -1;}
        else{lverticalc = 0;}
        rhorizontalc = player.GetAxis("rhorizontal");
        rverticalc = player.GetAxis("rvertical");
        jumpc = player.GetAxis("a");
        mc = player.GetAxis("b");
        nc = player.GetAxis("x");
        rbc = player.GetAxis("rb");
        lbc = player.GetAxis("lb");
        }
        if(manager.datosconfig.plat == 2)
        {
        lhorizontalc = joyl.Horizontal;
        lverticalc =  joyl.Vertical;
        rhorizontalc =  joyr.Horizontal;
        rverticalc =  joyr.Vertical;
        }
        if(manager.datosserial.personaje == 2)
        {
        if (jumpc > 0f && saltop == true && tiemposalto > 1.4f)
        {
                this._rb.AddForce(this.jumpforce * Vector3.up);
                saltop = false;
                tiemposalto = 0;
                anim.SetBool("salto",true);

        }
        else{anim.SetBool("salto",false);}
        if(blanco == 0)
        {
            if(manager.datosconfig.idioma == "es")
            {
            objetotext.text = "DISPAROS";
            }
            if(manager.datosconfig.idioma == "en")
            {
            objetotext.text = "weapon";
            }
            if(manager.datosconfig.idioma == "cat")
            {
            objetotext.text = "balas";
            }
            if (nc > 0f &&  tiempodisp > 1 )
            {
                    if(manager.juego == 1)
                    {
                        GameObject BalaTemporal = Instantiate(balaprefab, transform.position,transform.rotation) as GameObject;

                        Rigidbody rb = BalaTemporal.GetComponent<Rigidbody>();

                        rb.AddForce(transform.forward * 110 * balavel);

                        Destroy(BalaTemporal, 1.0f);

                        disp.Play();

                        tiempodisp = 0;
                    }
                    if(manager.juego == 2)
                    {
                        GameObject BalaTemporal = Instantiate(balaprefab, transform.position,transform.rotation) as GameObject;

                        Rigidbody rb = BalaTemporal.GetComponent<Rigidbody>();
                        
                        if (dir == 1)
                        {rb.AddForce(transform.forward * 110 * balavel);}
                        if (dir == 2)
                        {rb.AddForce(transform.forward * -110 * balavel);}
                        if (dir == 3)
                        {rb.AddForce(transform.right * 110 * balavel);}
                        if (dir == 4)
                        {rb.AddForce(transform.right * -110 * balavel);}

                        Destroy(BalaTemporal, 1.0f);

                        disp.Play();

                        tiempodisp = 0;
                    }
                    if(manager.juego == 3)
                    {
                        GameObject BalaTemporal = Instantiate(balaprefab, transform.position,transform.rotation) as GameObject;

                        Rigidbody rb = BalaTemporal.GetComponent<Rigidbody>();
                        
                        if (dir == 1)
                        {rb.AddForce(transform.right * -110 * balavel);}
                        if (dir == 2)
                        {rb.AddForce(transform.right * 110 * balavel);}

                        Destroy(BalaTemporal, 1.0f);

                        disp.Play();

                        tiempodisp = 0;
                    }
            }
            if(objeto == 1)
            {
                if(manager.datosconfig.idioma == "es")
                {
                objetotext.text = "VOLVER";
                }
                if(manager.datosconfig.idioma == "en")
                {
                objetotext.text = "RETURN";
                }
                if(manager.datosconfig.idioma == "cat")
                {
                objetotext.text = "TORNAR";
                }
                if(nc > 0f && tempboton > 0.5f)
                {
                    jugador1_al2 jugador1 = UnityEngine.Object.FindObjectOfType<jugador1_al2>();
                    jugador1.tempboton = 0;
                    tempboton = 0;
                    manager.datosserial.personaje = 1;
                }
            }
            if(objeto == 1 && lbc > 0f && tempboton > 0.5f)
            {
                objeto--;
                tempboton = 0;
            }
            if(objeto == 0 && rbc > 0f && tempboton > 0.5f) 
            {
                objeto++;
                tempboton = 0;
            }

        }
        if(manager.juego == 1)
        {
            anim.SetFloat("velx",lhorizontalc);
            anim.SetFloat("vely",lverticalc);
            if (lhorizontalc > 0f )
			{
                dir = 3;
				base.transform.Translate (-1 * Time.deltaTime * Vector3.left* velocidad);
                mod.transform.localRotation = Quaternion.Lerp(mod.transform.localRotation,Quaternion.Euler(0,90,0),5* Time.deltaTime);
			}
			if (lhorizontalc < 0f)
			{
                dir = 4;
				base.transform.Translate (1 * Time.deltaTime * Vector3.left* velocidad);
                mod.transform.localRotation = Quaternion.Lerp(mod.transform.localRotation,Quaternion.Euler(0,-90,0),5* Time.deltaTime);
			}
			if (lverticalc > 0f)
			{
                dir = 1;
				base.transform.Translate  (-1 * Time.deltaTime * Vector3.back * velocidad);
                mod.transform.localRotation = Quaternion.Lerp(mod.transform.localRotation,Quaternion.Euler(0,0,0),5* Time.deltaTime);
			}
			if (lverticalc < 0f )
			{
                dir = 2;
				base.transform.Translate (1  * Time.deltaTime * Vector3.back* velocidad);
                mod.transform.localRotation = Quaternion.Lerp(mod.transform.localRotation,Quaternion.Euler(0,180,0),5* Time.deltaTime);
			}

            rotationinput.x = rhorizontalc * rotspeed * Time.deltaTime;
            rotationinput.y = rverticalc * rotspeed * Time.deltaTime;

            cameraverticalangle +=  rotationinput.y;
            cameraverticalangle = Mathf.Clamp(cameraverticalangle, -50 , 20);
            
            transform.Rotate(Vector3.up * rotationinput.x);
            camara.transform.localRotation = Quaternion.Euler(-cameraverticalangle,transform.eulerAngles.y,0);

            camara.transform.position = Vector3.MoveTowards(camara.transform.position,transform.position,10 * Time.deltaTime);
        }
        if(manager.juego == 2)
        {
           anim.SetFloat("velx",lhorizontalc);
            anim.SetFloat("vely",lverticalc);
           if (lhorizontalc > 0f )
			{
                dir = 3;
				base.transform.Translate (-1 * Time.deltaTime * Vector3.left* velocidad);
                mod.transform.localRotation = Quaternion.Lerp(mod.transform.localRotation,Quaternion.Euler(0,90,0),5* Time.deltaTime);
			}
			if (lhorizontalc < 0f)
			{
                dir = 4;
				base.transform.Translate (1 * Time.deltaTime * Vector3.left* velocidad);
                mod.transform.localRotation = Quaternion.Lerp(mod.transform.localRotation,Quaternion.Euler(0,-90,0),5* Time.deltaTime);
			}
			if (lverticalc > 0f)
			{
                dir = 1;
				base.transform.Translate  (-1 * Time.deltaTime * Vector3.back * velocidad);
                mod.transform.localRotation = Quaternion.Lerp(mod.transform.localRotation,Quaternion.Euler(0,0,0),5* Time.deltaTime);
			}
			if (lverticalc < 0f )
			{
                dir = 2;
				base.transform.Translate (1  * Time.deltaTime * Vector3.back* velocidad);
                mod.transform.localRotation = Quaternion.Lerp(mod.transform.localRotation,Quaternion.Euler(0,180,0),5* Time.deltaTime);
			}
        }
        if (manager.juego == 3 && this.dimensiion)
		{
            anim.SetFloat("velx",lhorizontalc);
            anim.SetFloat("vely",lverticalc);
			
			if (lhorizontalc > 0f)
			{
                dir = 1;
				base.transform.position -= +1 * (float)this.velocidad * Time.deltaTime * Vector3.back;
                mod.transform.localRotation = Quaternion.Lerp(mod.transform.localRotation,Quaternion.Euler(0,-90,0),5* Time.deltaTime);
			}
			if (lhorizontalc < 0f )
			{
                dir = 2;
				base.transform.position -= -1 * (float)this.velocidad * Time.deltaTime * Vector3.back;
                mod.transform.localRotation = Quaternion.Lerp(mod.transform.localRotation,Quaternion.Euler(0,90,0),5* Time.deltaTime);
			}
			this.tiempogiro2 += Time.deltaTime;
		
			
			
			
			
		}
		if (manager.juego == 3 && !this.dimensiion)
		{
            anim.SetFloat("velx",lhorizontalc);
            anim.SetFloat("vely",lverticalc);
			if (lhorizontalc < 0f )
			{
                dir = 2;
				base.transform.position -= -1 * (float)this.velocidad * Time.deltaTime * Vector3.right;
                mod.transform.localRotation = Quaternion.Lerp(mod.transform.localRotation,Quaternion.Euler(0,90,0),5* Time.deltaTime);
			}
			if (lhorizontalc > 0f)
			{
                dir = 1;
				base.transform.position -= +1 * (float)this.velocidad * Time.deltaTime * Vector3.right;
                mod.transform.localRotation = Quaternion.Lerp(mod.transform.localRotation,Quaternion.Euler(0,-90,0),5* Time.deltaTime);
			}
			this.tiempogiro2 += Time.deltaTime;
		}
        if (manager.juego == 3 && mc > 0f)
		{
			if (!this.dimensiion && this.tiempogiro2 > 1.5f)
			{
				this.dimensiion = true;
				this.tiempogiro2 = 0f;
				girovalor = base.transform.eulerAngles.y;
				girotd_der = true;
			}
			else if (this.dimensiion && this.tiempogiro2 > 1.5f)
			{
				this.tiempogiro2 = 0f;
				this.dimensiion = false;
				girovalor = base.transform.eulerAngles.y;
				girotd_izq = true;
			}
						
		}
        if (tiempogiro2 > 1f)
		{
			if (girotd_izq == true)
			{
				transform.rotation = Quaternion.Euler(0,0,0);

				 

			}
			if (girotd_der == true)
			{

				transform.rotation = Quaternion.Euler(0,90,0);
			}
			girotd_der = false;
			girotd_izq = false;
		}
		if (girotd_izq == true)
		{
			if (base.transform.eulerAngles.y >= girovalor - 180f)
			{
				transform.Rotate(Vector3.up,-180f * Time.deltaTime);
			}

		}
		if (girotd_der == true)
		{
			if (base.transform.eulerAngles.y <= girovalor + 180f)
			{
				transform.Rotate(Vector3.up,180f * Time.deltaTime);
			}

		}
			this.tiempogiro2 += Time.deltaTime;
    
        }
        if(vida <= 0)
        {
            muerte = true;
            vida = 0;
        }
        if(tempboton < 15)
        {tempboton += 1 * Time.deltaTime;}
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
            manager.datosserial.alien2muere = 1;
            manager.guardar();
            SceneManager.LoadScene("mundo_abierto_al2");
        }
        mc = 0;
        nc = 0;
        lbc = 0;
        rbc = 0;
        
    }


    private void OnCollisionEnter(Collision col)
	{
        manager_al2 manager = UnityEngine.Object.FindObjectOfType<manager_al2>();
		if (col.gameObject.tag == "suelo")
		{
			saltop = true;

		}
        if (col.gameObject.tag == "lava")
		{
			saltop = true;
            salto2 = false;
		}
        if (col.gameObject.tag == "respawn")
		{
			muerte = true;
		}

	}
    private void OnCollisionStay(Collision col)
	{
	
	}
    private void OnCollisionExit(Collision col)
	{
		manager_al2 manager = UnityEngine.Object.FindObjectOfType<manager_al2>();

		if (col.gameObject.tag == "suelo")
        {

        }
        

	}
    private void OnTriggerStay(Collider col)
	{
    

	}
}
