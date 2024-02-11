using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class tienda_al3: MonoBehaviour
{

    public int ntienda = 1;
    public Text tmun;
    public Text tcom;
    public Text tpocv;
    public Text tpocf;
    public Text tpocr;
    public Text ttarma1;
    public Text ttarma2;
    public Text tarmas;
    public Text ttienda;


    public Text valor;
    public Text cantidad;
    public Text monedast;
    public AudioSource no;
    public AudioSource tutp3;
    public AudioSource tutp3es;
    public AudioSource tutp3en;
    public AudioSource tutp3cat;
    public GameObject tiendag;
    public bool pocionvida = false;
    public bool pocionres = false;
    public bool pocionfuerza = false;
    public bool arma1 = false;
    public bool arma2 = false;
    public bool arma3 = false;
    public bool arma4 = false;
    public bool arma5 = false;
    public bool arma6 = false;
    public bool arma7 = false;
    public bool arma8 = false;
    public bool arma9 = false;
    public bool arma10 = false;
    public bool arma11 = false;
    public bool arma12 = false;
    public bool arma13 = false;
    public bool arma14 = false;
    public bool arma15 = false;

    public bool municion;




    // Start is called before the first frame update
    void Start()
    {
        manager_al3 manager = UnityEngine.Object.FindObjectOfType<manager_al3>();
        if (manager.datosconfig.idioma == "es")
		{
			tutp3 = tutp3es;
		}
        if (manager.datosconfig.idioma == "en")
		{
			tutp3 = tutp3en;
		}
        if (manager.datosconfig.idioma == "cat")
		{
			tutp3 = tutp3cat;
		}
        if(manager.datosconfig.idioma == "es")
        {
        valor.text = "valor : ???";
        }
        if(manager.datosconfig.idioma == "en")
        {
        valor.text = "price : ???";
        }
        if(manager.datosconfig.idioma == "cat")
        {
        valor.text = "valor : ???";
        }
    }

    // Update is called once per frame
    void Update()
    {
        manager_al3 manager = UnityEngine.Object.FindObjectOfType<manager_al3>();


        if(manager.datosconfig.idioma == "es")
        {
            monedast.text = "monedas : "+ manager.datosserial.monedas;
            tmun.text = "municion";
            tcom.text = "comprar";
            tpocv.text = "pocion de vida";
            tpocr.text = "pocion de resistencia";
            tpocf.text = "pocion de fuerza";
            ttienda.text = "tienda";
            if(ntienda == 1)
            {
                ttarma1.text = "arma de papa";
                tarmas.text = "arma de papa";
            }
            if(ntienda == 2)
            {
                ttarma1.text = "arma de mama";
                tarmas.text = "arma de mama";
            }
            if(ntienda == 3)
            {
                ttarma1.text = "dispara palos";
                tarmas.text = "dispara palos";
            }
            if(ntienda == 4)
            {
                ttarma1.text = "arma del legado";
                tarmas.text = "arma del legado";
            }
            if(ntienda == 5)
            {
                ttarma1.text = "senuelo";
                tarmas.text = "senuelo";
            }
            if(ntienda == 6)
            {
                ttarma1.text = "disparo atomico";
                tarmas.text = "disparo atomico";
            }
            if(ntienda == 7)
            {
                ttarma1.text = "metralla cuerpos";
                tarmas.text = "metralla cuerpos";
            }
            if(ntienda == 8)
            {
                ttarma1.text = "bomba bam";
                tarmas.text = "bomba bam";
            }
            if(ntienda == 9)
            {
                ttarma1.text = "zig zag bang";
                tarmas.text = "zig zag bang";
            }
            if(ntienda == 10)
            {
                ttarma1.text = "mataobjetivos";
                tarmas.text = "mataobjetivos";
            }
            if(ntienda == 11)
            {
                ttarma1.text = "dispara plataformas";
                tarmas.text = "dispara plataformas";
            }
            if(ntienda == 12)
            {
                ttarma1.text = "gancho";
                tarmas.text = "gancho";
            }
            if(ntienda == 13)
            {
                ttarma1.text = "dispara saltadores";
                ttarma2.text = "dispara aceleradores";
                tarmas.text = "armas disparadores";
            }
            if(ntienda == 14)
            {
                ttarma1.text = "destructora_1.0";
                tarmas.text = "destructora_1.0";
            }if(ntienda == 15)
            {
                
            }

        }
        if(manager.datosconfig.idioma == "en")
        {
            monedast.text = "coins : "+ manager.datosserial.monedas;
            tmun.text = "ammunition";
            tcom.text = "buy";
            tpocv.text = "life potion";
            tpocr.text = "resistance potion";
            tpocf.text = "strength potion";
            ttienda.text = "shop";
            if(ntienda == 1)
            {
                ttarma1.text = "dad's gun";
                tarmas.text = "dad's gun";
            }
            if(ntienda == 2)
            {
                ttarma1.text = "mom gun";
                tarmas.text = "mom gun";
            }
            if(ntienda == 3)
            {
                ttarma1.text = "shoot sticks";
                tarmas.text = "shoot sticks";
            }
            if(ntienda == 4)
            {
                ttarma1.text = "legacy weapon";
                tarmas.text = "legacy weapon";
            }
            if(ntienda == 5)
            {
                ttarma1.text = "lure gun";
                tarmas.text = "lure gun";
            }
            if(ntienda == 6)
            {
                ttarma1.text = "atomic shot";
                tarmas.text = "atomic shot";
            }
            if(ntienda == 7)
            {
                ttarma1.text = "machine gun";
                tarmas.text = "machine gun";
            }
            if(ntienda == 8)
            {
                ttarma1.text = "bomb bam";
                tarmas.text = "bomb bam";
            }
            if(ntienda == 9)
            {
                ttarma1.text = "zig zag bang";
                tarmas.text = "zig zag bang";
            }
            if(ntienda == 10)
            {
                ttarma1.text = "kill targets";
                tarmas.text = "kill targets";
            }
            if(ntienda == 11)
            {
                ttarma1.text = "shoot floors";
                tarmas.text = "shoot floors";
            }
            if(ntienda == 12)
            {
                ttarma1.text = "hook";
                tarmas.text = "hook";
            }
            if(ntienda == 13)
            {
                ttarma1.text = "shoot jumpers";
                ttarma2.text = "shoot accelerators";
                tarmas.text = "weapons triggers";
            }
            if(ntienda == 14)
            {
                ttarma1.text = "destroyer_1.0";
                tarmas.text = "destroyer_1.0";
            }if(ntienda == 15)
            {
                
            }

        }
        if(manager.datosconfig.idioma == "cat")
        {
            monedast.text = "monedas : "+ manager.datosserial.monedas;
            tmun.text = "municio";
            tcom.text = "comprar";
            tpocv.text = "pocio de vida";
            tpocr.text = "pocio de resistencia";
            tpocf.text = "pocio de forca";
            ttienda.text = "tenda";
            if(ntienda == 1)
            {
                ttarma1.text = "arma d en para";
                tarmas.text = "arma d en pare";
            }
            if(ntienda == 2)
            {
                ttarma1.text = "arma d la mama";
                tarmas.text = "arma d la mama";
            }
            if(ntienda == 3)
            {
                ttarma1.text = "dispara pals";
                tarmas.text = "dispara pals";
            }
            if(ntienda == 4)
            {
                ttarma1.text = "arma del llegat";
                tarmas.text = "arma del llegat";
            }
            if(ntienda == 5)
            {
                ttarma1.text = "arma distraccio";
                tarmas.text = "arma distraccio";
            }
            if(ntienda == 6)
            {
                ttarma1.text = "dispar atomic";
                tarmas.text = "dispar atomic";
            }
            if(ntienda == 7)
            {
                ttarma1.text = "metralla cosos";
                tarmas.text = "metralla cosos";
            }
            if(ntienda == 8)
            {
                ttarma1.text = "bomba bam";
                tarmas.text = "bomba bam";
            }
            if(ntienda == 9)
            {
                ttarma1.text = "zig zag bang";
                tarmas.text = "zig zag bang";
            }
            if(ntienda == 10)
            {
                ttarma1.text = "mataobjetius";
                tarmas.text = "mataobjetius";
            }
            if(ntienda == 11)
            {
                ttarma1.text = "dispara plataformas";
                tarmas.text = "dispara plataformas";
            }
            if(ntienda == 12)
            {
                ttarma1.text = "ganxo";
                tarmas.text = "ganxo";
            }
            if(ntienda == 13)
            {
                ttarma1.text = "dispara saltadors";
                ttarma2.text = "dispara atceleradors";
                tarmas.text = "armas disparadores";
            }
            if(ntienda == 14)
            {
                ttarma1.text = "destructora_1.0";
                tarmas.text = "destructora_1.0";
            }if(ntienda == 15)
            {
                
            }

        }
    }
    public void pocionvida_()
    {
        manager_al3 manager = UnityEngine.Object.FindObjectOfType<manager_al3>();
        pocionvida = true;
        pocionres = false;
        pocionfuerza = false;
        arma1 = false;
        arma2 = false;
        arma3 = false;
        arma4 = false;
        arma5 = false;
        arma6 = false;
        arma7 = false;
        arma8 = false;
        arma9 = false;
        arma10 = false;
        arma11 = false;
        arma12 = false;
        arma13 = false;
        arma14 = false;
        arma15 = false;
        municion = false;
        if(manager.datosconfig.idioma == "es")
        {
        valor.text = "valor : 10";
        cantidad.text = "cantidad : "+manager.datosserial.pociones;
        }
        if(manager.datosconfig.idioma == "en")
        {
        valor.text = "price : 10";
        cantidad.text = "amount : "+manager.datosserial.pociones;
        }
        if(manager.datosconfig.idioma == "cat")
        {
        valor.text = "valor : 10";
        cantidad.text = "quantiat : "+manager.datosserial.pociones;
        }
    }
    public void pocionresistencia_()
    {
        manager_al3 manager = UnityEngine.Object.FindObjectOfType<manager_al3>();
        pocionvida = false;
        pocionres = true;
        pocionfuerza = false;
        arma1 = false;
        arma2 = false;
        arma3 = false;
        arma4 = false;
        arma5 = false;
        arma6 = false;
        arma7 = false;
        arma8 = false;
        arma9 = false;
        arma10 = false;
        arma11 = false;
        arma12 = false;
        arma13 = false;
        arma14 = false;
        arma15 = false;
        municion = false;
        if(manager.datosconfig.idioma == "es")
        {
        valor.text = "valor : 20";
        cantidad.text = "cantidad : "+manager.datosserial.pocionres;
        }
        if(manager.datosconfig.idioma == "en")
        {
        valor.text = "price : 20";
        cantidad.text = "amount : "+manager.datosserial.pocionres;
        }
        if(manager.datosconfig.idioma == "cat")
        {
        valor.text = "valor : 20";
        cantidad.text = "quantitat : "+manager.datosserial.pocionres;
        }
    }
    public void pocionfuerza_()
    {
        manager_al3 manager = UnityEngine.Object.FindObjectOfType<manager_al3>();
        pocionvida = false;
        pocionres = false;
        pocionfuerza = true;
        arma1 = false;
        arma2 = false;
        arma3 = false;
        arma4 = false;
        arma5 = false;
        arma6 = false;
        arma7 = false;
        arma8 = false;
        arma9 = false;
        arma10 = false;
        arma11 = false;
        arma12 = false;
        arma13 = false;
        arma14 = false;
        arma15 = false;
        municion = false;
        if(manager.datosconfig.idioma == "es")
        {
        valor.text = "valor : 20";
        cantidad.text = "cantidad : "+manager.datosserial.pocionfue;
        }
        if(manager.datosconfig.idioma == "en")
        {
        valor.text = "price : 20";
        cantidad.text = "amount : "+manager.datosserial.pocionfue;
        }
        if(manager.datosconfig.idioma == "cat")
        {
        valor.text = "valor : 20";
        cantidad.text = "quantitat : "+manager.datosserial.pocionfue;
        }
    }
    public void municion_()
    {
        manager_al3 manager = UnityEngine.Object.FindObjectOfType<manager_al3>();
        pocionvida = false;
        pocionres = false;
        pocionfuerza = false;
        arma1 = false;
        arma2 = false;
        arma3 = false;
        arma4 = false;
        arma5 = false;
        arma6 = false;
        arma7 = false;
        arma8 = false;
        arma9 = false;
        arma10 = false;
        arma11 = false;
        arma12 = false;
        arma13 = false;
        arma14 = false;
        arma15 = false;
        municion = true;
        if(manager.datosconfig.idioma == "es")
        {
        valor.text = "valor : 5";
        cantidad.text = "recargara toda la municion";
        }
        if(manager.datosconfig.idioma == "en")
        {
        valor.text = "price : 5";
        cantidad.text = "will reload all the ammunition";
        }
        if(manager.datosconfig.idioma == "cat")
        {
        valor.text = "valor : 5";
        cantidad.text = "recargara tota la municio";
        }
    }
    public void arma1_()
    {
        manager_al3 manager = UnityEngine.Object.FindObjectOfType<manager_al3>();
        pocionvida = false;
        pocionres = false;
        pocionfuerza = false;
        arma1 = true;
        arma2 = false;
        arma3 = false;
        arma4 = false;
        arma5 = false;
        arma6 = false;
        arma7 = false;
        arma8 = false;
        arma9 = false;
        arma10 = false;
        arma11 = false;
        arma12 = false;
        arma13 = false;
        arma14 = false;
        arma15 = false;
        municion = false;
        if(manager.datosconfig.idioma == "es")
        {
        valor.text = "valor : 0";
        cantidad.text = "cantidad : "+manager.datosserial.tarma[0];
        }
        if(manager.datosconfig.idioma == "en")
        {
        valor.text = "price : 0";
        cantidad.text = "amount : "+manager.datosserial.tarma[0];
        }
        if(manager.datosconfig.idioma == "cat")
        {
        valor.text = "valor : 0";
        cantidad.text = "quantitat : "+manager.datosserial.tarma[0];
        }
    }
    public void arma2_()
    {
        manager_al3 manager = UnityEngine.Object.FindObjectOfType<manager_al3>();
        pocionvida = false;
        pocionres = false;
        pocionfuerza = false;
        arma1 = false;
        arma2 = true;
        arma3 = false;
        arma4 = false;
        arma5 = false;
        arma6 = false;
        arma7 = false;
        arma8 = false;
        arma9 = false;
        arma10 = false;
        arma11 = false;
        arma12 = false;
        arma13 = false;
        arma14 = false;
        arma15 = false;
        municion = false;
        if(manager.datosconfig.idioma == "es")
        {
        valor.text = "valor : 30";
        cantidad.text = "cantidad : "+manager.datosserial.tarma[1];
        }
        if(manager.datosconfig.idioma == "en")
        {
        valor.text = "price : 30";
        cantidad.text = "amount : "+manager.datosserial.tarma[1];
        }
        if(manager.datosconfig.idioma == "cat")
        {
        valor.text = "valor : 30";
        cantidad.text = "quantitat : "+manager.datosserial.tarma[1];
        }
    }
    public void arma3_()
    {
        manager_al3 manager = UnityEngine.Object.FindObjectOfType<manager_al3>();
        pocionvida = false;
        pocionres = false;
        pocionfuerza = false;
        arma1 = false;
        arma2 = false;
        arma3 = true;
        arma4 = false;
        arma5 = false;
        arma6 = false;
        arma7 = false;
        arma8 = false;
        arma9 = false;
        arma10 = false;
        arma11 = false;
        arma12 = false;
        arma13 = false;
        arma14 = false;
        arma15 = false;
        municion = false;
        if(manager.datosconfig.idioma == "es")
        {
        valor.text = "valor : 50";
        cantidad.text = "cantidad : "+manager.datosserial.tarma[2];
        }
        if(manager.datosconfig.idioma == "en")
        {
        valor.text = "price : 50";
        cantidad.text = "amount : "+manager.datosserial.tarma[2];
        }
        if(manager.datosconfig.idioma == "cat")
        {
        valor.text = "valor : 50";
        cantidad.text = "quantitat : "+manager.datosserial.tarma[2];
        }
    }
    public void arma4_()
    {
        manager_al3 manager = UnityEngine.Object.FindObjectOfType<manager_al3>();
        pocionvida = false;
        pocionres = false;
        pocionfuerza = false;
        arma1 = false;
        arma2 = false;
        arma3 = false;
        arma4 = true;
        arma5 = false;
        arma6 = false;
        arma7 = false;
        arma8 = false;
        arma9 = false;
        arma10 = false;
        arma11 = false;
        arma12 = false;
        arma13 = false;
        arma14 = false;
        arma15 = false;
        municion = false;
        if(manager.datosconfig.idioma == "es")
        {
        valor.text = "valor : 70";
        cantidad.text = "cantidad : "+manager.datosserial.tarma[3];
        }
        if(manager.datosconfig.idioma == "en")
        {
        valor.text = "price : 70";
        cantidad.text = "amount : "+manager.datosserial.tarma[3];
        }
        if(manager.datosconfig.idioma == "cat")
        {
        valor.text = "valor : 70";
        cantidad.text = "quantitat : "+manager.datosserial.tarma[3];
        }
    }
    public void arma5_()
    {
        manager_al3 manager = UnityEngine.Object.FindObjectOfType<manager_al3>();
        pocionvida = false;
        pocionres = false;
        pocionfuerza = false;
        arma1 = false;
        arma2 = false;
        arma3 = false;
        arma4 = false;
        arma5 = true;
        arma6 = false;
        arma7 = false;
        arma8 = false;
        arma9 = false;
        arma10 = false;
        arma11 = false;
        arma12 = false;
        arma13 = false;
        arma14 = false;
        arma15 = false;
        municion = false;
        if(manager.datosconfig.idioma == "es")
        {
        valor.text = "valor : 130";
        cantidad.text = "cantidad : "+manager.datosserial.tarma[4];
        }
        if(manager.datosconfig.idioma == "en")
        {
        valor.text = "price : 130";
        cantidad.text = "amount : "+manager.datosserial.tarma[4];
        }
        if(manager.datosconfig.idioma == "cat")
        {
        valor.text = "valor : 130";
        cantidad.text = "quantitat : "+manager.datosserial.tarma[4];
        }
    }
    public void arma6_()
    {
        manager_al3 manager = UnityEngine.Object.FindObjectOfType<manager_al3>();
        pocionvida = false;
        pocionres = false;
        pocionfuerza = false;
        arma1 = false;
        arma2 = false;
        arma3 = false;
        arma4 = false;
        arma5 = false;
        arma6 = true;
        arma7 = false;
        arma8 = false;
        arma9 = false;
        arma10 = false;
        arma11 = false;
        arma12 = false;
        arma13 = false;
        arma14 = false;
        arma15 = false;
        municion = false;
        if(manager.datosconfig.idioma == "es")
        {
        valor.text = "valor : 250";
        cantidad.text = "cantidad : "+manager.datosserial.tarma[5];
        }
        if(manager.datosconfig.idioma == "en")
        {
        valor.text = "price : 250";
        cantidad.text = "amount : "+manager.datosserial.tarma[5];
        }
        if(manager.datosconfig.idioma == "cat")
        {
        valor.text = "valor : 250";
        cantidad.text = "quantitat : "+manager.datosserial.tarma[5];
        }
    }
    public void arma7_()
    {
        manager_al3 manager = UnityEngine.Object.FindObjectOfType<manager_al3>();
        pocionvida = false;
        pocionres = false;
        pocionfuerza = false;
        arma1 = false;
        arma2 = false;
        arma3 = false;
        arma4 = false;
        arma5 = false;
        arma6 = false;
        arma7 = true;
        arma8 = false;
        arma9 = false;
        arma10 = false;
        arma11 = false;
        arma12 = false;
        arma13 = false;
        arma14 = false;
        arma15 = false;
        municion = false;
        if(manager.datosconfig.idioma == "es")
        {
        valor.text = "valor : 500";
        cantidad.text = "cantidad : "+manager.datosserial.tarma[6];
        }
        if(manager.datosconfig.idioma == "en")
        {
        valor.text = "price : 500";
        cantidad.text = "amount : "+manager.datosserial.tarma[6];
        }
        if(manager.datosconfig.idioma == "cat")
        {
        valor.text = "valor : 500";
        cantidad.text = "quantitat : "+manager.datosserial.tarma[6];
        }
    }
    public void arma8_()
    {
        manager_al3 manager = UnityEngine.Object.FindObjectOfType<manager_al3>();
        pocionvida = false;
        pocionres = false;
        pocionfuerza = false;
        arma1 = false;
        arma2 = false;
        arma3 = false;
        arma4 = false;
        arma5 = false;
        arma6 = false;
        arma7 = false;
        arma8 = true;
        arma9 = false;
        arma10 = false;
        arma11 = false;
        arma12 = false;
        arma13 = false;
        arma14 = false;
        arma15 = false;
        municion = false;
        if(manager.datosconfig.idioma == "es")
        {
        valor.text = "valor : 400";
        cantidad.text = "cantidad : "+manager.datosserial.tarma[7];
        }
        if(manager.datosconfig.idioma == "en")
        {
        valor.text = "price : 400";
        cantidad.text = "amount : "+manager.datosserial.tarma[7];
        }
        if(manager.datosconfig.idioma == "cat")
        {
        valor.text = "valor : 400";
        cantidad.text = "quantitat : "+manager.datosserial.tarma[7];
        }
    }
    public void arma9_()
    {
        manager_al3 manager = UnityEngine.Object.FindObjectOfType<manager_al3>();
        pocionvida = false;
        pocionres = false;
        pocionfuerza = false;
        arma1 = false;
        arma2 = false;
        arma3 = false;
        arma4 = false;
        arma5 = false;
        arma6 = false;
        arma7 = false;
        arma8 = false;
        arma9 = true;
        arma10 = false;
        arma11 = false;
        arma12 = false;
        arma13 = false;
        arma14 = false;
        arma15 = false;
        municion = false;
        if(manager.datosconfig.idioma == "es")
        {
        valor.text = "valor : 200";
        cantidad.text = "cantidad : "+manager.datosserial.tarma[8];
        }
        if(manager.datosconfig.idioma == "en")
        {
        valor.text = "price : 200";
        cantidad.text = "amount : "+manager.datosserial.tarma[8];
        }
        if(manager.datosconfig.idioma == "cat")
        {
        valor.text = "valor : 200";
        cantidad.text = "quantitat : "+manager.datosserial.tarma[8];
        }
    }
    public void arma10_()
    {
        manager_al3 manager = UnityEngine.Object.FindObjectOfType<manager_al3>();
        pocionvida = false;
        pocionres = false;
        pocionfuerza = false;
        arma1 = false;
        arma2 = false;
        arma3 = false;
        arma4 = false;
        arma5 = false;
        arma6 = false;
        arma7 = false;
        arma8 = false;
        arma9 = false;
        arma10 = true;
        arma11 = false;
        arma12 = false;
        arma13 = false;
        arma14 = false;
        arma15 = false;
        municion = false;
        if(manager.datosconfig.idioma == "es")
        {
        valor.text = "valor : 650";
        cantidad.text = "cantidad : "+manager.datosserial.tarma[9];
        }
        if(manager.datosconfig.idioma == "en")
        {
        valor.text = "price : 650";
        cantidad.text = "amount : "+manager.datosserial.tarma[9];
        }
        if(manager.datosconfig.idioma == "cat")
        {
        valor.text = "valor : 650";
        cantidad.text = "quantitat : "+manager.datosserial.tarma[9];
        }
    }
    public void arma11_()
    {
        manager_al3 manager = UnityEngine.Object.FindObjectOfType<manager_al3>();
        pocionvida = false;
        pocionres = false;
        pocionfuerza = false;
        arma1 = false;
        arma2 = false;
        arma3 = false;
        arma4 = false;
        arma5 = false;
        arma6 = false;
        arma7 = false;
        arma8 = false;
        arma9 = false;
        arma10 = false;
        arma11 = true;
        arma12 = false;
        arma13 = false;
        arma14 = false;
        arma15 = false;
        municion = false;
        if(manager.datosconfig.idioma == "es")
        {
        valor.text = "valor : 200";
        cantidad.text = "cantidad : "+manager.datosserial.tarma[10];
        }
        if(manager.datosconfig.idioma == "en")
        {
        valor.text = "price : 200";
        cantidad.text = "amount : "+manager.datosserial.tarma[10];
        }
        if(manager.datosconfig.idioma == "cat")
        {
        valor.text = "valor : 200";
        cantidad.text = "quantitat : "+manager.datosserial.tarma[10];
        }
    }
    public void arma12_()
    {
        manager_al3 manager = UnityEngine.Object.FindObjectOfType<manager_al3>();
        pocionvida = false;
        pocionres = false;
        pocionfuerza = false;
        arma1 = false;
        arma2 = false;
        arma3 = false;
        arma4 = false;
        arma5 = false;
        arma6 = false;
        arma7 = false;
        arma8 = false;
        arma9 = false;
        arma10 = false;
        arma11 = false;
        arma12 = true;
        arma13 = false;
        arma14 = false;
        arma15 = false;
        municion = false;
        if(manager.datosconfig.idioma == "es")
        {
        valor.text = "valor : 150";
        cantidad.text = "cantidad : "+manager.datosserial.tarma[11];
        }
        if(manager.datosconfig.idioma == "en")
        {
        valor.text = "price : 150";
        cantidad.text = "amount : "+manager.datosserial.tarma[11];
        }
        if(manager.datosconfig.idioma == "cat")
        {
        valor.text = "valor : 150";
        cantidad.text = "quantitat : "+manager.datosserial.tarma[11];
        }
    }
    public void arma13_()
    {
        manager_al3 manager = UnityEngine.Object.FindObjectOfType<manager_al3>();
        pocionvida = false;
        pocionres = false;
        pocionfuerza = false;
        arma1 = false;
        arma2 = false;
        arma3 = false;
        arma4 = false;
        arma5 = false;
        arma6 = false;
        arma7 = false;
        arma8 = false;
        arma9 = false;
        arma10 = false;
        arma11 = false;
        arma12 = false;
        arma13 = true;
        arma14 = false;
        arma15 = false;
        municion = false;
        if(manager.datosconfig.idioma == "es")
        {
        valor.text = "valor : 1000";
        cantidad.text = "cantidad : "+manager.datosserial.tarma[12];
        }
        if(manager.datosconfig.idioma == "en")
        {
        valor.text = "price : 1000";
        cantidad.text = "amount : "+manager.datosserial.tarma[12];
        }
        if(manager.datosconfig.idioma == "cat")
        {
        valor.text = "valor : 1000";
        cantidad.text = "quantitat : "+manager.datosserial.tarma[12];
        }
    }
    public void arma14_()
    {
        manager_al3 manager = UnityEngine.Object.FindObjectOfType<manager_al3>();
        pocionvida = false;
        pocionres = false;
        pocionfuerza = false;
        arma1 = false;
        arma2 = false;
        arma3 = false;
        arma4 = false;
        arma5 = false;
        arma6 = false;
        arma7 = false;
        arma8 = false;
        arma9 = false;
        arma10 = false;
        arma11 = false;
        arma12 = false;
        arma13 = false;
        arma14 = true;
        arma15 = false;
        municion = false;
        if(manager.datosconfig.idioma == "es")
        {
        valor.text = "valor : 1000";
        cantidad.text = "cantidad : "+manager.datosserial.tarma[13];
        }
        if(manager.datosconfig.idioma == "en")
        {
        valor.text = "price : 1000";
        cantidad.text = "amount : "+manager.datosserial.tarma[13];
        }
        if(manager.datosconfig.idioma == "cat")
        {
        valor.text = "valor : 1000";
        cantidad.text = "quantitat : "+manager.datosserial.tarma[13];
        }
    }
    public void arma15_()
    {
        manager_al3 manager = UnityEngine.Object.FindObjectOfType<manager_al3>();
        pocionvida = false;
        pocionres = false;
        pocionfuerza = false;
        arma1 = false;
        arma2 = false;
        arma3 = false;
        arma4 = false;
        arma5 = false;
        arma6 = false;
        arma7 = false;
        arma8 = false;
        arma9 = false;
        arma10 = false;
        arma11 = false;
        arma12 = false;
        arma13 = false;
        arma14 = false;
        arma15 = true;
        municion = false;
        if(manager.datosconfig.idioma == "es")
        {
        valor.text = "valor : 2000";
        cantidad.text = "cantidad : "+manager.datosserial.tarma[14];
        }
        if(manager.datosconfig.idioma == "en")
        {
        valor.text = "price : 2000";
        cantidad.text = "amount : "+manager.datosserial.tarma[14];
        }
        if(manager.datosconfig.idioma == "cat")
        {
        valor.text = "valor : 2000";
        cantidad.text = "quantitat : "+manager.datosserial.tarma[14];
        }
    }
    public void comprar_()
    {
        manager_al3 manager = UnityEngine.Object.FindObjectOfType<manager_al3>();
		jugador1_al3 jugador = UnityEngine.Object.FindObjectOfType<jugador1_al3>();
        if(pocionvida == true)
        {
            if(manager.datosserial.monedas >= 10 && manager.datosserial.pociones < 100)
            {
			manager.datosserial.monedas -= 10;
			manager.datosserial.monedas -= 10;
            manager.datosserial.pociones++;
            manager.guardar();
            pocionvida = false;
            pocionres = false;
            pocionfuerza = false;
            arma1 = false;
            arma2 = false;
            arma3 = false;
            arma4 = false;
            arma5 = false;
            arma6 = false;
            arma7 = false;
            arma8 = false;
            arma9 = false;
            arma10 = false;
            arma11 = false;
            arma12 = false;
            arma13 = false;
            arma14 = false;
            arma15 = false;
            municion = false;
            }
            else
            {
                no.Play();
            }
        }
        else if(pocionres == true)
        {
            if(manager.datosserial.monedas >= 20 && manager.datosserial.pocionres < 100)
            {
			manager.datosserial.monedas -= 20;
			manager.datosserial.monedas -= 20;
            manager.datosserial.pocionres++;
            manager.guardar();
            pocionvida = false;
            pocionres = false;
            pocionfuerza = false;
            arma1 = false;
            arma2 = false;
            arma3 = false;
            arma4 = false;
            arma5 = false;
            arma6 = false;
            arma7 = false;
            arma8 = false;
            arma9 = false;
            arma10 = false;
            arma11 = false;
            arma12 = false;
            arma13 = false;
            arma14 = false;
            arma15 = false;
            municion = false;
            }
            else
            {
                no.Play();
            }
        }
        else if(pocionfuerza == true)
        {
            if(manager.datosserial.monedas >= 20 && manager.datosserial.pocionfue < 100)
            {
			manager.datosserial.monedas -= 20;
			manager.datosserial.monedas -= 20;
            manager.datosserial.pocionfue++;
            manager.guardar();
            pocionvida = false;
            pocionres = false;
            pocionfuerza = false;
            arma1 = false;
            arma2 = false;
            arma3 = false;
            arma4 = false;
            arma5 = false;
            arma6 = false;
            arma7 = false;
            arma8 = false;
            arma9 = false;
            arma10 = false;
            arma11 = false;
            arma12 = false;
            arma13 = false;
            arma14 = false;
            arma15 = false;
            municion = false;
            }
            else
            {
                no.Play();
            }
        }
        else if(arma1 == true)
        {
            if(manager.datosserial.monedas >= 0 && manager.datosserial.tarma[0] == 0)
            {
			manager.datosserial.monedas -= 0;
			manager.datosserial.monedas -= 0;
			manager.datosserial.tarma[0] = 1;
            manager.guardar();
            pocionvida = false;
            pocionres = false;
            pocionfuerza = false;
            arma1 = false;
            arma2 = false;
            arma3 = false;
            arma4 = false;
            arma5 = false;
            arma6 = false;
            arma7 = false;
            arma8 = false;
            arma9 = false;
            arma10 = false;
            arma11 = false;
            arma12 = false;
            arma13 = false;
            arma14 = false;
            arma15 = false;
            municion = false;
            tutp3.Play();
            manager.datosserial.arma = 1;
            manager.datosserial.armastotal++;
            manager.guardar();
            }
            else
            {
                no.Play();
            }
        }
        else if(arma2 == true)
        {
            if(manager.datosserial.monedas >= 30 && manager.datosserial.tarma[1] == 0)
            {
			manager.datosserial.monedas -= 30;
			manager.datosserial.monedas -= 30;
			manager.datosserial.tarma[1] = 1;
            
            pocionvida = false;
            pocionres = false;
            pocionfuerza = false;
            arma1 = false;
            arma2 = false;
            arma3 = false;
            arma4 = false;
            arma5 = false;
            arma6 = false;
            arma7 = false;
            arma8 = false;
            arma9 = false;
            arma10 = false;
            arma11 = false;
            arma12 = false;
            arma13 = false;
            arma14 = false;
            arma15 = false;
            municion = false;
            manager.datosserial.armastotal++;
            manager.datosserial.arma = 2;
            manager.guardar();
            }
            else
            {
                no.Play();
            }
        }
        else if(arma3 == true)
        {
            if(manager.datosserial.monedas >= 50 && manager.datosserial.tarma[2] == 0)
            {
			manager.datosserial.monedas -= 50;
			manager.datosserial.monedas -= 50;
			manager.datosserial.tarma[2] = 1;
            manager.guardar();
            pocionvida = false;
            pocionres = false;
            pocionfuerza = false;
            arma1 = false;
            arma2 = false;
            arma3 = false;
            arma4 = false;
            arma5 = false;
            arma6 = false;
            arma7 = false;
            arma8 = false;
            arma9 = false;
            arma10 = false;
            arma11 = false;
            arma12 = false;
            arma13 = false;
            arma14 = false;
            arma15 = false;
            municion = false;
            manager.datosserial.arma = 3;
            manager.datosserial.armastotal++;
            manager.guardar();
            }
            else
            {
                no.Play();
            }
        }
        else if(arma4 == true)
        {
            if(manager.datosserial.monedas >= 70 && manager.datosserial.tarma[3] == 0)
            {
			manager.datosserial.monedas -= 70;
			manager.datosserial.monedas -= 70;
			manager.datosserial.tarma[3] = 1;
            manager.guardar();
            pocionvida = false;
            pocionres = false;
            pocionfuerza = false;
            arma1 = false;
            arma2 = false;
            arma3 = false;
            arma4 = false;
            arma5 = false;
            arma6 = false;
            arma7 = false;
            arma8 = false;
            arma9 = false;
            arma10 = false;
            arma11 = false;
            arma12 = false;
            arma13 = false;
            arma14 = false;
            arma15 = false;
            municion = false;
            manager.datosserial.arma = 4;
            manager.datosserial.armastotal++;
            manager.guardar();
            }
            else
            {
                no.Play();
            }
        }
        else if(arma5 == true)
        {
            if(manager.datosserial.monedas >= 130 && manager.datosserial.tarma[4] == 0)
            {
			manager.datosserial.monedas -= 130;
			manager.datosserial.monedas -= 130;
			manager.datosserial.tarma[4] = 1;
            manager.guardar();
            pocionvida = false;
            pocionres = false;
            pocionfuerza = false;
            arma1 = false;
            arma2 = false;
            arma3 = false;
            arma4 = false;
            arma5 = false;
            arma6 = false;
            arma7 = false;
            arma8 = false;
            arma9 = false;
            arma10 = false;
            arma11 = false;
            arma12 = false;
            arma13 = false;
            arma14 = false;
            arma15 = false;
            municion = false;
            manager.datosserial.arma = 5;
            manager.datosserial.armastotal++;
            manager.guardar();
            }
            else
            {
                no.Play();
            }
        }
        else if(arma6 == true)
        {
            if(manager.datosserial.monedas >= 250 && manager.datosserial.tarma[5] == 0)
            {
			manager.datosserial.monedas -= 250;
			manager.datosserial.monedas -= 250;
			manager.datosserial.tarma[5] = 1;
            manager.guardar();
            pocionvida = false;
            pocionres = false;
            pocionfuerza = false;
            arma1 = false;
            arma2 = false;
            arma3 = false;
            arma4 = false;
            arma5 = false;
            arma6 = false;
            arma7 = false;
            arma8 = false;
            arma9 = false;
            arma10 = false;
            arma11 = false;
            arma12 = false;
            arma13 = false;
            arma14 = false;
            arma15 = false;
            municion = false;
            manager.datosserial.arma = 6;
            manager.datosserial.armastotal++;
            manager.guardar();
            }
            else
            {
                no.Play();
            }
        }
        else if(arma7 == true)
        {
            if(manager.datosserial.monedas >= 500 && manager.datosserial.tarma[6] == 0)
            {
			manager.datosserial.monedas -= 500;
			manager.datosserial.monedas -= 500;
			manager.datosserial.tarma[6] = 1;
            manager.guardar();
            pocionvida = false;
            pocionres = false;
            pocionfuerza = false;
            arma1 = false;
            arma2 = false;
            arma3 = false;
            arma4 = false;
            arma5 = false;
            arma6 = false;
            arma7 = false;
            arma8 = false;
            arma9 = false;
            arma10 = false;
            arma11 = false;
            arma12 = false;
            arma13 = false;
            arma14 = false;
            arma15 = false;
            municion = false;
            manager.datosserial.arma = 7;
            manager.datosserial.armastotal++;
            manager.guardar();
            }
            else
            {
                no.Play();
            }
        }
        else if(arma8 == true)
        {
            if(manager.datosserial.monedas >= 400 && manager.datosserial.tarma[7] == 0)
            {
			manager.datosserial.monedas -= 400;
			manager.datosserial.monedas -= 400;
			manager.datosserial.tarma[7] = 1;
            manager.guardar();
            pocionvida = false;
            pocionres = false;
            pocionfuerza = false;
            arma1 = false;
            arma2 = false;
            arma3 = false;
            arma4 = false;
            arma5 = false;
            arma6 = false;
            arma7 = false;
            arma8 = false;
            arma9 = false;
            arma10 = false;
            arma11 = false;
            arma12 = false;
            arma13 = false;
            arma14 = false;
            arma15 = false;
            municion = false;
            manager.datosserial.arma = 8;
            manager.datosserial.armastotal++;
            manager.guardar();
            }
            else
            {
                no.Play();
            }
        }
        else if(arma9 == true)
        {
            if(manager.datosserial.monedas >= 200 && manager.datosserial.tarma[8] == 0)
            {
			manager.datosserial.monedas -= 200;
			manager.datosserial.monedas -= 200;
			manager.datosserial.tarma[8] = 1;
            manager.guardar();
            pocionvida = false;
            pocionres = false;
            pocionfuerza = false;
            arma1 = false;
            arma2 = false;
            arma3 = false;
            arma4 = false;
            arma5 = false;
            arma6 = false;
            arma7 = false;
            arma8 = false;
            arma9 = false;
            arma10 = false;
            arma11 = false;
            arma12 = false;
            arma13 = false;
            arma14 = false;
            arma15 = false;
            municion = false;
            manager.datosserial.arma = 9;
            manager.datosserial.armastotal++;
            manager.guardar();
            }
            else
            {
                no.Play();
            }
        }
        else if(arma10 == true)
        {
            if(manager.datosserial.monedas >= 650 && manager.datosserial.tarma[9] == 0)
            {
			manager.datosserial.monedas -= 650;
			manager.datosserial.monedas -= 650;
			manager.datosserial.tarma[9] = 1;
            manager.guardar();
            pocionvida = false;
            pocionres = false;
            pocionfuerza = false;
            arma1 = false;
            arma2 = false;
            arma3 = false;
            arma4 = false;
            arma5 = false;
            arma6 = false;
            arma7 = false;
            arma8 = false;
            arma9 = false;
            arma10 = false;
            arma11 = false;
            arma12 = false;
            arma13 = false;
            arma14 = false;
            arma15 = false;
            municion = false;
            manager.datosserial.arma = 10;
            manager.datosserial.armastotal++;
            manager.guardar();
            }
            else
            {
                no.Play();
            }
        }
        else if(arma11 == true)
        {
            if(manager.datosserial.monedas >= 200 && manager.datosserial.tarma[10] == 0)
            {
			manager.datosserial.monedas -= 200;
			manager.datosserial.monedas -= 200;
			manager.datosserial.tarma[10] = 1;
            manager.guardar();
            pocionvida = false;
            pocionres = false;
            pocionfuerza = false;
            arma1 = false;
            arma2 = false;
            arma3 = false;
            arma4 = false;
            arma5 = false;
            arma6 = false;
            arma7 = false;
            arma8 = false;
            arma9 = false;
            arma10 = false;
            arma11 = false;
            arma12 = false;
            arma13 = false;
            arma14 = false;
            arma15 = false;
            municion = false;
            manager.datosserial.arma = 11;
            manager.datosserial.armastotal++;
            manager.guardar();
            }
            else
            {
                no.Play();
            }
        }
        else if(arma12 == true)
        {
            if(manager.datosserial.monedas >= 150 && manager.datosserial.tarma[11] == 0)
            {
			manager.datosserial.monedas -= 150;
			manager.datosserial.monedas -= 150;
			manager.datosserial.tarma[11] = 1;
            manager.guardar();
            pocionvida = false;
            pocionres = false;
            pocionfuerza = false;
            arma1 = false;
            arma2 = false;
            arma3 = false;
            arma4 = false;
            arma5 = false;
            arma6 = false;
            arma7 = false;
            arma8 = false;
            arma9 = false;
            arma10 = false;
            arma11 = false;
            arma12 = false;
            arma13 = false;
            arma14 = false;
            arma15 = false;
            municion = false;
            manager.datosserial.arma = 12;
            manager.datosserial.armastotal++;
            manager.guardar();
            }
            else
            {
                no.Play();
            }
        }
        else if(arma13 == true)
        {
            if(manager.datosserial.monedas >= 1000 && manager.datosserial.tarma[12] == 0)
            {
			manager.datosserial.monedas -= 1000;
			manager.datosserial.monedas -= 1000;
			manager.datosserial.tarma[12] = 1;
            manager.guardar();
            pocionvida = false;
            pocionres = false;
            pocionfuerza = false;
            arma1 = false;
            arma2 = false;
            arma3 = false;
            arma4 = false;
            arma5 = false;
            arma6 = false;
            arma7 = false;
            arma8 = false;
            arma9 = false;
            arma10 = false;
            arma11 = false;
            arma12 = false;
            arma13 = false;
            arma14 = false;
            arma15 = false;
            municion = false;
            manager.datosserial.arma = 13;
            manager.datosserial.armastotal++;
            manager.guardar();
            }
            else
            {
                no.Play();
            }
        }
        else if(arma14 == true)
        {
            if(manager.datosserial.monedas >= 1000 && manager.datosserial.tarma[13] == 0)
            {
			manager.datosserial.monedas -= 1000;
			manager.datosserial.monedas -= 1000;
			manager.datosserial.tarma[13] = 1;
            manager.guardar();
            pocionvida = false;
            pocionres = false;
            pocionfuerza = false;
            arma1 = false;
            arma2 = false;
            arma3 = false;
            arma4 = false;
            arma5 = false;
            arma6 = false;
            arma7 = false;
            arma8 = false;
            arma9 = false;
            arma10 = false;
            arma11 = false;
            arma12 = false;
            arma13 = false;
            arma14 = false;
            arma15 = false;
            municion = false;
            manager.datosserial.arma = 14;
            manager.datosserial.armastotal++;
            manager.guardar();
            }
            else
            {
                no.Play();
            }
        }
        else if(arma15 == true)
        {
            if(manager.datosserial.monedas >= 2000 && manager.datosserial.tarma[14] == 0)
            {
			manager.datosserial.monedas -= 2000;
			manager.datosserial.monedas -= 2000;
            manager.datosserial.tarma[14] = 1;
            pocionvida = false;
            pocionres = false;
            pocionfuerza = false;
            arma1 = false;
            arma2 = false;
            arma3 = false;
            arma4 = false;
            arma5 = false;
            arma6 = false;
            arma7 = false;
            arma8 = false;
            arma9 = false;
            arma10 = false;
            arma11 = false;
            arma12 = false;
            arma13 = false;
            arma14 = false;
            arma15 = false;
            municion = false;
            manager.datosserial.arma = 15;
            manager.datosserial.armastotal++;
            manager.guardar();
            pushup push = UnityEngine.Object.FindObjectOfType<pushup>();

            if(manager.datostrof.alien3compraladestructora == 0)
            {
                manager.datostrof.alien3compraladestructora = 1;
                manager.guardartro();
                push.push(96);
            }
            }
            else
            {
                no.Play();
            }
        }
        else if(municion == true)
        {
            if(manager.datosserial.monedas >= 5)
            {
			manager.datosserial.monedas -= 5;
			manager.datosserial.monedas -= 5;

            manager.datosserial.marma1 = 200;
		    manager.datosserial.marma5 = 3;
		    manager.datosserial.marma6 = 10;
		    manager.datosserial.marma7 = 300;
		    manager.datosserial.marma8 = 2;
		    manager.datosserial.marma9 = 50;
		    manager.datosserial.marma10 = 28;
		    manager.datosserial.marma13 = 2;
		    manager.datosserial.marma14 = 2;
		    manager.datosserial.marma15 = 40;
            manager.guardar();


            pocionvida = false;
            pocionres = false;
            pocionfuerza = false;
            arma1 = false;
            arma2 = false;
            arma3 = false;
            arma4 = false;
            arma5 = false;
            arma6 = false;
            arma7 = false;
            arma8 = false;
            arma9 = false;
            arma10 = false;
            arma13 = false;
            arma14 = false;
            arma15 = false;
            municion = false;
            }
            else
            {
                no.Play();
            }
        }
        
    }
    public void salir_()
    {
        pocionvida = false;
        pocionres = false;
        pocionfuerza = false;
        arma1 = false;
        arma2 = false;
        arma3 = false;
        arma4 = false;
        arma5 = false;
        arma6 = false;
        arma7 = false;
        arma8 = false;
        arma9 = false;
        arma10 = false;
        arma13 = false;
        arma14 = false;
        arma15 = false;
            municion = false;
        tiendag.SetActive(false);
        valor.text = "valor : ???";
        
    }
    
}
