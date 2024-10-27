using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;


public class pausa_al3: MonoBehaviour
{
    public manager_al3 manager;
    public GameObject opciones1;
    public AudioMixer audiomixer;
    public Text ttcont;
    public Text ttarmas;
    public Text ttarmaduras;
    public Text ttselecion;
    public Text ttdiarios;
    public Text ttinventario;
    public Text ttextras;
    public Text ttguia;
    public Text ttopciones;
    public Text ttsalir;


    public Text ttdiario1;
    public Text ttdiario2;
    public Text ttdiario3;
    public Text ttdiario4;
    public Text ttdiario5;
    public Text ttdiario6;
    public Text ttdiario7;
    public Text ttdiario8;
    public Text ttdiario9;
    public Text ttdiario10;
    public Text ttdiario11;
    public Text ttdiario12;
    public Text ttdiario13;
    public Text ttdiario14;
    public Text ttdiario15;


    public Text ttatras1;
    public Text ttatras2;
    public Text ttatras3;
    public Text ttatras4;
    public Text ttatras5;
    public Text ttatras6;
    public Text ttatras7;
    public Text ttatras8;

    public Text ttpausa1;
    public Text ttpausa2;
    public Text ttpausa3;
    public Text ttpausa4;
    public Text ttpausa5;
    public Text ttpausa6;
    public Text ttpausa7;
    public Text ttpausa8;

    public Text tttarmas;
    public Text tttarmaduras;
    public Text tttselecion;
    public Text tttdiarios;
    public Text tttinventario;
    public Text tttextras;
    public Text tttguia;
    public Text tttguia2;

    public Text ta1r;
    public Text ta2r;
    public Text ta3r;
    public Text tfriends;

    public Text tguia1;
    public Text tguia2;
    public Text tguia3;


    public Text ttguia1;
    public Text ttguia2;
    public Text ttguia3;
    public Text ttguia4;
    public Text ttguia5;
    public Text ttguia6;




























    public GameObject juego;
    public GameObject pausa1;
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
    public float temp;

    public GameObject guia;
	public GameObject guia2;
    public bool guiaboton;
	public bool guiaboton2;

    public AudioSource diario1;
    public AudioSource diario2;
    public AudioSource diario3;
    public AudioSource diario4;
    public AudioSource diario5;
    public AudioSource diario6;
    public AudioSource diario7;
    public AudioSource diario8;
    public AudioSource diario9;
    public AudioSource diario10;
    public AudioSource diario11;
    public AudioSource diario12;
    public AudioSource diario13;
    public AudioSource diario14;
    public AudioSource diario15;

    public AudioSource diario1es;
    public AudioSource diario2es;
    public AudioSource diario3es;
    public AudioSource diario4es;
    public AudioSource diario5es;
    public AudioSource diario6es;
    public AudioSource diario7es;
    public AudioSource diario8es;
    public AudioSource diario9es;
    public AudioSource diario10es;
    public AudioSource diario11es;
    public AudioSource diario12es;
    public AudioSource diario13es;
    public AudioSource diario14es;
    public AudioSource diario15es;

    public AudioSource diario1en;
    public AudioSource diario2en;
    public AudioSource diario3en;
    public AudioSource diario4en;
    public AudioSource diario5en;
    public AudioSource diario6en;
    public AudioSource diario7en;
    public AudioSource diario8en;
    public AudioSource diario9en;
    public AudioSource diario10en;
    public AudioSource diario11en;
    public AudioSource diario12en;
    public AudioSource diario13en;
    public AudioSource diario14en;
    public AudioSource diario15en;

    public AudioSource diario1cat;
    public AudioSource diario2cat;
    public AudioSource diario3cat;
    public AudioSource diario4cat;
    public AudioSource diario5cat;
    public AudioSource diario6cat;
    public AudioSource diario7cat;
    public AudioSource diario8cat;
    public AudioSource diario9cat;
    public AudioSource diario10cat;
    public AudioSource diario11cat;
    public AudioSource diario12cat;
    public AudioSource diario13cat;
    public AudioSource diario14cat;
    public AudioSource diario15cat;

    public AudioSource tut1;
    public AudioSource tut2;
    public AudioSource tut3;
    public AudioSource tut4;
    public AudioSource tut5;
    public AudioSource tut6;

    public AudioSource tut1es;
    public AudioSource tut2es;
    public AudioSource tut3es;
    public AudioSource tut4es;
    public AudioSource tut5es;
    public AudioSource tut6es;

    public AudioSource tut1en;
    public AudioSource tut2en;
    public AudioSource tut3en;
    public AudioSource tut4en;
    public AudioSource tut5en;
    public AudioSource tut6en;

    public AudioSource tut1cat;
    public AudioSource tut2cat;
    public AudioSource tut3cat;
    public AudioSource tut4cat;
    public AudioSource tut5cat;
    public AudioSource tut6cat;

    public AudioSource no;

    public Text vidai;
    public Text fuerzai;
    public Text resi;
    public Text armasi;
    public Text armadurasi;
    public Text diariosi;


    public jugador1_al3 jugador;
    public GameObject menuc;
    public GameObject armadurasc;
    public GameObject armasc;
    public GameObject seleccionc;
    public GameObject diariosc;
    public GameObject inventarioc;
    public GameObject extrasc;
    public GameObject guiac;
    public GameObject guia2c;


    public int armaduras1 = 0;
    public bool armaduras1act = false;
    public int armaduras2 = 0;
    public bool armaduras2act = false;
    public int armas1 = 0;
    public bool armas1act = false;
    public int armas2 = 0;
    public bool armas2act = false;
    public int armas3 = 0;
    public bool armas3act = false;
    public int armas4 = 0;
    public bool armas4act = false;


    public Text slotsel;



    public Text armasel1;
    public Text armasel2;
    public Text armasel3;
    public Text armasel4;
    public Text armadsel1;
    public Text armadsel2;

    public Text armadselec;
    public Text armaselec;


    public Text arma1m;
    public Text arma2m;
    public Text arma3m;
    public Text arma4m;
    public Text arma5m;
    public Text arma6m;
    public Text arma7m;
    public Text arma8m;
    public Text arma9m;
    public Text arma10m;
    public Text arma11m;
    public Text arma12m;
    public Text arma13m;
    public Text arma14m;
    public Text arma15m;


    public Text armad1m;
    public Text armad2m;
    public Text armad3m;
    public Text armad4m;
    public Text armad5m;
    public Text armad6m;
    public Text armad7m;
    public Text armad8m;
    public Text armad9m;
    public Text armad10m;


    public Text arma1sel;
    public Text arma2sel;
    public Text arma3sel;
    public Text arma4sel;
    public Text arma5sel;
    public Text arma6sel;
    public Text arma7sel;
    public Text arma8sel;
    public Text arma9sel;
    public Text arma10sel;
    public Text arma11sel;
    public Text arma12sel;
    public Text arma13sel;
    public Text arma14sel;
    public Text arma15sel;


    public Text armad1sel;
    public Text armad2sel;
    public Text armad3sel;
    public Text armad4sel;
    public Text armad5sel;
    public Text armad6sel;
    public Text armad7sel;
    public Text armad8sel;
    public Text armad9sel;
    public Text armad10sel;

