using UnityEngine;

public class MovingTrap : MonoBehaviour
{
    public float speed;             // Tuzak hareket h�z�
    public int startingPoint;       // Ba�lang��ta tuzak hangi hedef noktas�nda ba�las�n
    public Transform[] points;      // Tuzak i�in hedef noktalar�n listesi
    private int i;                  // �u anki hedef noktas�n�n dizindeki indeksi

    // Start is called before the first frame update
    void Start()
    {
        InitializeTrap();
    }

    // Update is called once per frame
    void Update()
    {
        MoveTrap();
    }

    // Tuzak i�in ba�lang�� durumunu ayarlayan metod
    private void InitializeTrap()
    {
        i = startingPoint;          // Hedef dizisindeki ba�lang�� noktas�n� belirle
        MoveToStartingPoint();      // Tuzak ba�lang�� noktas�na ta��n�r
    }

    // Tuzak hareketini kontrol eden metod
    private void MoveTrap()
    {
        if (Vector2.Distance(transform.position, points[i].position) < 0.02)
        {
            ChangeTargetPoint();    // E�er �u anki hedef noktas�na yak�nsa, yeni hedef noktas�na ge�
        }
        MoveTowardsNextPoint();     // Hedefe do�ru hareket et
    }

    // Tuzak mevcut hedef noktas�na ta��n�r
    private void MoveToStartingPoint()
    {
        transform.position = points[startingPoint].position;
    }

    // Yeni bir hedef noktas�na ge�er
    private void ChangeTargetPoint()
    {
        i++;
        if (i == points.Length)
        {
            i = 0;                  // Dizi sonuna gelindi�inde, ba�a d�nmek i�in s�f�ra s�f�rlar
        }
    }

    // Hedefe do�ru hareket et
    private void MoveTowardsNextPoint()
    {
        transform.position = Vector2.MoveTowards(transform.position, points[i].position, speed * Time.deltaTime);
    }
}

