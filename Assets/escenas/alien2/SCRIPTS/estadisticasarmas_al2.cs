using UnityEngine;

public class estadisticasarmas_al2 : MonoBehaviour
{

    public float[] balapadrevel = new float[10];
	public float[] balapadredano = new float[10];
	public float[] balapadrecaden = new float[10];

	public float[] baladefdano = new float[10];
	public float[] balareldano = new float[10];



    public float[] armapalosignv = new float[10];
	public float[] armadefsignv = new float[10];
	public float[] armapapasignv = new float[10];
	public float[] armarelsignv = new float[10];



	public float[] armadefmun = new float[10];
	public float[] armapapamun = new float[10];
	public float[] armarelmun = new float[10];



    public float[] armadcebomun = new float[10];
    public float[] armaondamun = new float[10];
	public float[] armaratamun = new float[10];
	public float[] armaescopetamun = new float[10];

    public float[] armacebosignv = new float[10];
	public float[] armaondasignv = new float[10];
	public float[] armaratasignv = new float[10];
	public float[] armarescopetasignv = new float[10];

	public float[] balaondadano = new float[10];
    public float[] balaratadano = new float[10];
	public float[] balaescopetadano = new float[10];



    public float[] armabazokamun = new float[10];
    public float[] armaminamun = new float[10];
	public float[] armaescudomun = new float[10];
	public float[] armaatomicamun = new float[10];

    public float[] armabazokasignv = new float[10];
	public float[] armaminasignv = new float[10];
	public float[] armaescudosignv = new float[10];
	public float[] armaatomicasignv = new float[10];

    public float[] balabazokadano = new float[10];
	public float[] balaminadano = new float[10];
    public float[] balaescudodano = new float[10];
	public float[] balaatomicadano = new float[10];




    public float[] balacebodano = new float[10];
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        	balapadrevel = new float[10];
			balapadredano = new float[10];
			balapadrecaden = new float[10];

			baladefdano = new float[10];
			balareldano = new float[10];


			armapalosignv = new float[10];
			armadefsignv = new float[10];
			armapapasignv = new float[10];
			armarelsignv = new float[10];

			armapalosignv[0] = 80;
			armadefsignv[0] = 10;
			armapapasignv[0] = 300;
			armarelsignv[0] = 20;


			armadefmun[0] = 10;
			armapapamun[0] = 50;
			armarelmun[0] = 2;



			balapadrevel[0] = 10f;
			balapadredano[0] = 1.5f;
			balapadrecaden[0] = 0.8f;



			baladefdano[0] = 20;

			balareldano [0]= 0;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