    public bool dev = false;
        // Start is called before the first frame update
    void Start()
    {
        manager_al3 manager = (manager_al3)FindFirstObjectByType(typeof(manager_al3));
        



        if(manager.datosconfig.idioma == "es")
        {
            tut1 = tut1es;
            tut2 = tut2es;
            tut3 = tut3es;
            tut4 = tut4es;
            tut5 = tut5es;
            tut6 = tut6es;

            diario1 = diario1es;
            diario2 = diario2es;
            diario3 = diario3es;
            diario4 = diario4es;
            diario5 = diario5es;
            diario6 = diario6es;
            diario7 = diario7es;
            diario8 = diario8es;
            diario9 = diario9es;
            diario10 = diario10es;
            diario11 = diario11es;
            diario12 = diario12es;
            diario13 = diario13es;
            diario14 = diario14es;
            diario15 = diario15es;
        }
        if(manager.datosconfig.idioma == "en")
        {
            tut1 = tut1en;
            tut2 = tut2en;
            tut3 = tut3en;
            tut4 = tut4en;
            tut5 = tut5en;
            tut6 = tut6en;

            diario1 = diario1en;
            diario2 = diario2en;
            diario3 = diario3en;
            diario4 = diario4en;
            diario5 = diario5en;
            diario6 = diario6en;
            diario7 = diario7en;
            diario8 = diario8en;
            diario9 = diario9en;
            diario10 = diario10en;
            diario11 = diario11en;
            diario12 = diario12en;
            diario13 = diario13en;
            diario14 = diario14en;
            diario15 = diario15en;
        }
        if(manager.datosconfig.idioma == "cat")
        {
            tut1 = tut1cat;
            tut2 = tut2cat;
            tut3 = tut3cat;
            tut4 = tut4cat;
            tut5 = tut5cat;
            tut6 = tut6cat;

            diario1 = diario1cat;
            diario2 = diario2cat;
            diario3 = diario3cat;
            diario4 = diario4cat;
            diario5 = diario5cat;
            diario6 = diario6cat;
            diario7 = diario7cat;
            diario8 = diario8cat;
            diario9 = diario9cat;
            diario10 = diario10cat;
            diario11 = diario11cat;
            diario12 = diario12cat;
            diario13 = diario13cat;
            diario14 = diario14cat;
            diario15 = diario15cat;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(controles.al3.pausa.ReadValue<float>() > 0 && temp > 0.5f)
        {
            if(opciones1.activeSelf)
            {aplicar2();}
            continuar();
        }
        if(temp < 15)
        {temp += 1 * Time.deltaTime;}


        if(manager.datosconfig.idioma == "es")
        {

            ta1r.text = "the alien 1 trailer";
            ta2r.text = "the alien 2 trailer";
            ta3r.text = "the alien 3 trailer";
            tfriends.text = "friends adventure trailer";

            

            ttcont.text = "continuar";
            ttarmas.text = "armas";
            ttarmaduras.text = "armaduras";
            ttselecion.text = "seleccion rapida";
            ttdiarios.text = "diarios";
            ttinventario.text = "inventario";
            ttextras.text = "extras";
            ttguia.text = "guia de controles";
            ttopciones.text = "opciones";
            ttsalir.text = "salir";

            ttatras1.text = "atras";
            ttatras2.text = "atras";
            ttatras3.text = "atras";
            ttatras4.text = "atras";
            ttatras5.text = "atras";
            ttatras6.text = "atras";
            ttatras7.text = "atras";
            ttatras8.text = "atras";

            ttpausa1.text = "pausa";
            ttpausa2.text = "pausa";
            ttpausa3.text = "pausa";
            ttpausa4.text = "pausa";
            ttpausa5.text = "pausa";
            ttpausa6.text = "pausa";
            ttpausa7.text = "pausa";
            ttpausa8.text = "pausa";

            tttarmas.text = "armas";
            tttarmaduras.text = "armaduras";
            tttselecion.text = "seleccion rapida";
            tttdiarios.text = "diarios de papa";
            tttinventario.text = "inventario";
            tttextras.text = "extras";
            tttguia.text = "guia de controles";
            tttguia2.text = "guia de controles";

            tguia1.text = "mando";
            tguia2.text = "teclado y raton";
            tguia3.text = "habilidades especificas";


            ttguia1.text = "plataforma de velocidad";
            ttguia2.text = "plataforma de salto";
            ttguia3.text = "plataforma de jetpack y armadura jetpack";
            ttguia4.text = "guantes de escalada";
            ttguia5.text = "gancho y puntos de soporte";
            ttguia6.text = "casco de oxigeno y gases";

            if(manager.datosserial.tdiario1 == 1)
            {
                ttdiario1.text = "pagina 1";
            }
            if(manager.datosserial.tdiario1 == 0)
            {
                ttdiario1.text = "pagina ?";
            }
            if(manager.datosserial.tdiario2 == 1)
            {
                ttdiario2.text = "pagina 2";
            }
            if(manager.datosserial.tdiario2 == 0)
            {
                ttdiario2.text = "pagina ?";
            }
            if(manager.datosserial.tdiario3 == 1)
            {
                ttdiario3.text = "pagina 3";
            }
            if(manager.datosserial.tdiario3 == 0)
            {
                ttdiario3.text = "pagina ?";
            }
            if(manager.datosserial.tdiario4 == 1)
            {
                ttdiario4.text = "pagina 4";
            }
            if(manager.datosserial.tdiario4 == 0)
            {
                ttdiario4.text = "pagina ?";
            }
            if(manager.datosserial.tdiario5 == 1)
            {
                ttdiario5.text = "pagina 5";
            }
            if(manager.datosserial.tdiario5 == 0)
            {
                ttdiario5.text = "pagina ?";
            }
            if(manager.datosserial.tdiario6 == 1)
            {
                ttdiario6.text = "pagina 6";
            }
            if(manager.datosserial.tdiario6 == 0)
            {
                ttdiario6.text = "pagina ?";
            }
            if(manager.datosserial.tdiario7 == 1)
            {
                ttdiario7.text = "pagina 7";
            }
            if(manager.datosserial.tdiario7 == 0)
            {
                ttdiario7.text = "pagina ?";
            }
            if(manager.datosserial.tdiario8 == 1)
            {
                ttdiario8.text = "pagina 8";
            }
            if(manager.datosserial.tdiario8 == 0)
            {
                ttdiario8.text = "pagina ?";
            }
            if(manager.datosserial.tdiario9 == 1)
            {
                ttdiario9.text = "pagina 9";
            }
            if(manager.datosserial.tdiario9 == 0)
            {
                ttdiario9.text = "pagina ?";
            }
            if(manager.datosserial.tdiario10 == 1)
            {
                ttdiario10.text = "pagina 10";
            }
            if(manager.datosserial.tdiario10 == 0)
            {
                ttdiario10.text = "pagina ?";
            }
            if(manager.datosserial.tdiario11 == 1)
            {
                ttdiario11.text = "pagina 11";
            }
            if(manager.datosserial.tdiario11 == 0)
            {
                ttdiario11.text = "pagina ?";
            }
            if(manager.datosserial.tdiario12 == 1)
            {
                ttdiario12.text = "pagina 12";
            }
            if(manager.datosserial.tdiario12 == 0)
            {
                ttdiario12.text = "pagina ?";
            }
            if(manager.datosserial.tdiario13 == 1)
            {
                ttdiario13.text = "pagina 13";
            }
            if(manager.datosserial.tdiario13 == 0)
            {
                ttdiario13.text = "pagina ?";
            }
            if(manager.datosserial.tdiario14 == 1)
            {
                ttdiario14.text = "pagina 14";
            }
            if(manager.datosserial.tdiario14 == 0)
            {
                ttdiario14.text = "pagina ?";
            }
            if(manager.datosserial.tdiario15 == 1)
            {
                ttdiario15.text = "pagina 15";
            }
            if(manager.datosserial.tdiario15 == 0)
            {
                ttdiario15.text = "pagina ?";
            }
            

            

            if(armaduras1act == true)
            {slotsel.text = "slot 1 armaduras";}
            else if(armaduras2act == true)
            {slotsel.text = "slot 2 armaduras";}
            else if(armas1act == true)
            {slotsel.text = "slot 1 armas";}
            else if(armas2act == true)
            {slotsel.text = "slot 2 armas";}
            else if(armas3act == true)
            {slotsel.text = "slot 3 armas";}
            else if(armas4act == true)
            {slotsel.text = "slot 4 armas";}
            else{slotsel.text = "";}




            if(manager.datosserial.tarmad[0] == 1)
            {
                armad1m.text = "casco de oxigeno";
                armad1sel.text = "casco de oxigeno";
            }
            if(manager.datosserial.tarmad[1] == 1)
            {
                armad2m.text = "proteccion al magma";
                armad2sel.text = "proteccion al magma";
            }
            if(manager.datosserial.tarmad[2] == 1)
            {
                armad3m.text = "armadura de proteccion x2";
                armad3sel.text = "armadura de proteccion x2";
            }
            if(manager.datosserial.tarmad[3] == 1)
            {
                armad4m.text = "armadura de proteccion x3";
                armad4sel.text = "armadura de proteccion x3";
            }
            if(manager.datosserial.tarmad[4] == 1)
            {
                armad5m.text = "armadura antigravedad";
                armad5sel.text = "armadura antigravedad";
            }
            if(manager.datosserial.tarmad[5] == 1)
            {
                armad6m.text = "armadura de gravedad";
                armad6sel.text = "armadura de gravedad";
            }
            if(manager.datosserial.tarmad[6] == 1)
            {
                armad7m.text = "armadura jetpack";
                armad7sel.text = "armadura jetpack";
            }
            if(manager.datosserial.tarmad[7] == 1)
            {
                armad8m.text = "guantes de fuerza x2";
                armad8sel.text = "guantes de fuerza x2";
            }
            if(manager.datosserial.tarmad[8] == 1)
            {
                armad9m.text = "guantes de fuerza x3";
                armad9sel.text = "guantes de fuerza x3";
            }
            if(manager.datosserial.tarmad[9] == 1)
            {
                armad10m.text = "guantes de escalada";
                armad10sel.text = "guantes de escalada";
            }

            if(manager.datosserial.tarma[0] == 1)
            {
                arma1m.text = "arma de papa";
                arma1sel.text = "arma de papa";
            }
            if(manager.datosserial.tarma[1] == 1)
            {
                arma2m.text = "arma de mama";
                arma2sel.text = "arma de mama";
            }
            if(manager.datosserial.tarma[2] == 1)
            {
                arma3m.text = "dispara palos";
                arma3sel.text = "dispara palos";
            }
            if(manager.datosserial.tarma[3] == 1)
            {
                arma4m.text = "arma del legado";
                arma4sel.text = "arma del legado";
            }
            if(manager.datosserial.tarma[4] == 1)
            {
                arma5m.text = "señuelo";
                arma5sel.text = "señuelo";
            }


            if(manager.datosserial.tarma[5] == 1)
            {
                arma6m.text = "disparo atomico";
                arma6sel.text = "disparo atomico";
            }
            if(manager.datosserial.tarma[6] == 1)
            {
                arma7m.text = "metralla cuerpos";
                arma7sel.text = "metralla cuerpos";
            }
            if(manager.datosserial.tarma[7] == 1)
            {
                arma8m.text = "bomba bam";
                arma8sel.text = "bomba bam";
            }
            if(manager.datosserial.tarma[8] == 1)
            {
                arma9m.text = "zig zag bang";
                arma9sel.text = "zig zag bang";
            }
            if(manager.datosserial.tarma[9] == 1)
            {
                arma10m.text = "mataobjetivos";
                arma10sel.text = "mataobjetivos";
            }


            if(manager.datosserial.tarma[10] == 1)
            {
                arma11m.text = "dispara plataformas";
                arma11sel.text = "dispara plataformas";
            }
            if(manager.datosserial.tarma[11] == 1)
            {
                arma12m.text = "gancho";
                arma12sel.text = "gancho";
            }
            if(manager.datosserial.tarma[12] == 1)
            {
                arma13m.text = "dispara saltadores";
                arma13sel.text = "dispara saltadores";
            }
            if(manager.datosserial.tarma[13] == 1)
            {
                arma14m.text = "dispara aceleradores";
                arma14sel.text = "dispara aceleradores";
            }
            if(manager.datosserial.tarma[14] == 1)
            {
                arma15m.text = "destructora_1.0";
                arma15sel.text = "destructora_1.0";
            }













            if(manager.datosserial.armadurass1 == 1)
            {
                armadsel1.text = "casco de oxigeno";
            }
            if(manager.datosserial.armadurass1 == 2)
            {
                armadsel1.text = "proteccion al magma";
            }
            if(manager.datosserial.armadurass1 == 3)
            {
                armadsel1.text = "armadura de proteccion x2";
            }
            if(manager.datosserial.armadurass1 == 4)
            {
                armadsel1.text = "armadura de proteccion x3";
            }
            if(manager.datosserial.armadurass1 == 5)
            {
                armadsel1.text = "armadura antigravedad";
            }
            if(manager.datosserial.armadurass1 == 6)
            {
                armadsel1.text = "armadura de gravedad";
            }
            if(manager.datosserial.armadurass1 == 7)
            {
                armadsel1.text = "armadura jetpack";
            }
            if(manager.datosserial.armadurass1 == 8)
            {
                armadsel1.text = "guantes de fuerza x2";
            }
            if(manager.datosserial.armadurass1 == 9)
            {
                armadsel1.text = "guantes de fuerza x3";
            }
            if(manager.datosserial.armadurass1 == 10)
            {
                armadsel1.text = "guantes de escalada";
            }
            if(manager.datosserial.armadurass1 == 0)
            {
                armadsel1.text = "slot 1 armaduras";
            }

            if(manager.datosserial.armadurass2 == 1)
            {
                armadsel2.text = "casco de oxigeno";
            }
            if(manager.datosserial.armadurass2 == 2)
            {
                armadsel2.text = "proteccion al magma";
            }
            if(manager.datosserial.armadurass2 == 3)
            {
                armadsel2.text = "armadura de proteccion x2";
            }
            if(manager.datosserial.armadurass2 == 4)
            {
                armadsel2.text = "armadura de proteccion x3";
            }
            if(manager.datosserial.armadurass2 == 5)
            {
                armadsel2.text = "armadura antigravedad";
            }
            if(manager.datosserial.armadurass2 == 6)
            {
                armadsel2.text = "armadura de gravedad";
            }
            if(manager.datosserial.armadurass2 == 7)
            {
                armadsel2.text = "armadura jetpack";
            }
            if(manager.datosserial.armadurass2 == 8)
            {
                armadsel2.text = "guantes de fuerza x2";
            }
            if(manager.datosserial.armadurass2 == 9)
            {
                armadsel2.text = "guantes de fuerza x3";
            }
            if(manager.datosserial.armadurass2 == 10)
            {
                armadsel2.text = "guantes de escalada";
            }
            if(manager.datosserial.armadurass2 == 0)
            {
                armadsel2.text = "slot 2 armaduras";
            }









            if(manager.datosserial.armass1 == 1)
            {
                armasel1.text = "arma de papa";
            }
            if(manager.datosserial.armass1 == 2)
            {
                armasel1.text = "arma de mama";
            }
            if(manager.datosserial.armass1 == 3)
            {
                armasel1.text = "dispara palos";
            }
            if(manager.datosserial.armass1 == 4)
            {
                armasel1.text = "arma del legado";
            }
            if(manager.datosserial.armass1 == 5)
            {
                armasel1.text = "señuelo";
            }


            if(manager.datosserial.armass1 == 6)
            {
                armasel1.text = "disparo atomico";
            }
            if(manager.datosserial.armass1 == 7)
            {
                armasel1.text = "metralla cuerpos";
            }
            if(manager.datosserial.armass1 == 8)
            {
                armasel1.text = "bomba bam";
            }
            if(manager.datosserial.armass1 == 9)
            {
                armasel1.text = "zig zag bang";
            }
            if(manager.datosserial.armass1 == 10)
            {
                armasel1.text = "mataobjetivos";
            }


            if(manager.datosserial.armass1 == 11)
            {
                armasel1.text = "dispara plataformas";
            }
            if(manager.datosserial.armass1 == 12)
            {
                armasel1.text = "gancho";
            }
            if(manager.datosserial.armass1 == 13)
            {
                armasel1.text = "dispara saltadores";
            }
            if(manager.datosserial.armass1 == 14)
            {
                armasel1.text = "dispara aceleradores";
            }
            if(manager.datosserial.armass1 == 15)
            {
                armasel1.text = "destructora_1.0";
            }
            if(manager.datosserial.armass1 == 0)
            {
                armasel1.text = "slot 1 armas";
            }




            if(manager.datosserial.armass2 == 1)
            {
                armasel2.text = "arma de papa";
            }
            if(manager.datosserial.armass2 == 2)
            {
                armasel2.text = "arma de mama";
            }
            if(manager.datosserial.armass2 == 3)
            {
                armasel2.text = "dispara palos";
            }
            if(manager.datosserial.armass2 == 4)
            {
                armasel2.text = "arma del legado";
            }
            if(manager.datosserial.armass2 == 5)
            {
                armasel2.text = "señuelo";
            }


            if(manager.datosserial.armass2 == 6)
            {
                armasel2.text = "disparo atomico";
            }
            if(manager.datosserial.armass2 == 7)
            {
                armasel2.text = "metralla cuerpos";
            }
            if(manager.datosserial.armass2 == 8)
            {
                armasel2.text = "bomba bam";
            }
            if(manager.datosserial.armass2 == 9)
            {
                armasel2.text = "zig zag bang";
            }
            if(manager.datosserial.armass2 == 10)
            {
                armasel2.text = "mataobjetivos";
            }


            if(manager.datosserial.armass2 == 11)
            {
                armasel2.text = "dispara plataformas";
            }
            if(manager.datosserial.armass2 == 12)
            {
                armasel2.text = "gancho";
            }
            if(manager.datosserial.armass2 == 13)
            {
                armasel2.text = "dispara saltadores";
            }
            if(manager.datosserial.armass2 == 14)
            {
                armasel2.text = "dispara aceleradores";
            }
            if(manager.datosserial.armass2 == 15)
            {
                armasel2.text = "destructora_1.0";
            }
            if(manager.datosserial.armass2 == 0)
            {
                armasel2.text = "slot 2 armas";
            }


            if(manager.datosserial.armass3 == 1)
            {
                armasel3.text = "arma de papa";
            }
            if(manager.datosserial.armass3 == 2)
            {
                armasel3.text = "arma de mama";
            }
            if(manager.datosserial.armass3 == 3)
            {
                armasel3.text = "dispara palos";
            }
            if(manager.datosserial.armass3 == 4)
            {
                armasel3.text = "arma del legado";
            }
            if(manager.datosserial.armass3 == 5)
            {
                armasel3.text = "señuelo";
            }


            if(manager.datosserial.armass3 == 6)
            {
                armasel3.text = "disparo atomico";
            }
            if(manager.datosserial.armass3 == 7)
            {
                armasel3.text = "metralla cuerpos";
            }
            if(manager.datosserial.armass3 == 8)
            {
                armasel3.text = "bomba bam";
            }
            if(manager.datosserial.armass3 == 9)
            {
                armasel3.text = "zig zag bang";
            }
            if(manager.datosserial.armass3 == 10)
            {
                armasel3.text = "mataobjetivos";
            }


            if(manager.datosserial.armass3 == 11)
            {
                armasel3.text = "dispara plataformas";
            }
            if(manager.datosserial.armass3 == 12)
            {
                armasel3.text = "gancho";
            }
            if(manager.datosserial.armass3 == 13)
            {
                armasel3.text = "dispara saltadores";
            }
            if(manager.datosserial.armass3 == 14)
            {
                armasel3.text = "dispara aceleradores";
            }
            if(manager.datosserial.armass3 == 15)
            {
                armasel3.text = "destructora_1.0";
            }
            if(manager.datosserial.armass3 == 0)
            {
                armasel3.text = "slot 3 armas";
            }


            if(manager.datosserial.armass4 == 1)
            {
                armasel4.text = "arma de papa";
            }
            if(manager.datosserial.armass4 == 2)
            {
                armasel4.text = "arma de mama";
            }
            if(manager.datosserial.armass4 == 3)
            {
                armasel4.text = "dispara palos";
            }
            if(manager.datosserial.armass4 == 4)
            {
                armasel4.text = "arma del legado";
            }
            if(manager.datosserial.armass4 == 5)
            {
                armasel4.text = "señuelo";
            }


            if(manager.datosserial.armass4 == 6)
            {
                armasel4.text = "disparo atomico";
            }
            if(manager.datosserial.armass4 == 7)
            {
                armasel4.text = "metralla cuerpos";
            }
            if(manager.datosserial.armass4 == 8)
            {
                armasel4.text = "bomba bam";
            }
            if(manager.datosserial.armass4 == 9)
            {
                armasel4.text = "zig zag bang";
            }
            if(manager.datosserial.armass4 == 10)
            {
                armasel4.text = "mataobjetivos";
            }


            if(manager.datosserial.armass4 == 11)
            {
                armasel4.text = "dispara plataformas";
            }
            if(manager.datosserial.armass4 == 12)
            {
                armasel4.text = "gancho";
            }
            if(manager.datosserial.armass4 == 13)
            {
                armasel4.text = "dispara saltadores";
            }
            if(manager.datosserial.armass4 == 14)
            {
                armasel4.text = "dispara aceleradores";
            }
            if(manager.datosserial.armass4 == 15)
            {
                armasel4.text = "destructora_1.0";
            }
            if(manager.datosserial.armass4 == 0)
            {
                armasel4.text = "slot 4 armas";
            }



            if(manager.datosserial.armadura == 1)
            {
                armadselec.text = "casco de oxigeno equipado";
            }
            if(manager.datosserial.armadura == 2)
            {
                armadselec.text = "proteccion al magma equipada";
            }
            if(manager.datosserial.armadura == 3)
            {
                armadselec.text = "armadura de proteccion x2 equipada";
            }
            if(manager.datosserial.armadura == 4)
            {
                armadselec.text = "armadura de proteccion x3 equipada";
            }
            if(manager.datosserial.armadura == 5)
            {
                armadselec.text = "armadura antigravedad equipada";
            }
            if(manager.datosserial.armadura == 6)
            {
                armadselec.text = "armadura de gravedad equipada";
            }
            if(manager.datosserial.armadura == 7)
            {
                armadselec.text = "armadura jetpack equipado";
            }
            if(manager.datosserial.armadura == 8)
            {
                armadselec.text = "guantes de fuerza x2  equipados";
            }
            if(manager.datosserial.armadura == 9)
            {
                armadselec.text = "guantes de fuerza x3  equipados";
            }
            if(manager.datosserial.armadura == 10)
            {
                armadselec.text = "guantes de escalada equipados";
            }
            if(manager.datosserial.armadura == 0)
            {
                armadselec.text = "";
            }


            if(manager.datosserial.arma == 1)
            {
                armaselec.text = "arma de papa equipada";
            }
            if(manager.datosserial.arma == 2)
            {
                armaselec.text = "arma de mama equipada";
            }
            if(manager.datosserial.arma == 3)
            {
                armaselec.text = "dispara palos equipado";
            }
            if(manager.datosserial.arma == 4)
            {
                armaselec.text = "arma del legado equipada";
            }
            if(manager.datosserial.arma == 5)
            {
                armaselec.text = "señuelo equipado";
            }


            if(manager.datosserial.arma == 6)
            {
                armaselec.text = "disparo atomico equipado";
            }
            if(manager.datosserial.arma == 7)
            {
                armaselec.text = "metralla cuerpos equipada";
            }
            if(manager.datosserial.arma == 8)
            {
                armaselec.text = "bomba bam equipada";
            }
            if(manager.datosserial.arma == 9)
            {
                armaselec.text = "zig zag bang equipada";
            }
            if(manager.datosserial.arma == 10)
            {
                armaselec.text = "mataobjetivos equipado";
            }


            if(manager.datosserial.arma == 11)
            {
                armaselec.text = "dispara plataformas equipado";
            }
            if(manager.datosserial.arma == 12)
            {
                armaselec.text = "gancho  equipado";
            }
            if(manager.datosserial.arma == 13)
            {
                armaselec.text = "dispara saltadores equipado";
            }
            if(manager.datosserial.arma == 14)
            {
                armaselec.text = "dispara aceleradores equipado";
            }
            if(manager.datosserial.arma == 15)
            {
                armaselec.text = "destructora_1.0 equipada";
            }
            if(manager.datosserial.arma == 0)
            {
                armaselec.text = "";
            }
        }
        if(manager.datosconfig.idioma == "en")
        {

            ta1r.text = "the alien 1 trailer";
            ta2r.text = "the alien 2 trailer";
            ta3r.text = "the alien 3 trailer";
            tfriends.text = "friends adventure trailer";


            ttcont.text = "continuar";
            ttarmas.text = "guns";
            ttarmaduras.text = "armor";
            ttselecion.text = "quick selection";
            ttdiarios.text = "diaries";
            ttinventario.text = "inventory";
            ttextras.text = "extras";
            ttguia.text = "guide of controls";
            ttopciones.text = "settings";
            ttsalir.text = "exit";

            ttatras1.text = "back";
            ttatras2.text = "back";
            ttatras3.text = "back";
            ttatras4.text = "back";
            ttatras5.text = "back";
            ttatras6.text = "back";
            ttatras7.text = "back";
            ttatras8.text = "back";

            ttpausa1.text = "pause";
            ttpausa2.text = "pause";
            ttpausa3.text = "pause";
            ttpausa4.text = "pause";
            ttpausa5.text = "pause";
            ttpausa6.text = "pause";
            ttpausa7.text = "pause";
            ttpausa8.text = "pause";

            tttarmas.text = "guns";
            tttarmaduras.text = "armor";
            tttselecion.text = "quick selection";
            tttdiarios.text = "dad diaries";
            tttinventario.text = "inventory";
            tttextras.text = "extras";
            tttguia.text = "guide of controls";
            tttguia2.text = "guide of controls";

            tguia1.text = "controller";
            tguia2.text = "keyboard and mouse";
            tguia3.text = "specific skills";

            ttguia1.text = "speed platform";
            ttguia2.text = "jumping platform";
            ttguia3.text = "jetpack platform and jetpack armor";
            ttguia4.text = "climbing gloves";
            ttguia5.text = "hook and support points";
            ttguia6.text = "oxygen and gas helmet";


            if(manager.datosserial.tdiario1 == 1)
            {
                ttdiario1.text = "page 1";
            }
            if(manager.datosserial.tdiario1 == 0)
            {
                ttdiario1.text = "page ?";
            }
            if(manager.datosserial.tdiario2 == 1)
            {
                ttdiario2.text = "page 2";
            }
            if(manager.datosserial.tdiario2 == 0)
            {
                ttdiario2.text = "page ?";
            }
            if(manager.datosserial.tdiario3 == 1)
            {
                ttdiario3.text = "page 3";
            }
            if(manager.datosserial.tdiario3 == 0)
            {
                ttdiario3.text = "page ?";
            }
            if(manager.datosserial.tdiario4 == 1)
            {
                ttdiario4.text = "page 4";
            }
            if(manager.datosserial.tdiario4 == 0)
            {
                ttdiario4.text = "page ?";
            }
            if(manager.datosserial.tdiario5 == 1)
            {
                ttdiario5.text = "page 5";
            }
            if(manager.datosserial.tdiario5 == 0)
            {
                ttdiario5.text = "page ?";
            }
            if(manager.datosserial.tdiario6 == 1)
            {
                ttdiario6.text = "page 6";
            }
            if(manager.datosserial.tdiario6 == 0)
            {
                ttdiario6.text = "page ?";
            }
            if(manager.datosserial.tdiario7 == 1)
            {
                ttdiario7.text = "page 7";
            }
            if(manager.datosserial.tdiario7 == 0)
            {
                ttdiario7.text = "page ?";
            }
            if(manager.datosserial.tdiario8 == 1)
            {
                ttdiario8.text = "page 8";
            }
            if(manager.datosserial.tdiario8 == 0)
            {
                ttdiario8.text = "page ?";
            }
            if(manager.datosserial.tdiario9 == 1)
            {
                ttdiario9.text = "page 9";
            }
            if(manager.datosserial.tdiario9 == 0)
            {
                ttdiario9.text = "page ?";
            }
            if(manager.datosserial.tdiario10 == 1)
            {
                ttdiario10.text = "page 10";
            }
            if(manager.datosserial.tdiario10 == 0)
            {
                ttdiario10.text = "page ?";
            }
            if(manager.datosserial.tdiario11 == 1)
            {
                ttdiario11.text = "page 11";
            }
            if(manager.datosserial.tdiario11 == 0)
            {
                ttdiario11.text = "page ?";
            }
            if(manager.datosserial.tdiario12 == 1)
            {
                ttdiario12.text = "page 12";
            }
            if(manager.datosserial.tdiario12 == 0)
            {
                ttdiario12.text = "page ?";
            }
            if(manager.datosserial.tdiario13 == 1)
            {
                ttdiario13.text = "page 13";
            }
            if(manager.datosserial.tdiario13 == 0)
            {
                ttdiario13.text = "page ?";
            }
            if(manager.datosserial.tdiario14 == 1)
            {
                ttdiario14.text = "page 14";
            }
            if(manager.datosserial.tdiario14 == 0)
            {
                ttdiario14.text = "page ?";
            }
            if(manager.datosserial.tdiario15 == 1)
            {
                ttdiario15.text = "page 15";
            }
            if(manager.datosserial.tdiario15 == 0)
            {
                ttdiario15.text = "page ?";
            }


            if(armaduras1act == true)
            {slotsel.text = "slot 1 armaduras";}
            else if(armaduras2act == true)
            {slotsel.text = "slot 2 armaduras";}
            else if(armas1act == true)
            {slotsel.text = "slot 1 armas";}
            else if(armas2act == true)
            {slotsel.text = "slot 2 armas";}
            else if(armas3act == true)
            {slotsel.text = "slot 3 armas";}
            else if(armas4act == true)
            {slotsel.text = "slot 4 armas";}
            else{slotsel.text = "";}




            if(manager.datosserial.tarmad[0] == 1)
            {
                armad1m.text = "oxygen helmet";
                armad1sel.text = "oxygen helmet";
            }
            if(manager.datosserial.tarmad[1] == 1)
            {
                armad2m.text = "magma protection";
                armad2sel.text = "magma protection";
            }
            if(manager.datosserial.tarmad[2] == 1)
            {
                armad3m.text = "protective armor x2";
                armad3sel.text = "protective armor x2";
            }
            if(manager.datosserial.tarmad[3] == 1)
            {
                armad4m.text = "protective armor x3";
                armad4sel.text = "protective armor x3";
            }
            if(manager.datosserial.tarmad[4] == 1)
            {
                armad5m.text = "antigravity armor";
                armad5sel.text = "antigravity armor";
            }
            if(manager.datosserial.tarmad[5] == 1)
            {
                armad6m.text = "gravity armor";
                armad6sel.text = "gravity armor";
            }
            if(manager.datosserial.tarmad[6] == 1)
            {
                armad7m.text = "jetpack armor";
                armad7sel.text = "jetpack armor";
            }
            if(manager.datosserial.tarmad[7] == 1)
            {
                armad8m.text = "strength gloves x2";
                armad8sel.text = "strength gloves x2";
            }
            if(manager.datosserial.tarmad[8] == 1)
            {
                armad9m.text = "strength gloves x3";
                armad9sel.text = "strength gloves x3";
            }
            if(manager.datosserial.tarmad[9] == 1)
            {
                armad10m.text = "climbing gloves";
                armad10sel.text = "climbing gloves";
            }

            if(manager.datosserial.tarma[0] == 1)
            {
                arma1m.text = "dad's gun";
                arma1sel.text = "dad's gun";
            }
            if(manager.datosserial.tarma[1] == 1)
            {
                arma2m.text = "mom gun";
                arma2sel.text = "mom gun";
            }
            if(manager.datosserial.tarma[2] == 1)
            {
                arma3m.text = "shoot sticks";
                arma3sel.text = "shoot sticks";
            }
            if(manager.datosserial.tarma[3] == 1)
            {
                arma4m.text = "legacy weapon";
                arma4sel.text = "legacy weapon";
            }
            if(manager.datosserial.tarma[4] == 1)
            {
                arma5m.text = "lure gun";
                arma5sel.text = "lure gun";
            }


            if(manager.datosserial.tarma[5] == 1)
            {
                arma6m.text = "atomic shot";
                arma6sel.text = "atomic shot";
            }
            if(manager.datosserial.tarma[6] == 1)
            {
                arma7m.text = "machine gun";
                arma7sel.text = "machine gun";
            }
            if(manager.datosserial.tarma[7] == 1)
            {
                arma8m.text = "bomb bam";
                arma8sel.text = "bomb bam";
            }
            if(manager.datosserial.tarma[8] == 1)
            {
                arma9m.text = "zig zag bang";
                arma9sel.text = "zig zag bang";
            }
            if(manager.datosserial.tarma[9] == 1)
            {
                arma10m.text = "kill targets";
                arma10sel.text = "kill targets";
            }


            if(manager.datosserial.tarma[10] == 1)
            {
                arma11m.text = "shoot floors";
                arma11sel.text = "shoot floors";
            }
            if(manager.datosserial.tarma[11] == 1)
            {
                arma12m.text = "hook";
                arma12sel.text = "hook";
            }
            if(manager.datosserial.tarma[12] == 1)
            {
                arma13m.text = "shoot jumpers";
                arma13sel.text = "shoot jumpers";
            }
            if(manager.datosserial.tarma[13] == 1)
            {
                arma14m.text = "shoot accelerators";
                arma14sel.text = "shoot accelerators";
            }
            if(manager.datosserial.tarma[14] == 1)
            {
                arma15m.text = "destroyer_1.0";
                arma15sel.text = "destroyer_1.0";
            }













            if(manager.datosserial.armadurass1 == 1)
            {
                armadsel1.text = "oxygen helmet";
            }
            if(manager.datosserial.armadurass1 == 2)
            {
                armadsel1.text = "magma protection";
            }
            if(manager.datosserial.armadurass1 == 3)
            {
                armadsel1.text = "protective armor x2";
            }
            if(manager.datosserial.armadurass1 == 4)
            {
                armadsel1.text = "protective armor x3";
            }
            if(manager.datosserial.armadurass1 == 5)
            {
                armadsel1.text = "antigravity armor";
            }
            if(manager.datosserial.armadurass1 == 6)
            {
                armadsel1.text = "gravity armor";
            }
            if(manager.datosserial.armadurass1 == 7)
            {
                armadsel1.text = "jetpack armor";
            }
            if(manager.datosserial.armadurass1 == 8)
            {
                armadsel1.text = "strength gloves x2";
            }
            if(manager.datosserial.armadurass1 == 9)
            {
                armadsel1.text = "strength gloves x3";
            }
            if(manager.datosserial.armadurass1 == 10)
            {
                armadsel1.text = "climbing gloves";
            }
            if(manager.datosserial.armadurass1 == 0)
            {
                armadsel1.text = "slot 1 armors";
            }

            if(manager.datosserial.armadurass2 == 1)
            {
                armadsel2.text = "oxygen helmet";
            }
            if(manager.datosserial.armadurass2 == 2)
            {
                armadsel2.text = "magma protection";
            }
            if(manager.datosserial.armadurass2 == 3)
            {
                armadsel2.text = "protective armor x2";
            }
            if(manager.datosserial.armadurass2 == 4)
            {
                armadsel2.text = "protective armor x3";
            }
            if(manager.datosserial.armadurass2 == 5)
            {
                armadsel2.text = "antigravity armor";
            }
            if(manager.datosserial.armadurass2 == 6)
            {
                armadsel2.text = "gravity armor";
            }
            if(manager.datosserial.armadurass2 == 7)
            {
                armadsel2.text = "jetpack armor";
            }
            if(manager.datosserial.armadurass2 == 8)
            {
                armadsel2.text = "strength gloves x2";
            }
            if(manager.datosserial.armadurass2 == 9)
            {
                armadsel2.text = "strength gloves x3";
            }
            if(manager.datosserial.armadurass2 == 10)
            {
                armadsel2.text = "climbing gloves";
            }
            if(manager.datosserial.armadurass2 == 0)
            {
                armadsel2.text = "slot 2 armors";
            }









            if(manager.datosserial.armass1 == 1)
            {
                armasel1.text = "dad's gun";
            }
            if(manager.datosserial.armass1 == 2)
            {
                armasel1.text = "mom gun";
            }
            if(manager.datosserial.armass1 == 3)
            {
                armasel1.text = "shoot sticks";
            }
            if(manager.datosserial.armass1 == 4)
            {
                armasel1.text = "legacy weapon";
            }
            if(manager.datosserial.armass1 == 5)
            {
                armasel1.text = "lure gun";
            }


            if(manager.datosserial.armass1 == 6)
            {
                armasel1.text = "atomic shot";
            }
            if(manager.datosserial.armass1 == 7)
            {
                armasel1.text = "machine gun";
            }
            if(manager.datosserial.armass1 == 8)
            {
                armasel1.text = "bomb bam";
            }
            if(manager.datosserial.armass1 == 9)
            {
                armasel1.text = "zig zag bang";
            }
            if(manager.datosserial.armass1 == 10)
            {
                armasel1.text = "kill targets";
            }


            if(manager.datosserial.armass1 == 11)
            {
                armasel1.text = "shoot floors";
            }
            if(manager.datosserial.armass1 == 12)
            {
                armasel1.text = "hook";
            }
            if(manager.datosserial.armass1 == 13)
            {
                armasel1.text = "shoot jumpers";
            }
            if(manager.datosserial.armass1 == 14)
            {
                armasel1.text = "shoot accelerators";
            }
            if(manager.datosserial.armass1 == 15)
            {
                armasel1.text = "destroyer_1.0";
            }
            if(manager.datosserial.armass1 == 0)
            {
                armasel1.text = "slot 1 guns";
            }



            if(manager.datosserial.armass2 == 1)
            {
                armasel2.text = "dad's gun";
            }
            if(manager.datosserial.armass2 == 2)
            {
                armasel2.text = "mom gun";
            }
            if(manager.datosserial.armass2 == 3)
            {
                armasel2.text = "shoot sticks";
            }
            if(manager.datosserial.armass2 == 4)
            {
                armasel2.text = "legacy weapon";
            }
            if(manager.datosserial.armass2 == 5)
            {
                armasel2.text = "lure gun";
            }


            if(manager.datosserial.armass2 == 6)
            {
                armasel2.text = "atomic shot";
            }
            if(manager.datosserial.armass2 == 7)
            {
                armasel2.text = "machine gun";
            }
            if(manager.datosserial.armass2 == 8)
            {
                armasel2.text = "bomb bam";
            }
            if(manager.datosserial.armass2 == 9)
            {
                armasel2.text = "zig zag bang";
            }
            if(manager.datosserial.armass2 == 10)
            {
                armasel2.text = "kill targets";
            }


            if(manager.datosserial.armass2 == 11)
            {
                armasel2.text = "shoot floors";
            }
            if(manager.datosserial.armass2 == 12)
            {
                armasel2.text = "hook";
            }
            if(manager.datosserial.armass2 == 13)
            {
                armasel2.text = "shoot jumpers";
            }
            if(manager.datosserial.armass2 == 14)
            {
                armasel2.text = "shoot accelerators";
            }
            if(manager.datosserial.armass2 == 15)
            {
                armasel2.text = "destroyer_1.0";
            }
            if(manager.datosserial.armass2 == 0)
            {
                armasel2.text = "slot 2 guns";
            }


            if(manager.datosserial.armass3 == 1)
            {
                armasel3.text = "dad's gun";
            }
            if(manager.datosserial.armass3 == 2)
            {
                armasel3.text = "mom gun";
            }
            if(manager.datosserial.armass3 == 3)
            {
                armasel3.text = "shoot sticks";
            }
            if(manager.datosserial.armass3 == 4)
            {
                armasel3.text = "legacy weapon";
            }
            if(manager.datosserial.armass3 == 5)
            {
                armasel3.text = "lure gun";
            }


            if(manager.datosserial.armass3 == 6)
            {
                armasel3.text = "atomic shot";
            }
            if(manager.datosserial.armass3 == 7)
            {
                armasel3.text = "machine gun";
            }
            if(manager.datosserial.armass3 == 8)
            {
                armasel3.text = "bomb bam";
            }
            if(manager.datosserial.armass3 == 9)
            {
                armasel3.text = "zig zag bang";
            }
            if(manager.datosserial.armass3 == 10)
            {
                armasel3.text = "kill targets";
            }


            if(manager.datosserial.armass3 == 11)
            {
                armasel3.text = "shoot floors";
            }
            if(manager.datosserial.armass3 == 12)
            {
                armasel3.text = "hook";
            }
            if(manager.datosserial.armass3 == 13)
            {
                armasel3.text = "shoot jumpers";
            }
            if(manager.datosserial.armass3 == 14)
            {
                armasel3.text = "shoot accelerators";
            }
            if(manager.datosserial.armass3 == 15)
            {
                armasel3.text = "destroyer_1.0";
            }
            if(manager.datosserial.armass3 == 0)
            {
                armasel3.text = "slot 3 guns";
            }

            if(manager.datosserial.armass4 == 1)
            {
                armasel4.text = "dad's gun";
            }
            if(manager.datosserial.armass4 == 2)
            {
                armasel4.text = "mom gun";
            }
            if(manager.datosserial.armass4 == 3)
            {
                armasel4.text = "shoot sticks";
            }
            if(manager.datosserial.armass4 == 4)
            {
                armasel4.text = "legacy weapon";
            }
            if(manager.datosserial.armass4 == 5)
            {
                armasel4.text = "lure gun";
            }


            if(manager.datosserial.armass4 == 6)
            {
                armasel4.text = "atomic shot";
            }
            if(manager.datosserial.armass4 == 7)
            {
                armasel4.text = "machine gun";
            }
            if(manager.datosserial.armass4 == 8)
            {
                armasel4.text = "bomb bam";
            }
            if(manager.datosserial.armass4 == 9)
            {
                armasel4.text = "zig zag bang";
            }
            if(manager.datosserial.armass4 == 10)
            {
                armasel4.text = "kill targets";
            }


            if(manager.datosserial.armass4 == 11)
            {
                armasel4.text = "shoot floors";
            }
            if(manager.datosserial.armass4 == 12)
            {
                armasel4.text = "hook";
            }
            if(manager.datosserial.armass4 == 13)
            {
                armasel4.text = "shoot jumpers";
            }
            if(manager.datosserial.armass4 == 14)
            {
                armasel4.text = "shoot accelerators";
            }
            if(manager.datosserial.armass4 == 15)
            {
                armasel4.text = "destroyer_1.0";
            }
            if(manager.datosserial.armass4 == 0)
            {
                armasel4.text = "slot 4 guns";
            }
            



            if(manager.datosserial.armadura == 1)
            {
                armadselec.text = "equipped oxygen helmet";
            }
            if(manager.datosserial.armadura == 2)
            {
                armadselec.text = "equipped magma protection";
            }
            if(manager.datosserial.armadura == 3)
            {
                armadselec.text = "equipped protective armor x2";
            }
            if(manager.datosserial.armadura == 4)
            {
                armadselec.text = "equipped protective armor x3";
            }
            if(manager.datosserial.armadura == 5)
            {
                armadselec.text = "equipped antigravity armor";
            }
            if(manager.datosserial.armadura == 6)
            {
                armadselec.text = "equipped gravity armor";
            }
            if(manager.datosserial.armadura == 7)
            {
                armadselec.text = "equipped jetpack armor";
            }
            if(manager.datosserial.armadura == 8)
            {
                armadselec.text = "equipped strength gloves x2";
            }
            if(manager.datosserial.armadura == 9)
            {
                armadselec.text = "equipped strength gloves x3";
            }
            if(manager.datosserial.armadura == 10)
            {
                armadselec.text = "equipped climbing gloves";
            }
            if(manager.datosserial.armadura == 0)
            {
                armadselec.text = "";
            }


            if(manager.datosserial.arma == 1)
            {
                armaselec.text = "equipped dad's gun";
            }
            if(manager.datosserial.arma == 2)
            {
                armaselec.text = "equipped mom gun";
            }
            if(manager.datosserial.arma == 3)
            {
                armaselec.text = "equipped shoot sticks";
            }
            if(manager.datosserial.arma == 4)
            {
                armaselec.text = "equipped legacy weapon";
            }
            if(manager.datosserial.arma == 5)
            {
                armaselec.text = "equipped lure gun";
            }


            if(manager.datosserial.arma == 6)
            {
                armaselec.text = "equipped atomic shot";
            }
            if(manager.datosserial.arma == 7)
            {
                armaselec.text = "equipped machine gun";
            }
            if(manager.datosserial.arma == 8)
            {
                armaselec.text = "equipped bomb bam";
            }
            if(manager.datosserial.arma == 9)
            {
                armaselec.text = "equipped zig zag bang";
            }
            if(manager.datosserial.arma == 10)
            {
                armaselec.text = "equipped kill targets";
            }


            if(manager.datosserial.arma == 11)
            {
                armaselec.text = "equipped shoot floors";
            }
            if(manager.datosserial.arma == 12)
            {
                armaselec.text = "equipped hook";
            }
            if(manager.datosserial.arma == 13)
            {
                armaselec.text = "equipped shoot jumpers";
            }
            if(manager.datosserial.arma == 14)
            {
                armaselec.text = "equipped shoot accelerators";
            }
            if(manager.datosserial.arma == 15)
            {
                armaselec.text = "equipped destroyer_1.0";
            }
            if(manager.datosserial.arma == 0)
            {
                armaselec.text = "";
            }
        }
        if(manager.datosconfig.idioma == "cat")
        {
            ta1r.text = "the alien 1 trailer";
            ta2r.text = "the alien 2 trailer";
            ta3r.text = "the alien 3 trailer";
            tfriends.text = "friends adventure trailer";

            ttcont.text = "continuar";
            ttarmas.text = "armas";
            ttarmaduras.text = "armadures";
            ttselecion.text = "seleccio rapida";
            ttdiarios.text = "diari";
            ttinventario.text = "inventari";
            ttextras.text = "extras";
            ttguia.text = "guia de controls";
            ttopciones.text = "opcions";
            ttsalir.text = "sortir";

            ttatras1.text = "anrere";
            ttatras2.text = "anrere";
            ttatras3.text = "anrere";
            ttatras4.text = "anrere";
            ttatras5.text = "anrere";
            ttatras6.text = "anrere";
            ttatras7.text = "anrere";
            ttatras8.text = "anrere";

            ttpausa1.text = "pausa";
            ttpausa2.text = "pausa";
            ttpausa3.text = "pausa";
            ttpausa4.text = "pausa";
            ttpausa5.text = "pausa";
            ttpausa6.text = "pausa";
            ttpausa7.text = "pausa";
            ttpausa8.text = "pausa";

            tttarmas.text = "armas";
            tttarmaduras.text = "armadures";
            tttselecion.text = "seleccio rapida";
            tttdiarios.text = "diari d en pare";
            tttinventario.text = "inventari";
            tttextras.text = "extras";
            tttguia.text = "guia de controls";
            tttguia2.text = "guia de controls";

            tguia1.text = "mando";
            tguia2.text = "teclat y rato";
            tguia3.text = "habilitats especifiques";

            ttguia1.text = "plataforma de velocitat";
            ttguia2.text = "plataforma de salt";
            ttguia3.text = "plataforma de jetpack y armadura jetpack";
            ttguia4.text = "guants de escalada";
            ttguia5.text = "ganxo y punts de suport";
            ttguia6.text = "casc de oxigen y gasos";

            if(manager.datosserial.tdiario1 == 1)
            {
                ttdiario1.text = "pagina 1";
            }
            if(manager.datosserial.tdiario1 == 0)
            {
                ttdiario1.text = "pagina ?";
            }
            if(manager.datosserial.tdiario2 == 1)
            {
                ttdiario2.text = "pagina 2";
            }
            if(manager.datosserial.tdiario2 == 0)
            {
                ttdiario2.text = "pagina ?";
            }
            if(manager.datosserial.tdiario3 == 1)
            {
                ttdiario3.text = "pagina 3";
            }
            if(manager.datosserial.tdiario3 == 0)
            {
                ttdiario3.text = "pagina ?";
            }
            if(manager.datosserial.tdiario4 == 1)
            {
                ttdiario4.text = "pagina 4";
            }
            if(manager.datosserial.tdiario4 == 0)
            {
                ttdiario4.text = "pagina ?";
            }
            if(manager.datosserial.tdiario5 == 1)
            {
                ttdiario5.text = "pagina 5";
            }
            if(manager.datosserial.tdiario5 == 0)
            {
                ttdiario5.text = "pagina ?";
            }
            if(manager.datosserial.tdiario6 == 1)
            {
                ttdiario6.text = "pagina 6";
            }
            if(manager.datosserial.tdiario6 == 0)
            {
                ttdiario6.text = "pagina ?";
            }
            if(manager.datosserial.tdiario7 == 1)
            {
                ttdiario7.text = "pagina 7";
            }
            if(manager.datosserial.tdiario7 == 0)
            {
                ttdiario7.text = "pagina ?";
            }
            if(manager.datosserial.tdiario8 == 1)
            {
                ttdiario8.text = "pagina 8";
            }
            if(manager.datosserial.tdiario8 == 0)
            {
                ttdiario8.text = "pagina ?";
            }
            if(manager.datosserial.tdiario9 == 1)
            {
                ttdiario9.text = "pagina 9";
            }
            if(manager.datosserial.tdiario9 == 0)
            {
                ttdiario9.text = "pagina ?";
            }
            if(manager.datosserial.tdiario10 == 1)
            {
                ttdiario10.text = "pagina 10";
            }
            if(manager.datosserial.tdiario10 == 0)
            {
                ttdiario10.text = "pagina ?";
            }
            if(manager.datosserial.tdiario11 == 1)
            {
                ttdiario11.text = "pagina 11";
            }
            if(manager.datosserial.tdiario11 == 0)
            {
                ttdiario11.text = "pagina ?";
            }
            if(manager.datosserial.tdiario12 == 1)
            {
                ttdiario12.text = "pagina 12";
            }
            if(manager.datosserial.tdiario12 == 0)
            {
                ttdiario12.text = "pagina ?";
            }
            if(manager.datosserial.tdiario13 == 1)
            {
                ttdiario13.text = "pagina 13";
            }
            if(manager.datosserial.tdiario13 == 0)
            {
                ttdiario13.text = "pagina ?";
            }
            if(manager.datosserial.tdiario14 == 1)
            {
                ttdiario14.text = "pagina 14";
            }
            if(manager.datosserial.tdiario14 == 0)
            {
                ttdiario14.text = "pagina ?";
            }
            if(manager.datosserial.tdiario15 == 1)
            {
                ttdiario15.text = "pagina 15";
            }
            if(manager.datosserial.tdiario15 == 0)
            {
                ttdiario15.text = "pagina ?";
            }

            if(armaduras1act == true)
            {slotsel.text = "slot 1 armadures";}
            else if(armaduras2act == true)
            {slotsel.text = "slot 2 armadures";}
            else if(armas1act == true)
            {slotsel.text = "slot 1 armas";}
            else if(armas2act == true)
            {slotsel.text = "slot 2 armas";}
            else if(armas3act == true)
            {slotsel.text = "slot 3 armas";}
            else if(armas4act == true)
            {slotsel.text = "slot 4 armas";}
            else{slotsel.text = "";}




            if(manager.datosserial.tarmad[0] == 1)
            {
                armad1m.text = "casc de oxigen";
                armad1sel.text = "casc de oxigen";
            }
            if(manager.datosserial.tarmad[1] == 1)
            {
                armad2m.text = "proteccio al magma";
                armad2sel.text = "proteccio al magma";
            }
            if(manager.datosserial.tarmad[2] == 1)
            {
                armad3m.text = "armadura de proteccio x2";
                armad3sel.text = "armadura de proteccio x2";
            }
            if(manager.datosserial.tarmad[3] == 1)
            {
                armad4m.text = "armadura de proteccio x3";
                armad4sel.text = "armadura de proteccio x3";
            }
            if(manager.datosserial.tarmad[4] == 1)
            {
                armad5m.text = "armadura antigravetat";
                armad5sel.text = "armadura antigravetat";
            }
            if(manager.datosserial.tarmad[5] == 1)
            {
                armad6m.text = "armadura de gravetat";
                armad6sel.text = "armadura de gravetat";
            }
            if(manager.datosserial.tarmad[6] == 1)
            {
                armad7m.text = "armadura jetpack";
                armad7sel.text = "armadura jetpack";
            }
            if(manager.datosserial.tarmad[7] == 1)
            {
                armad8m.text = "guants de forca x2";
                armad8sel.text = "guants de forca x2";
            }
            if(manager.datosserial.tarmad[8] == 1)
            {
                armad9m.text = "guants de forca x3";
                armad9sel.text = "guants de forca x3";
            }
            if(manager.datosserial.tarmad[9] == 1)
            {
                armad10m.text = "guants de escalada";
                armad10sel.text = "guants de escalada";
            }

            if(manager.datosserial.tarma[0] == 1)
            {
                arma1m.text = "arma d en pare";
                arma1sel.text = "arma d en pare";
            }
            if(manager.datosserial.tarma[1] == 1)
            {
                arma2m.text = "arma d la mara";
                arma2sel.text = "arma d la mara";
            }
            if(manager.datosserial.tarma[2] == 1)
            {
                arma3m.text = "dispara pals";
                arma3sel.text = "dispara pals";
            }
            if(manager.datosserial.tarma[3] == 1)
            {
                arma4m.text = "arma del llegat";
                arma4sel.text = "arma del llegat";
            }
            if(manager.datosserial.tarma[4] == 1)
            {
                arma5m.text = "arma distraccio";
                arma5sel.text = "arma distraccio";
            }


            if(manager.datosserial.tarma[5] == 1)
            {
                arma6m.text = "dispar atomic";
                arma6sel.text = "dispar atomic";
            }
            if(manager.datosserial.tarma[6] == 1)
            {
                arma7m.text = "metralla cosos";
                arma7sel.text = "metralla cosos";
            }
            if(manager.datosserial.tarma[7] == 1)
            {
                arma8m.text = "bomba bam";
                arma8sel.text = "bomba bam";
            }
            if(manager.datosserial.tarma[8] == 1)
            {
                arma9m.text = "zig zag bang";
                arma9sel.text = "zig zag bang";
            }
            if(manager.datosserial.tarma[9] == 1)
            {
                arma10m.text = "mataobjetius";
                arma10sel.text = "mataobjetius";
            }


            if(manager.datosserial.tarma[10] == 1)
            {
                arma11m.text = "dispara plataformas";
                arma11sel.text = "dispara plataformas";
            }
            if(manager.datosserial.tarma[11] == 1)
            {
                arma12m.text = "ganxo";
                arma12sel.text = "ganxo";
            }
            if(manager.datosserial.tarma[12] == 1)
            {
                arma13m.text = "dispara saltadors";
                arma13sel.text = "dispara saltadors";
            }
            if(manager.datosserial.tarma[13] == 1)
            {
                arma14m.text = "dispara atceleradors";
                arma14sel.text = "dispara atceleradors";
            }
            if(manager.datosserial.tarma[14] == 1)
            {
                arma15m.text = "destructora_1.0";
                arma15sel.text = "destructora_1.0";
            }













            if(manager.datosserial.armadurass1 == 1)
            {
                armadsel1.text = "casc de oxigen";
            }
            if(manager.datosserial.armadurass1 == 2)
            {
                armadsel1.text = "proteccio al magma";
            }
            if(manager.datosserial.armadurass1 == 3)
            {
                armadsel1.text = "armadura de proteccio x2";
            }
            if(manager.datosserial.armadurass1 == 4)
            {
                armadsel1.text = "armadura de proteccio x3";
            }
            if(manager.datosserial.armadurass1 == 5)
            {
                armadsel1.text = "armadura antigravetat";
            }
            if(manager.datosserial.armadurass1 == 6)
            {
                armadsel1.text = "armadura de gravetat";
            }
            if(manager.datosserial.armadurass1 == 7)
            {
                armadsel1.text = "armadura jetpack";
            }
            if(manager.datosserial.armadurass1 == 8)
            {
                armadsel1.text = "guants de forca x2";
            }
            if(manager.datosserial.armadurass1 == 9)
            {
                armadsel1.text = "guants de forca x3";
            }
            if(manager.datosserial.armadurass1 == 10)
            {
                armadsel1.text = "guants de escalada";
            }
            if(manager.datosserial.armadurass1 == 0)
            {
                armadsel1.text = "slot 1 armadures";
            }

            if(manager.datosserial.armadurass2 == 1)
            {
                armadsel2.text = "casc de oxigen";
            }
            if(manager.datosserial.armadurass2 == 2)
            {
                armadsel2.text = "proteccio al magma";
            }
            if(manager.datosserial.armadurass2 == 3)
            {
                armadsel2.text = "armadura de proteccio x2";
            }
            if(manager.datosserial.armadurass2 == 4)
            {
                armadsel2.text = "armadura de proteccio x3";
            }
            if(manager.datosserial.armadurass2 == 5)
            {
                armadsel2.text = "armadura antigravetat";
            }
            if(manager.datosserial.armadurass2 == 6)
            {
                armadsel2.text = "armadura de gravetat";
            }
            if(manager.datosserial.armadurass2 == 7)
            {
                armadsel2.text = "armadura jetpack";
            }
            if(manager.datosserial.armadurass2 == 8)
            {
                armadsel2.text = "guants de forca x2";
            }
            if(manager.datosserial.armadurass2 == 9)
            {
                armadsel2.text = "guants de forca x3";
            }
            if(manager.datosserial.armadurass2 == 10)
            {
                armadsel2.text = "guants de escalada";
            }
            if(manager.datosserial.armadurass2 == 0)
            {
                armadsel2.text = "slot 2 armadures";
            }









            if(manager.datosserial.armass1 == 1)
            {
                armasel1.text = "arma d en pare";
            }
            if(manager.datosserial.armass1 == 2)
            {
                armasel1.text = "arma d la mare";
            }
            if(manager.datosserial.armass1 == 3)
            {
                armasel1.text = "dispara pals";
            }
            if(manager.datosserial.armass1 == 4)
            {
                armasel1.text = "arma del llegat";
            }
            if(manager.datosserial.armass1 == 5)
            {
                armasel1.text = "arma distraccio";
            }


            if(manager.datosserial.armass1 == 6)
            {
                armasel1.text = "dispar atomic";
            }
            if(manager.datosserial.armass1 == 7)
            {
                armasel1.text = "metralla cosos";
            }
            if(manager.datosserial.armass1 == 8)
            {
                armasel1.text = "bomba bam";
            }
            if(manager.datosserial.armass1 == 9)
            {
                armasel1.text = "zig zag bang";
            }
            if(manager.datosserial.armass1 == 10)
            {
                armasel1.text = "mataobjetius";
            }


            if(manager.datosserial.armass1 == 11)
            {
                armasel1.text = "dispara plataformas";
            }
            if(manager.datosserial.armass1 == 12)
            {
                armasel1.text = "ganxo";
            }
            if(manager.datosserial.armass1 == 13)
            {
                armasel1.text = "dispara saltadors";
            }
            if(manager.datosserial.armass1 == 14)
            {
                armasel1.text = "dispara atceleradors";
            }
            if(manager.datosserial.armass1 == 15)
            {
                armasel1.text = "destructora_1.0";
            }
            if(manager.datosserial.armass1 == 0)
            {
                armasel1.text = "slot 1 armas";
            }




            if(manager.datosserial.armass2 == 1)
            {
                armasel2.text = "arma d en pare";
            }
            if(manager.datosserial.armass2 == 2)
            {
                armasel2.text = "arma d la mare";
            }
            if(manager.datosserial.armass2 == 3)
            {
                armasel2.text = "dispara pals";
            }
            if(manager.datosserial.armass2 == 4)
            {
                armasel2.text = "arma del llegat";
            }
            if(manager.datosserial.armass2 == 5)
            {
                armasel2.text = "arma distraccio";
            }


            if(manager.datosserial.armass2 == 6)
            {
                armasel2.text = "dispar atomic";
            }
            if(manager.datosserial.armass2 == 7)
            {
                armasel2.text = "metralla cosos";
            }
            if(manager.datosserial.armass2 == 8)
            {
                armasel2.text = "bomba bam";
            }
            if(manager.datosserial.armass2 == 9)
            {
                armasel2.text = "zig zag bang";
            }
            if(manager.datosserial.armass2 == 10)
            {
                armasel2.text = "mataobjetius";
            }


            if(manager.datosserial.armass2 == 11)
            {
                armasel2.text = "dispara plataformas";
            }
            if(manager.datosserial.armass2 == 12)
            {
                armasel2.text = "ganxo";
            }
            if(manager.datosserial.armass2 == 13)
            {
                armasel2.text = "dispara saltadors";
            }
            if(manager.datosserial.armass2 == 14)
            {
                armasel2.text = "dispara atceleradors";
            }
            if(manager.datosserial.armass2 == 15)
            {
                armasel2.text = "destructora_1.0";
            }
            if(manager.datosserial.armass2 == 0)
            {
                armasel2.text = "slot 2 armas";
            }


            if(manager.datosserial.armass3 == 1)
            {
                armasel3.text = "arma d en pare";
            }
            if(manager.datosserial.armass3 == 2)
            {
                armasel3.text = "arma d la mare";
            }
            if(manager.datosserial.armass3 == 3)
            {
                armasel3.text = "dispara pals";
            }
            if(manager.datosserial.armass3 == 4)
            {
                armasel3.text = "arma del llegat";
            }
            if(manager.datosserial.armass3 == 5)
            {
                armasel3.text = "arma distraccio";
            }


            if(manager.datosserial.armass3 == 6)
            {
                armasel3.text = "dispar atomic";
            }
            if(manager.datosserial.armass3 == 7)
            {
                armasel3.text = "metralla cosos";
            }
            if(manager.datosserial.armass3 == 8)
            {
                armasel3.text = "bomba bam";
            }
            if(manager.datosserial.armass3 == 9)
            {
                armasel3.text = "zig zag bang";
            }
            if(manager.datosserial.armass3 == 10)
            {
                armasel3.text = "mataobjetius";
            }


            if(manager.datosserial.armass3 == 11)
            {
                armasel3.text = "dispara plataformas";
            }
            if(manager.datosserial.armass3 == 12)
            {
                armasel3.text = "ganxo";
            }
            if(manager.datosserial.armass3 == 13)
            {
                armasel3.text = "dispara saltadors";
            }
            if(manager.datosserial.armass3 == 14)
            {
                armasel3.text = "dispara atceleradors";
            }
            if(manager.datosserial.armass3 == 15)
            {
                armasel3.text = "destructora_1.0";
            }
            if(manager.datosserial.armass3 == 0)
            {
                armasel3.text = "slot 3 armas";
            }


            if(manager.datosserial.armass4 == 1)
            {
                armasel4.text = "arma d en pare";
            }
            if(manager.datosserial.armass4 == 2)
            {
                armasel4.text = "arma d la mare";
            }
            if(manager.datosserial.armass4 == 3)
            {
                armasel4.text = "dispara pals";
            }
            if(manager.datosserial.armass4 == 4)
            {
                armasel4.text = "arma del llegat";
            }
            if(manager.datosserial.armass4 == 5)
            {
                armasel4.text = "arma distraccio";
            }


            if(manager.datosserial.armass4 == 6)
            {
                armasel4.text = "dispar atomic";
            }
            if(manager.datosserial.armass4 == 7)
            {
                armasel4.text = "metralla cosos";
            }
            if(manager.datosserial.armass4 == 8)
            {
                armasel4.text = "bomba bam";
            }
            if(manager.datosserial.armass4 == 9)
            {
                armasel4.text = "zig zag bang";
            }
            if(manager.datosserial.armass4 == 10)
            {
                armasel4.text = "mataobjetius";
            }


            if(manager.datosserial.armass4 == 11)
            {
                armasel4.text = "dispara plataformas";
            }
            if(manager.datosserial.armass4 == 12)
            {
                armasel4.text = "ganxo";
            }
            if(manager.datosserial.armass4 == 13)
            {
                armasel4.text = "dispara saltadors";
            }
            if(manager.datosserial.armass4 == 14)
            {
                armasel4.text = "dispara atceleradors";
            }
            if(manager.datosserial.armass4 == 15)
            {
                armasel4.text = "destructora_1.0";
            }
            if(manager.datosserial.armass4 == 0)
            {
                armasel4.text = "slot 4 armas";
            }



            if(manager.datosserial.armadura == 1)
            {
                armadselec.text = "casc de oxigen equipat";
            }
            if(manager.datosserial.armadura == 2)
            {
                armadselec.text = "proteccio al magma equipat";
            }
            if(manager.datosserial.armadura == 3)
            {
                armadselec.text = "armadura de proteccio x2 equipat";
            }
            if(manager.datosserial.armadura == 4)
            {
                armadselec.text = "armadura de proteccio x3 equipat";
            }
            if(manager.datosserial.armadura == 5)
            {
                armadselec.text = "armadura antigravetat equipat";
            }
            if(manager.datosserial.armadura == 6)
            {
                armadselec.text = "armadura de gravetat equipat";
            }
            if(manager.datosserial.armadura == 7)
            {
                armadselec.text = "armadura jetpack equipat";
            }
            if(manager.datosserial.armadura == 8)
            {
                armadselec.text = "guants de forca x2  equipat";
            }
            if(manager.datosserial.armadura == 9)
            {
                armadselec.text = "guants de forca x3  equipat";
            }
            if(manager.datosserial.armadura == 10)
            {
                armadselec.text = "guants de escalada equipat";
            }
            if(manager.datosserial.armadura == 0)
            {
                armadselec.text = "";
            }


            if(manager.datosserial.arma == 1)
            {
                armaselec.text = "arma d en pare equipat";
            }
            if(manager.datosserial.arma == 2)
            {
                armaselec.text = "arma d la mama equipat";
            }
            if(manager.datosserial.arma == 3)
            {
                armaselec.text = "dispara pals equipat";
            }
            if(manager.datosserial.arma == 4)
            {
                armaselec.text = "arma del llegat equipat";
            }
            if(manager.datosserial.arma == 5)
            {
                armaselec.text = "arma distraccio equipat";
            }


            if(manager.datosserial.arma == 6)
            {
                armaselec.text = "dispar atomic equipat";
            }
            if(manager.datosserial.arma == 7)
            {
                armaselec.text = "metralla cosos equipat";
            }
            if(manager.datosserial.arma == 8)
            {
                armaselec.text = "bomba bam equipat";
            }
            if(manager.datosserial.arma == 9)
            {
                armaselec.text = "zig zag bang equipada";
            }
            if(manager.datosserial.arma == 10)
            {
                armaselec.text = "mataobjetius equipat";
            }


            if(manager.datosserial.arma == 11)
            {
                armaselec.text = "dispara plataformas equipat";
            }
            if(manager.datosserial.arma == 12)
            {
                armaselec.text = "ganxo  equipat";
            }
            if(manager.datosserial.arma == 13)
            {
                armaselec.text = "dispara saltadors equipat";
            }
            if(manager.datosserial.arma == 14)
            {
                armaselec.text = "dispara atceleradors equipat";
            }
            if(manager.datosserial.arma == 15)
            {
                armaselec.text = "destructora_1.0 equipat";
            }
            if(manager.datosserial.arma == 0)
            {
                armaselec.text = "";
            }
        }













    }
    public void continuar(){
        menuc.SetActive(true);
        armadurasc.SetActive(false);
        diariosc.SetActive(false);
        inventarioc.SetActive(false);
        armasc.SetActive(false);
        seleccionc.SetActive(false);
        extrasc.SetActive(false);
        guiac.SetActive(false);
        guia2c.SetActive(false);
        armaduras1act = false;
        armaduras2act = false;
        temp = 0;
        juego.SetActive(true);
        jugador.selcarga = false;
        pausa1.SetActive(false);
        if(manager.datosconfig.plat == 1)
		{
			Cursor.visible = false;
        	Cursor.lockState = CursorLockMode.Locked;
		}
    }
    public void salir(){
        SceneManager.LoadScene("presentacion_al3");
        manager.datosserial.com = 0;
        manager.guardar();
    }
    public void armas()
    {
        menuc.SetActive(false);
        armasc.SetActive(true);
    }
    public void armaduras()
    {
        menuc.SetActive(false);
        armadurasc.SetActive(true);
    }
    public void seleccion()
    {
		pushup push = (pushup)FindFirstObjectByType(typeof(pushup));
        if(manager.datostrof.alien3entraaseleccionrapidaenelpause == 0)
        {
            manager.datostrof.alien3entraaseleccionrapidaenelpause = 1;
            manager.guardartro();
            push.push(79);
        }
        menuc.SetActive(false);
        seleccionc.SetActive(true);
    }
    public void diarios()
    {
        menuc.SetActive(false);
        diariosc.SetActive(true);
    }
    public void inventario()
    {

        
        if(manager.datosconfig.idioma == "es")
        {
            vidai.text = "pociones de vida : x"+manager.datosserial.pociones;
            fuerzai.text = "pociones de fuerza : x"+manager.datosserial.pocionfue;
            resi.text = "pociones de resistencia : x"+manager.datosserial.pocionres;
            armasi.text = "armas : "+manager.datosserial.armastotal+"/15";
            armadurasi.text = "armaduras : "+manager.datosserial.armadurastotal+"/10";
            diariosi.text = "diarios de papa : "+manager.datosserial.diariostotal+"/15";
        }
        if(manager.datosconfig.idioma == "en")
        {
            vidai.text = "life potions : x"+manager.datosserial.pociones;
            fuerzai.text = "strength potions : x"+manager.datosserial.pocionfue;
            resi.text = "stamina potions : x"+manager.datosserial.pocionres;
            armasi.text = "guns : "+manager.datosserial.armastotal+"/15";
            armadurasi.text = "armors : "+manager.datosserial.armadurastotal+"/10";
            diariosi.text = "dad diaries : "+manager.datosserial.diariostotal+"/15";
        }
        if(manager.datosconfig.idioma == "cat")
        {
            vidai.text = "pocions de vida : x"+manager.datosserial.pociones;
            fuerzai.text = "pocions de forca : x"+manager.datosserial.pocionfue;
            resi.text = "pocions de resistencia : x"+manager.datosserial.pocionres;
            armasi.text = "armas : "+manager.datosserial.armastotal+"/15";
            armadurasi.text = "armadures : "+manager.datosserial.armadurastotal+"/10";
            diariosi.text = "diaris de papa : "+manager.datosserial.diariostotal+"/15";
        }
        
        menuc.SetActive(false);
        inventarioc.SetActive(true);
    }
    public void extras()
    {
        manager_al3 manager = (manager_al3)FindFirstObjectByType(typeof(manager_al3));
		pushup push = (pushup)FindFirstObjectByType(typeof(pushup));
        if(manager.datostrof.alien3entraalmenuextras == 0)
        {
            manager.datostrof.alien3entraalmenuextras = 1;
            manager.guardartro();
            push.push(78);
        }
        menuc.SetActive(false);
        extrasc.SetActive(true);
    }
    public void guia_()
    {
        manager_al3 manager = (manager_al3)FindFirstObjectByType(typeof(manager_al3));
		pushup push = (pushup)FindFirstObjectByType(typeof(pushup));
        if(manager.datostrof.alien3entraalaguiadelpause == 0)
        {
            manager.datostrof.alien3entraalaguiadelpause = 1;
            manager.guardartro();
            push.push(77);
        }
        menuc.SetActive(false);
        guiac.SetActive(true);

    }
    public void guia_2_()
    {
        guiac.SetActive(false);
        guia2c.SetActive(true);
    }
    public void atras()
    {
        
        menuc.SetActive(true);
        armadurasc.SetActive(false);
        diariosc.SetActive(false);
        inventarioc.SetActive(false);
        armasc.SetActive(false);
        seleccionc.SetActive(false);
        extrasc.SetActive(false);
        guiac.SetActive(false);
        armaduras1act = false;
        armaduras2act = false;
        guia.SetActive(true);
        guia2.SetActive(false);
        guiaboton = true;
        guiaboton2 = false;
        guia2c.SetActive(false);
        diario1.Stop();
        diario2.Stop();
        diario3.Stop();
        diario4.Stop();
        diario5.Stop();
        diario6.Stop();
        diario7.Stop();
        diario8.Stop();
        diario9.Stop();
        diario10.Stop();
        diario11.Stop();
        diario12.Stop();
        diario13.Stop();
        diario14.Stop();
        diario15.Stop();
    }
    public void atras2()
    {
        
        menuc.SetActive(false);
        armadurasc.SetActive(false);
        diariosc.SetActive(false);
        inventarioc.SetActive(false);
        armasc.SetActive(false);
        seleccionc.SetActive(false);
        extrasc.SetActive(false);
        guiac.SetActive(true);
        armaduras1act = false;
        armaduras2act = false;
        guia.SetActive(true);
        guia2.SetActive(false);
        guiaboton = true;
        guiaboton2 = false;
        guia2c.SetActive(false);
        tut1.Stop();
        tut2.Stop();
        tut3.Stop();
        tut4.Stop();
        tut5.Stop();
        tut6.Stop();
    }

    public void tut_1()
    {
        tut1.Play();
        tut2.Stop();
        tut3.Stop();
        tut4.Stop();
        tut5.Stop();
        tut6.Stop();
    }
    public void tut_2()
    {
        tut1.Stop();
        tut2.Play();
        tut3.Stop();
        tut4.Stop();
        tut5.Stop();
        tut6.Stop();
    }
    public void tut_3()
    {
        tut1.Stop();
        tut2.Stop();
        tut3.Play();
        tut4.Stop();
        tut5.Stop();
        tut6.Stop();
    }
    public void tut_4()
    {
        tut1.Stop();
        tut2.Stop();
        tut3.Stop();
        tut4.Play();
        tut5.Stop();
        tut6.Stop();
    }
    public void tut_5()
    {
        tut1.Stop();
        tut2.Stop();
        tut3.Stop();
        tut4.Stop();
        tut5.Play();
        tut6.Stop();
    }
    public void tut_6()
    {
        tut1.Stop();
        tut2.Stop();
        tut3.Stop();
        tut4.Stop();
        tut5.Stop();
        tut6.Play();
    }



    public void armadura1()
    {
        if(manager.datosserial.tarmad[0] == 1)
        {
            manager.datosserial.armadura = 1;
            manager.guardar();
            jugador.jumpfcarga = false;
            
        }
        
    }
    public void armadura2()
    {
        if(manager.datosserial.tarmad[1] == 1)
        {
        manager.datosserial.armadura = 2;
        manager.guardar();
        jugador.jumpfcarga = false;
        }
        
    }
    public void armadura3()
    {
        if(manager.datosserial.tarmad[2] == 1)
        {
        manager.datosserial.armadura = 3;
        manager.guardar();
        jugador.jumpfcarga = false;
        }
        
    }
    public void armadura4()
    {
        if(manager.datosserial.tarmad[3] == 1)
        {
        manager.datosserial.armadura = 4;
        manager.guardar();
        jugador.jumpfcarga = false;
        }
        
    }

    public void armadura5()
    {
        if(manager.datosserial.tarmad[4] == 1)
        {
        manager.datosserial.armadura = 5;
        manager.guardar();
        jugador.jumpfcarga = false;
        }
        
    }
    public void armadura6()
    {
        if(manager.datosserial.tarmad[5] == 1)
        {
        manager.datosserial.armadura = 6;
        manager.guardar();
        jugador.jumpfcarga = false;
        }
    }
    public void armadura7()
    {
        if(manager.datosserial.tarmad[6] == 1)
        {
        manager.datosserial.armadura = 7;
        manager.guardar();
        jugador.jumpfcarga = false;
        }
    }
    public void armadura8()
    {
        if(manager.datosserial.tarmad[7] == 1)
        {
        manager.datosserial.armadura = 8;
        manager.guardar();
        jugador.jumpfcarga = false;
        }
    }
    public void armadura9()
    {
        if(manager.datosserial.tarmad[8] == 1)
        {
        manager.datosserial.armadura = 9;
        manager.guardar();
        jugador.jumpfcarga = false;
        }
    }
    public void armadura10()
    {
        if(manager.datosserial.tarmad[9] == 1)
        {
        manager.datosserial.armadura = 10;
        manager.guardar();
        jugador.jumpfcarga = false;
        }
    }


    public void arma1()
    {
        if(manager.datosserial.tarma[0] == 1)
        {
        manager.datosserial.arma = 1;
        manager.guardar();}
    }
    public void arma2()
    {
        if(manager.datosserial.tarma[1] == 1)
        {
        manager.datosserial.arma = 2;
        manager.guardar();}
    }
    public void arma3()
    {
        if(manager.datosserial.tarma[2] == 1)
        {
        manager.datosserial.arma = 3;
        manager.guardar();}
    }
    public void arma4()
    {
        if(manager.datosserial.tarma[3] == 1)
        {
        manager.datosserial.arma = 4;
        manager.guardar();}
    }
    public void arma5()
    {
        if(manager.datosserial.tarma[4] == 1)
        {
        manager.datosserial.arma = 5;
        manager.guardar();}
    }




    public void arma6()
    {
        if(manager.datosserial.tarma[5] == 1)
        {
        manager.datosserial.arma = 6;
        manager.guardar();}
    }
    public void arma7()
    {
        if(manager.datosserial.tarma[6] == 1)
        {
        manager.datosserial.arma = 7;
        manager.guardar();}
    }
    public void arma8()
    {
        if(manager.datosserial.tarma[7] == 1)
        {
        manager.datosserial.arma = 8;
        manager.guardar();}
    }
    public void arma9()
    {
        if(manager.datosserial.tarma[8] == 1)
        {
        manager.datosserial.arma = 9;
        manager.guardar();}
    }
    public void arma10()
    {
        if(manager.datosserial.tarma[9] == 1)
        {
        manager.datosserial.arma = 10;
        manager.guardar();}
    }

    public void arma11()
    {
        if(manager.datosserial.tarma[10] == 1)
        {
        manager.datosserial.arma = 11;
        manager.guardar();}
    }
    public void arma12()
    {
        if(manager.datosserial.tarma[11] == 1)
        {
        manager.datosserial.arma = 12;}
        manager.guardar();
    }
    public void arma13()
    {
        if(manager.datosserial.tarma[12] == 1)
        {
        manager.datosserial.arma = 13;
        manager.guardar();}
    }
    public void arma14()
    {
        if(manager.datosserial.tarma[13] == 1)
        {
        manager.datosserial.arma = 14;
        manager.guardar();}
    }
    public void arma15()
    {
        if(manager.datosserial.tarma[14] == 1)
        {
        manager.datosserial.arma = 15;
        manager.guardar();}
    }

    public void armaduras1_()
    {
        armas1act = false;
        armas2act = false;
        armas3act = false;
        armas4act = false;
        armaduras1act = true;
        armaduras2act = false;
        manager.datosserial.armadurass1 = 0;
        manager.guardar();
    }

    public void armaduras2_()
    {
        armas1act = false;
        armas2act = false;
        armas3act = false;
        armas4act = false;
        armaduras1act = false;
        armaduras2act = true;
        manager.datosserial.armadurass2 = 0;
        manager.guardar();
    }



    public void srarmadura1()
    {
        if(manager.datosserial.tarmad[0] == 1)
        {
        if(armaduras1act == true)
        {
            manager.datosserial.armadurass1 = 1;
            manager.guardar();
            armaduras1act = false;
        }
        if(armaduras2act == true)
        {
            manager.datosserial.armadurass2 = 1;
            manager.guardar();
            armaduras2act = false;
        
        }}
        
    }
    public void srarmadura2()
    {
        if(manager.datosserial.tarmad[1] == 1)
        {
        if(armaduras1act == true)
        {
            manager.datosserial.armadurass1 = 2;
            manager.guardar();
            armaduras1act = false;
        }
        if(armaduras2act == true)
        {
            manager.datosserial.armadurass2 = 2;
            manager.guardar();
            armaduras2act = false;
        
        }}
        
    }
    public void srarmadura3()
    {
        if(manager.datosserial.tarmad[2] == 1)
        {
        if(armaduras1act == true)
        {
            manager.datosserial.armadurass1 = 3;
            manager.guardar();
            armaduras1act = false;
        }
        if(armaduras2act == true)
        {
            manager.datosserial.armadurass2 = 3;
            manager.guardar();
            armaduras2act = false;
        
        }}
        
    }
    public void srarmadura4()
    {
        if(manager.datosserial.tarmad[3] == 1)
        {
        if(armaduras1act == true)
        {
            manager.datosserial.armadurass1 = 4;
            manager.guardar();
            armaduras1act = false;
        }
        if(armaduras2act == true)
        {
            manager.datosserial.armadurass2 = 4;
            manager.guardar();
            armaduras2act = false;
        
        }}
        
    }
    public void srarmadura5()
    {
        if(manager.datosserial.tarmad[4] == 1)
        {
        if(armaduras1act == true)
        {
            manager.datosserial.armadurass1 = 5;
            manager.guardar();
            armaduras1act = false;
        }
        if(armaduras2act == true)
        {
            manager.datosserial.armadurass2 = 5;
            manager.guardar();
            armaduras2act = false;
        
        }}
        
    }
    public void srarmadura6()
    {
        if(manager.datosserial.tarmad[5] == 1)
        {
        if(armaduras1act == true)
        {
            manager.datosserial.armadurass1 = 6;
            manager.guardar();
            armaduras1act = false;
        }
        if(armaduras2act == true)
        {
            manager.datosserial.armadurass2 = 6;
            manager.guardar();
            armaduras2act = false;
        
        }}
        
    }
    public void srarmadura7()
    {
        if(manager.datosserial.tarmad[6] == 1)
        {
        if(armaduras1act == true)
        {
            manager.datosserial.armadurass1 = 7;
            manager.guardar();
            armaduras1act = false;
        }
        if(armaduras2act == true)
        {
            manager.datosserial.armadurass2 = 7;
            manager.guardar();
            armaduras2act = false;
        
        }}
        
    }
    public void srarmadura8()
    {
        if(manager.datosserial.tarmad[7] == 1)
        {
        if(armaduras1act == true)
        {
            manager.datosserial.armadurass1 = 8;
            manager.guardar();
            armaduras1act = false;
        }
        if(armaduras2act == true)
        {
            manager.datosserial.armadurass2 = 8;
            manager.guardar();
            armaduras2act = false;
        
        }}
        
    }
    public void srarmadura9()
    {
        if(manager.datosserial.tarmad[8] == 1)
        {
        if(armaduras1act == true)
        {
            manager.datosserial.armadurass1 = 9;
            manager.guardar();
            armaduras1act = false;
        }
        if(armaduras2act == true)
        {
            manager.datosserial.armadurass2 = 9;
            manager.guardar();
            armaduras2act = false;
        
        }}
        
    }
    public void srarmadura10()
    {
        if(manager.datosserial.tarmad[9] == 1)
        {
        if(armaduras1act == true)
        {
            manager.datosserial.armadurass1 = 10;
            manager.guardar();
            armaduras1act = false;
        }
        if(armaduras2act == true)
        {
            manager.datosserial.armadurass2 = 10;
            manager.guardar();
            armaduras2act = false;
        
        }}
        
    }
    public void armas1_()
    {
        armas1act = true;
        armas2act = false;
        armas3act = false;
        armas4act = false;
        armaduras1act = false;
        armaduras2act = false;
        manager.datosserial.armass1 = 0;
        manager.guardar();

    }
    public void armas2_()
    {
        armas1act = false;
        armas2act = true;
        armas3act = false;
        armas4act = false;
        armaduras1act = false;
        armaduras2act = false;
        manager.datosserial.armass2 = 0;
        manager.guardar();
    }
    public void armas3_()
    {
        armas1act = false;
        armas2act = false;
        armas3act = true;
        armas4act = false;
        armaduras1act = false;
        armaduras2act = false;
        manager.datosserial.armass3 = 0;
        manager.guardar();
    }
    public void armas4_()
    {
        armas1act = false;
        armas2act = false;
        armas3act = false;
        armas4act = true;
        armaduras1act = false;
        armaduras2act = false;
        manager.datosserial.armass4 = 0;
        manager.guardar();
    }
    public void srarmas1()
    {
        if(manager.datosserial.tarma[0] == 1)
        {
        if(armas1act == true)
        {
            manager.datosserial.armass1 = 1;
            manager.guardar();
            armas1act = false;
        }
        if(armas2act == true)
        {
            manager.datosserial.armass2 = 1;
            manager.guardar();
            armas2act = false;
        }
        if(armas3act == true)
        {
            manager.datosserial.armass3 = 1;
            manager.guardar();
            armas3act = false;
        }
        if(armas4act == true)
        {
            manager.datosserial.armass4 = 1;
            manager.guardar();
            armas4act = false;
        }}
        
    }
    public void srarmas2()
    {
        if(manager.datosserial.tarma[1] == 1)
        {
        if(armas1act == true)
        {
            manager.datosserial.armass1 = 2;
            manager.guardar();
            armas1act = false;
        }
        if(armas2act == true)
        {
            manager.datosserial.armass2 = 2;
            manager.guardar();
            armas2act = false;
        }
        if(armas3act == true)
        {
            manager.datosserial.armass3 = 2;
            manager.guardar();
            armas3act = false;
        }
        if(armas4act == true)
        {
            manager.datosserial.armass4 = 2;
            manager.guardar();
            armas4act = false;
        }}
        
    }
    public void srarmas3()
    {
        if(manager.datosserial.tarma[2] == 1)
        {
        if(armas1act == true)
        {
            manager.datosserial.armass1 = 3;
            manager.guardar();
            armas1act = false;
        }
        if(armas2act == true)
        {
            manager.datosserial.armass2 = 3;
            manager.guardar();
            armas2act = false;
        }
        if(armas3act == true)
        {
            manager.datosserial.armass3 = 3;
            manager.guardar();
            armas3act = false;
        }
        if(armas4act == true)
        {
            manager.datosserial.armass4 = 3;
            manager.guardar();
            armas4act = false;
        }}
        
    }
    public void srarmas4()
    {
        if(manager.datosserial.tarma[3] == 1)
        {
        if(armas1act == true)
        {
            manager.datosserial.armass1 = 4;
            manager.guardar();
            armas1act = false;
        }
        if(armas2act == true)
        {
            manager.datosserial.armass2 = 4;
            manager.guardar();
            armas2act = false;
        }
        if(armas3act == true)
        {
            manager.datosserial.armass3 = 4;
            manager.guardar();
            armas3act = false;
        }
        if(armas4act == true)
        {
            manager.datosserial.armass4 = 4;
            manager.guardar();
            armas4act = false;
        }}
        
    }
    public void srarmas5()
    {
        if(manager.datosserial.tarma[4] == 1)
        {
        if(armas1act == true)
        {
            manager.datosserial.armass1 = 5;
            manager.guardar();
            armas1act = false;
        }
        if(armas2act == true)
        {
            manager.datosserial.armass2 = 5;
            manager.guardar();
            armas2act = false;
        }
        if(armas3act == true)
        {
            manager.datosserial.armass3 = 5;
            manager.guardar();
            armas3act = false;
        }
        if(armas4act == true)
        {
            manager.datosserial.armass4 = 5;
            manager.guardar();
            armas4act = false;
        }}
        
    }
    public void srarmas6()
    {
        if(manager.datosserial.tarma[5] == 1)
        {
        if(armas1act == true)
        {
            manager.datosserial.armass1 = 6;
            manager.guardar();
            armas1act = false;
        }
        if(armas2act == true)
        {
            manager.datosserial.armass2 = 6;
            manager.guardar();
            armas2act = false;
        }
        if(armas3act == true)
        {
            manager.datosserial.armass3 = 6;
            manager.guardar();
            armas3act = false;
        }
        if(armas4act == true)
        {
            manager.datosserial.armass4 = 6;
            manager.guardar();
            armas4act = false;
        }}
        
    }
    public void srarmas7()
    {
        if(manager.datosserial.tarma[6] == 1)
        {
        if(armas1act == true)
        {
            manager.datosserial.armass1 = 7;
            manager.guardar();
            armas1act = false;
        }
        if(armas2act == true)
        {
            manager.datosserial.armass2 = 7;
            manager.guardar();
            armas2act = false;
        }
        if(armas3act == true)
        {
            manager.datosserial.armass3 = 7;
            manager.guardar();
            armas3act = false;
        }
        if(armas4act == true)
        {
            manager.datosserial.armass4 = 7;
            manager.guardar();
            armas4act = false;
        }}
        
    }
    public void srarmas8()
    {
        if(manager.datosserial.tarma[7] == 1)
        {
        if(armas1act == true)
        {
            manager.datosserial.armass1 = 8;
            manager.guardar();
            armas1act = false;
        }
        if(armas2act == true)
        {
            manager.datosserial.armass2 = 8;
            manager.guardar();
            armas2act = false;
        }
        if(armas3act == true)
        {
            manager.datosserial.armass3 = 8;
            manager.guardar();
            armas3act = false;
        }
        if(armas4act == true)
        {
            manager.datosserial.armass4 = 8;
            manager.guardar();
            armas4act = false;
        }}
        
    }
    public void srarmas9()
    {
        if(manager.datosserial.tarma[8] == 1)
        {
        if(armas1act == true)
        {
            manager.datosserial.armass1 = 9;
            manager.guardar();
            armas1act = false;
        }
        if(armas2act == true)
        {
            manager.datosserial.armass2 = 9;
            manager.guardar();
            armas2act = false;
        }
        if(armas3act == true)
        {
            manager.datosserial.armass3 = 9;
            manager.guardar();
            armas3act = false;
        }
        if(armas4act == true)
        {
            manager.datosserial.armass4 = 9;
            manager.guardar();
            armas4act = false;
        }}
        
    }
    public void srarmas10()
    {
        if(manager.datosserial.tarma[9] == 1)
        {
        if(armas1act == true)
        {
            manager.datosserial.armass1 = 10;
            manager.guardar();
            armas1act = false;
        }
        if(armas2act == true)
        {
            manager.datosserial.armass2 = 10;
            manager.guardar();
            armas2act = false;
        }
        if(armas3act == true)
        {
            manager.datosserial.armass3 = 10;
            manager.guardar();
            armas3act = false;
        }
        if(armas4act == true)
        {
            manager.datosserial.armass4 = 10;
            manager.guardar();
            armas4act = false;
        }}
        
    }
    public void srarmas11()
    {
        if(manager.datosserial.tarma[10] == 1)
        {
        if(armas1act == true)
        {
            manager.datosserial.armass1 = 11;
            manager.guardar();
            armas1act = false;
        }
        if(armas2act == true)
        {
            manager.datosserial.armass2 = 11;
            manager.guardar();
            armas2act = false;
        }
        if(armas3act == true)
        {
            manager.datosserial.armass3 = 11;
            manager.guardar();
            armas3act = false;
        }
        if(armas4act == true)
        {
            manager.datosserial.armass4 = 11;
            manager.guardar();
            armas4act = false;
        }}
        
    }
    public void srarmas12()
    {
        if(manager.datosserial.tarma[11] == 1)
        {
        if(armas1act == true)
        {
            manager.datosserial.armass1 = 12;
            manager.guardar();
            armas1act = false;
        }
        if(armas2act == true)
        {
            manager.datosserial.armass2 = 12;
            manager.guardar();
            armas2act = false;
        }
        if(armas3act == true)
        {
            manager.datosserial.armass3 = 12;
            manager.guardar();
            armas3act = false;
        }
        if(armas4act == true)
        {
            manager.datosserial.armass4 = 12;
            manager.guardar();
            armas4act = false;
        }}
        
    }
    public void srarmas13()
    {
        if(manager.datosserial.tarma[12] == 1)
        {
        if(armas1act == true)
        {
            manager.datosserial.armass1 = 13;
            manager.guardar();
            armas1act = false;
        }
        if(armas2act == true)
        {
            manager.datosserial.armass2 = 13;
            manager.guardar();
            armas2act = false;
        }
        if(armas3act == true)
        {
            manager.datosserial.armass3 = 13;
            manager.guardar();
            armas3act = false;
        }
        if(armas4act == true)
        {
            manager.datosserial.armass4 = 13;
            manager.guardar();
            armas4act = false;
        }}
        
    }
    public void srarmas14()
    {
        if(manager.datosserial.tarma[13] == 1)
        {
        if(armas1act == true)
        {
            manager.datosserial.armass1 = 14;
            manager.guardar();
            armas1act = false;
        }
        if(armas2act == true)
        {
            manager.datosserial.armass2 = 14;
            manager.guardar();
            armas2act = false;
        }
        if(armas3act == true)
        {
            manager.datosserial.armass3 = 14;
            manager.guardar();
            armas3act = false;
        }
        if(armas4act == true)
        {
            manager.datosserial.armass4 = 14;
            manager.guardar();
            armas4act = false;
        }}
        
    }
    public void srarmas15()
    {
        if(manager.datosserial.tarma[14] == 1)
        {
        if(armas1act == true)
        {
            manager.datosserial.armass1 = 15;
            manager.guardar();
            armas1act = false;
        }
        if(armas2act == true)
        {
            manager.datosserial.armass2 = 15;
            manager.guardar();
            armas2act = false;
        }
        if(armas3act == true)
        {
            manager.datosserial.armass3 = 15;
            manager.guardar();
            armas3act = false;
        }
        if(armas4act == true)
        {
            manager.datosserial.armass4 = 15;
            manager.guardar();
            armas4act = false;
        }}
        
    }
    public void diario1_()
    {
        if(manager.datosserial.tdiario1 == 1)
        {
        diario1.Play();
        diario2.Stop();
        diario3.Stop();
        diario4.Stop();
        diario5.Stop();
        diario6.Stop();
        diario7.Stop();
        diario8.Stop();
        diario9.Stop();
        diario10.Stop();
        diario11.Stop();
        diario12.Stop();
        diario13.Stop();
        diario14.Stop();
        diario15.Stop();
		pushup push = (pushup)FindFirstObjectByType(typeof(pushup));
        if(manager.datostrof.alien3escuchaunapagina == 0)
        {
            manager.datostrof.alien3escuchaunapagina = 1;
            manager.guardartro();
            push.push(86);
        }
        }
        else{no.Play();}
    }
    public void diario2_()
    {
        if(manager.datosserial.tdiario2 == 1)
        {
        diario1.Stop();
        diario2.Play();
        diario3.Stop();
        diario4.Stop();
        diario5.Stop();
        diario6.Stop();
        diario7.Stop();
        diario8.Stop();
        diario9.Stop();
        diario10.Stop();
        diario11.Stop();
        diario12.Stop();
        diario13.Stop();
        diario14.Stop();
        diario15.Stop();
        pushup push = (pushup)FindFirstObjectByType(typeof(pushup));
        if(manager.datostrof.alien3escuchaunapagina == 0)
        {
            manager.datostrof.alien3escuchaunapagina = 1;
            manager.guardartro();
            push.push(86);
        }
        }
        else{no.Play();}
    }
    public void diario3_()
    {
        if(manager.datosserial.tdiario3 == 1)
        {
        diario1.Stop();
        diario2.Stop();
        diario3.Play();
        diario4.Stop();
        diario5.Stop();
        diario6.Stop();
        diario7.Stop();
        diario8.Stop();
        diario9.Stop();
        diario10.Stop();
        diario11.Stop();
        diario12.Stop();
        diario13.Stop();
        diario14.Stop();
        diario15.Stop();
        pushup push = (pushup)FindFirstObjectByType(typeof(pushup));
        if(manager.datostrof.alien3escuchaunapagina == 0)
        {
            manager.datostrof.alien3escuchaunapagina = 1;
            manager.guardartro();
            push.push(86);
        }
        }
        else{no.Play();}
    }
    public void diario4_()
    {
        if(manager.datosserial.tdiario4 == 1)
        {
        diario1.Stop();
        diario2.Stop();
        diario3.Stop();
        diario4.Play();
        diario5.Stop();
        diario6.Stop();
        diario7.Stop();
        diario8.Stop();
        diario9.Stop();
        diario10.Stop();
        diario11.Stop();
        diario12.Stop();
        diario13.Stop();
        diario14.Stop();
        diario15.Stop();
        pushup push = (pushup)FindFirstObjectByType(typeof(pushup));
        if(manager.datostrof.alien3escuchaunapagina == 0)
        {
            manager.datostrof.alien3escuchaunapagina = 1;
            manager.guardartro();
            push.push(86);
        }
        }
        else{no.Play();}
    }
    public void diario5_()
    {
        if(manager.datosserial.tdiario5 == 1)
        {
        diario1.Stop();
        diario2.Stop();
        diario3.Stop();
        diario4.Stop();
        diario5.Play();
        diario6.Stop();
        diario7.Stop();
        diario8.Stop();
        diario9.Stop();
        diario10.Stop();
        diario11.Stop();
        diario12.Stop();
        diario13.Stop();
        diario14.Stop();
        diario15.Stop();
        pushup push = (pushup)FindFirstObjectByType(typeof(pushup));
        if(manager.datostrof.alien3escuchaunapagina == 0)
        {
            manager.datostrof.alien3escuchaunapagina = 1;
            manager.guardartro();
            push.push(86);
        }
        }
        else{no.Play();}
    }
    public void diario6_()
    {
        if(manager.datosserial.tdiario6 == 1)
        {
        diario1.Stop();
        diario2.Stop();
        diario3.Stop();
        diario4.Stop();
        diario5.Stop();
        diario6.Play();
        diario7.Stop();
        diario8.Stop();
        diario9.Stop();
        diario10.Stop();
        diario11.Stop();
        diario12.Stop();
        diario13.Stop();
        diario14.Stop();
        diario15.Stop();
        pushup push = (pushup)FindFirstObjectByType(typeof(pushup));
        if(manager.datostrof.alien3escuchaunapagina == 0)
        {
            manager.datostrof.alien3escuchaunapagina = 1;
            manager.guardartro();
            push.push(86);
        }
        }
        else{no.Play();}
    }
    public void diario7_()
    {
        if(manager.datosserial.tdiario7 == 1)
        {
        diario1.Stop();
        diario2.Stop();
        diario3.Stop();
        diario4.Stop();
        diario5.Stop();
        diario6.Stop();
        diario7.Play();
        diario8.Stop();
        diario9.Stop();
        diario10.Stop();
        diario11.Stop();
        diario12.Stop();
        diario13.Stop();
        diario14.Stop();
        diario15.Stop();
        pushup push = (pushup)FindFirstObjectByType(typeof(pushup));
        if(manager.datostrof.alien3escuchaunapagina == 0)
        {
            manager.datostrof.alien3escuchaunapagina = 1;
            manager.guardartro();
            push.push(86);
        }
        }
        else{no.Play();}
    }
    public void diario8_()
    {
        if(manager.datosserial.tdiario8 == 1)
        {
        diario1.Stop();
        diario2.Stop();
        diario3.Stop();
        diario4.Stop();
        diario5.Stop();
        diario6.Stop();
        diario7.Stop();
        diario8.Play();
        diario9.Stop();
        diario10.Stop();
        diario11.Stop();
        diario12.Stop();
        diario13.Stop();
        diario14.Stop();
        diario15.Stop();
        pushup push = (pushup)FindFirstObjectByType(typeof(pushup));
        if(manager.datostrof.alien3escuchaunapagina == 0)
        {
            manager.datostrof.alien3escuchaunapagina = 1;
            manager.guardartro();
            push.push(86);
        }
        }
        else{no.Play();}
    }
    public void diario9_()
    {
        if(manager.datosserial.tdiario9 == 1)
        {
        diario1.Stop();
        diario2.Stop();
        diario3.Stop();
        diario4.Stop();
        diario5.Stop();
        diario6.Stop();
        diario7.Stop();
        diario8.Stop();
        diario9.Play();
        diario10.Stop();
        diario11.Stop();
        diario12.Stop();
        diario13.Stop();
        diario14.Stop();
        diario15.Stop();
        pushup push = (pushup)FindFirstObjectByType(typeof(pushup));
        if(manager.datostrof.alien3escuchaunapagina == 0)
        {
            manager.datostrof.alien3escuchaunapagina = 1;
            manager.guardartro();
            push.push(86);
        }
        }
        else{no.Play();}
    }
    public void diario10_()
    {
        if(manager.datosserial.tdiario10 == 1)
        {
        diario1.Stop();
        diario2.Stop();
        diario3.Stop();
        diario4.Stop();
        diario5.Stop();
        diario6.Stop();
        diario7.Stop();
        diario8.Stop();
        diario9.Stop();
        diario10.Play();
        diario11.Stop();
        diario12.Stop();
        diario13.Stop();
        diario14.Stop();
        diario15.Stop();
        pushup push = (pushup)FindFirstObjectByType(typeof(pushup));
        if(manager.datostrof.alien3escuchaunapagina == 0)
        {
            manager.datostrof.alien3escuchaunapagina = 1;
            manager.guardartro();
            push.push(86);
        }
        }
        else{no.Play();}
    }
    public void diario11_()
    {
        if(manager.datosserial.tdiario11 == 1)
        {
        diario1.Stop();
        diario2.Stop();
        diario3.Stop();
        diario4.Stop();
        diario5.Stop();
        diario6.Stop();
        diario7.Stop();
        diario8.Stop();
        diario9.Stop();
        diario10.Stop();
        diario11.Play();
        diario12.Stop();
        diario13.Stop();
        diario14.Stop();
        diario15.Stop();
        pushup push = (pushup)FindFirstObjectByType(typeof(pushup));
        if(manager.datostrof.alien3escuchaunapagina == 0)
        {
            manager.datostrof.alien3escuchaunapagina = 1;
            manager.guardartro();
            push.push(86);
        }
        }
        else{no.Play();}
    }
    public void diario12_()
    {
        if(manager.datosserial.tdiario12 == 1)
        {
        diario1.Stop();
        diario2.Stop();
        diario3.Stop();
        diario4.Stop();
        diario5.Stop();
        diario6.Stop();
        diario7.Stop();
        diario8.Stop();
        diario9.Stop();
        diario10.Stop();
        diario11.Stop();
        diario12.Play();
        diario13.Stop();
        diario14.Stop();
        diario15.Stop();
        pushup push = (pushup)FindFirstObjectByType(typeof(pushup));
        if(manager.datostrof.alien3escuchaunapagina == 0)
        {
            manager.datostrof.alien3escuchaunapagina = 1;
            manager.guardartro();
            push.push(86);
        }
        }
        else{no.Play();}
    }
    public void diario13_()
    {
        if(manager.datosserial.tdiario13 == 1)
        {
        diario1.Stop();
        diario2.Stop();
        diario3.Stop();
        diario4.Stop();
        diario5.Stop();
        diario6.Stop();
        diario7.Stop();
        diario8.Stop();
        diario9.Stop();
        diario10.Stop();
        diario11.Stop();
        diario12.Stop();
        diario13.Play();
        diario14.Stop();
        diario15.Stop();
        pushup push = (pushup)FindFirstObjectByType(typeof(pushup));
        if(manager.datostrof.alien3escuchaunapagina == 0)
        {
            manager.datostrof.alien3escuchaunapagina = 1;
            manager.guardartro();
            push.push(86);
        }
        }
        else{no.Play();}
    }
    public void diario14_()
    {
        if(manager.datosserial.tdiario14 == 1)
        {
        diario1.Stop();
        diario2.Stop();
        diario3.Stop();
        diario4.Stop();
        diario5.Stop();
        diario6.Stop();
        diario7.Stop();
        diario8.Stop();
        diario9.Stop();
        diario10.Stop();
        diario11.Stop();
        diario12.Stop();
        diario13.Stop();
        diario14.Play();
        diario15.Stop();
        pushup push = (pushup)FindFirstObjectByType(typeof(pushup));
        if(manager.datostrof.alien3escuchaunapagina == 0)
        {
            manager.datostrof.alien3escuchaunapagina = 1;
            manager.guardartro();
            push.push(86);
        }
        }
        else{no.Play();}
    }
    public void diario15_()
    {
        if(manager.datosserial.tdiario15 == 1)
        {
        diario1.Stop();
        diario2.Stop();
        diario3.Stop();
        diario4.Stop();
        diario5.Stop();
        diario6.Stop();
        diario7.Stop();
        diario8.Stop();
        diario9.Stop();
        diario10.Stop();
        diario11.Stop();
        diario12.Stop();
        diario13.Stop();
        diario14.Stop();
        diario15.Play();
        pushup push = (pushup)FindFirstObjectByType(typeof(pushup));
        if(manager.datostrof.alien3escuchaunapagina == 0)
        {
            manager.datostrof.alien3escuchaunapagina = 1;
            manager.guardartro();
            push.push(86);
        }
        }
        else{no.Play();}
    }
    public void guia1_()
    {
        if(guiaboton == false && temp >= 1 )
		{
			guia.SetActive(true);
			guiaboton = true;
            guia2.SetActive(false);
			guiaboton2 = false;
		}
		else if(guiaboton == true && temp >= 1)
		{
			guia.SetActive(false);
			guiaboton = false;
		}
    }
    public void guia2_()
    {
        if(guiaboton2 == false && temp >= 1)
		{
			guia2.SetActive(true);
			guiaboton2 = true;
            guia.SetActive(false);
			guiaboton = false;
		}
		else if(guiaboton2 == true && temp >= 1)
		{
			guia2.SetActive(false);
			guiaboton2 = false;
		}
    }
    public void trailer1_()
    {
        SceneManager.LoadScene("traileralien1_al3");
    }
    public void trailer2_()
    {
        SceneManager.LoadScene("traileralien2_al3");
    }
    public void trailer3_()
    {
        SceneManager.LoadScene("traileralien3_al3");
    }
    public void trailer4_()
    {
        SceneManager.LoadScene("trailerfriends_al3");
    }
    public void aplicar2()
    {
		managerBASE manager = (managerBASE)FindFirstObjectByType(typeof(managerBASE));
		controlmusicabase controlslider = (controlmusicabase)FindFirstObjectByType(typeof(controlmusicabase));


		audiomixer.GetFloat ("MusicVolume",out manager.datosconfig.musica);
		manager.datosconfig.musicaslider = controlslider.slidermusica.value;

		audiomixer.GetFloat ("EnvironmentVolume",out manager.datosconfig.voz);
		manager.datosconfig.vozslider = controlslider.slidervoz.value;

		audiomixer.GetFloat ("SFXVolume",out manager.datosconfig.sfx);
		manager.datosconfig.sfxslider = controlslider.slidersfx.value;

		audiomixer.GetFloat ("UIVolume",out manager.datosconfig.ui);
		manager.datosconfig.uislider = controlslider.sliderui.value;

		manager.datosconfig.aplicarres = true;
		manager.guardar();

        menuc.SetActive(true);
        opciones1.SetActive(false);
		
    }
    public void opciones()
    {
        menuc.SetActive(false);
        opciones1.SetActive(true);
    }
    
    
    
}
