using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class seleccionrap_al3: MonoBehaviour
{
	public manager_al3 manager;

    public Text armasel1;
    public Text armasel2;
    public Text armasel3;
    public Text armasel4;
    public Text armadsel1;
    public Text armadsel2;

    public Text ttitulo;
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
    public jugador1_al3 jugador;



    public Image ar1;
    public Image ar2;
    public Image ar3;
    public Image ar4;
    public Image ar5;
    public Image ar6;
    // Start is called before the first frame update
    void Start()
    {
        manager = (manager_al3)FindFirstObjectByType(typeof(manager_al3));
        if(manager.datosconfig.idioma == "es")
        {
            ttitulo.text = "seleccion rapida";
        }
        if(manager.datosconfig.idioma == "en")
        {
            ttitulo.text = "quick selection";
        }
        if(manager.datosconfig.idioma == "cat")
        {
            ttitulo.text = "seleccio rapida";
        }
    }

    // Update is called once per frame
    void Update()
    {
        manager = (manager_al3)FindFirstObjectByType(typeof(manager_al3));

        if(manager.datosserial.armass1 == manager.datosserial.arma)
        {
            ar1.color = new Color32(43,0,139,255);
        }
        else
        {
            ar1.color = new Color32(43,0,139,166);
        }
        if(manager.datosserial.armass2 == manager.datosserial.arma)
        {
            ar2.color = new Color32(43,0,139,255);
        }
        else
        {
            ar2.color = new Color32(43,0,139,166);
        }
        if(manager.datosserial.armass3 == manager.datosserial.arma)
        {
            ar3.color = new Color32(43,0,139,255);
        }
        else
        {
            ar3.color = new Color32(43,0,139,166);
        }
        if(manager.datosserial.armass4 == manager.datosserial.arma)
        {
            ar4.color = new Color32(43,0,139,255);
        }
        else
        {
            ar4.color = new Color32(43,0,139,166);
        }

        if(manager.datosserial.armadurass1 == manager.datosserial.armadura)
        {
            ar5.color = new Color32(43,0,139,255);
        }
        else
        {
            ar5.color = new Color32(43,0,139,166);
        }
        if(manager.datosserial.armadurass2 == manager.datosserial.armadura)
        {
            ar6.color = new Color32(43,0,139,255);
        }
        else
        {
            ar6.color = new Color32(43,0,139,166);
        }



        if(manager.datosconfig.idioma == "es")
        {
        
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
        }
        if(manager.datosconfig.idioma == "en")
        {
        
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
        }
        if(manager.datosconfig.idioma == "cat")
        {
        
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
        }



        
    }
}
