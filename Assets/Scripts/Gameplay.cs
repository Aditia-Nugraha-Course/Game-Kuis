using UnityEngine;
using UnityEngine.UI;

public class Gameplay : MonoBehaviour
{
    public string[] soal, jawaban;
    public Text textSoal, textSkor;
    public InputField inputJawaban;
    public GameObject feedBenar, feedSalah, selesai, bankSoal;
    int urutanSoal = -1, skor = 0;

    void Start()
    {
        TampilSoal();
    }

    void TampilSoal()
    {
        urutanSoal++;
        textSoal.text = soal[urutanSoal];
    }

    public void Jawab()
    {
        if(urutanSoal < soal.Length - 1)
        {
            if(inputJawaban.text == jawaban[urutanSoal])
            {
                skor += 20;
                feedBenar.SetActive(false);
                feedSalah.SetActive(false);
                feedBenar.SetActive(true);
            }
            
            else
            {
                feedBenar.SetActive(false);
                feedSalah.SetActive(false);
                feedSalah.SetActive(true);
            }
            inputJawaban.text = "";
            TampilSoal();
        }

        else
        {
            selesai.SetActive(true); 
            bankSoal.SetActive(false); 
        }
    }

    void Update()
    {
        textSkor.text = skor.ToString();
    }
}
