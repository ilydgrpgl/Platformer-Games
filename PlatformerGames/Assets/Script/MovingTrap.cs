using UnityEngine;

public class MovingTrap : MonoBehaviour
{
    public float speed;             // Tuzak hareket hýzý
    public int startingPoint;       // Baþlangýçta tuzak hangi hedef noktasýnda baþlasýn
    public Transform[] points;      // Tuzak için hedef noktalarýn listesi
    private int i;                  // Þu anki hedef noktasýnýn dizindeki indeksi

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

    // Tuzak için baþlangýç durumunu ayarlayan metod
    private void InitializeTrap()
    {
        i = startingPoint;          // Hedef dizisindeki baþlangýç noktasýný belirle
        MoveToStartingPoint();      // Tuzak baþlangýç noktasýna taþýnýr
    }

    // Tuzak hareketini kontrol eden metod
    private void MoveTrap()
    {
        if (Vector2.Distance(transform.position, points[i].position) < 0.02)
        {
            ChangeTargetPoint();    // Eðer þu anki hedef noktasýna yakýnsa, yeni hedef noktasýna geç
        }
        MoveTowardsNextPoint();     // Hedefe doðru hareket et
    }

    // Tuzak mevcut hedef noktasýna taþýnýr
    private void MoveToStartingPoint()
    {
        transform.position = points[startingPoint].position;
    }

    // Yeni bir hedef noktasýna geçer
    private void ChangeTargetPoint()
    {
        i++;
        if (i == points.Length)
        {
            i = 0;                  // Dizi sonuna gelindiðinde, baþa dönmek için sýfýra sýfýrlar
        }
    }

    // Hedefe doðru hareket et
    private void MoveTowardsNextPoint()
    {
        transform.position = Vector2.MoveTowards(transform.position, points[i].position, speed * Time.deltaTime);
    }
}

