using UnityEngine;

public class Scoulting : MonoBehaviour
{
    public float Velocidade;
    public Transform Posicao; // Posi��o que o inimigo ir� percorrer
    public float TempoEspera; // Tempo para mudar de posi��o
    public float x_Min, x_Max, y_Min, y_Max;

    float Tempo; // Saber o tempo que est�

    void Start()
    {
        Posicao.position = new Vector2(Random.Range(x_Min, x_Max), Random.Range(y_Min, y_Max));
        Tempo = TempoEspera;
    }

    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, Posicao.position, Velocidade * Time.deltaTime);

        float _dist = Vector2.Distance(transform.position, Posicao.position);

        if (_dist <= .2f)
            if (Tempo <= 0)
            {
                Posicao.position = new Vector2(Random.Range(x_Min, x_Max), Random.Range(y_Min, y_Max));
                Tempo = TempoEspera;
            }
            else
                Tempo -= Time.deltaTime;
    }
}
