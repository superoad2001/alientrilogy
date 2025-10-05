using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System;

[Serializable]
public class notas_al1
{
    public string[] notas = new string[7];
    public string[] notasdesc = new string[7];
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        notas[0] = "nota 1";
        notas[1] = "nota 2";
        notas[2] = "nota 3";
        notas[3] = "nota 4";
        notas[4] = "nota 5";
        notas[5] = "nota 6";
        notas[6] = "nota 7";




        notasdesc[0] = "AR. el astrologo que contrate va a llegar en breves, espero que localize la ubiacion de la energia ancestral, su poder es capaz de controlar el espacio tiempo y rehacer el universo";
        notasdesc[1] = "HO. pensaba que eran cuentos hasta que encontre un fragmento de su poder, con solo esta piedra de poco mas de un cenitimetro puedo controlar objetos y materia viva poco falta para que averigue su potencial";
        notasdesc[2] = "DA. el astrologo llego hace 2 dias,no sabe lo que estoy buscando, le pedi que me dijera la ubicacion del centro exacto del universo, pues es ahi donde se oculta tan inmenso poder";
        notasdesc[3] = "20. el pago va ser un arma de alto poder,al principio se nego ahora, pero acepto el trato, el arma necesita una llave la oculte en mis notas asi que no va poder util";
        notasdesc[4] = "19. cuando termine mandare uno de mis bots holograma a matarlo, a venido desarmado,y no va a poder desbloquear el arma";
        notasdesc[5] = "20. el ya a partido y ya tengo una idea de donde se ubica el problema es una barrera que me impide el acceso voy a necesitar un gran fuente de energia para dispiar la barrera";
        notasdesc[6] = "??. mi bot me informa que a acertado un misil a la nave del astrologo, le dire que compruebe si a muerto y que termine el trabajo";



    }


}
