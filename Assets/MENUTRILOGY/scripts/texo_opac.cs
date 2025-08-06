using UnityEngine;
using UnityEngine.UI;

public class texo_opac : MonoBehaviour
{

    public Text valor;
    private string valorAnterior;
    public float opac = 0;
    public float vel = 0.3f;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        valor = GetComponent<Text>();

    }

    // Update is called once per frame
    void Update()
    {
        if (valor.text != valorAnterior)
        {
            OnValorCambiado(valorAnterior, valor.text);
            valorAnterior = valor.text;
        }
        if(valor.color != new Color(valor.color.r, valor.color.g, valor.color.b, 1))
        {
            valor.color = new Color(valor.color.r, valor.color.g, valor.color.b, opac);
            opac += vel * Time.deltaTime;


        }
        
    }
    void OnValorCambiado(string antes, string despues)
    {
        opac = 0;
        valor.color = new Color(valor.color.r, valor.color.g, valor.color.b, 0);


    }
}
