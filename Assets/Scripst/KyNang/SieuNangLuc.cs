using System.Collections;
using System.Collections.Generic;
//using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class SieuNangLuc : MonoBehaviour
{
    public Transform PoitBangPha;
    public Transform PoitThuatThuc;
    public Transform PoitTuong1;
    public Transform PoitTuong2;
    public Transform Nemqua;
    public GameObject BangPha;
    public GameObject CauBang;
    public GameObject ThuatThuc;
    public GameObject CuaPhat;
    public GameObject CuaPhat2;
    public GameObject KiemThan;
    public GameObject Qua;
    public Transform PoitCauBang1;
    public Transform PoitCauBang2;
    public Transform PoitKiemThan;
    public void BanhPha()
    {
        BangPha.transform.localScale=PlayerControler.instance.transform.localScale;   
        GameObject Ski = Instantiate(BangPha,PoitBangPha.position,Quaternion.identity);    
    }
    public void CauBang1()
    {
         GameObject Skill = Instantiate(CauBang, PoitCauBang1.position, Quaternion.identity);

    }
    public void CauBang2()
    {
       GameObject Skill = Instantiate(CauBang, PoitCauBang2.position, Quaternion.identity);

    }
    public void TrieuHoiThuatThuc()
    {
        GameObject Skill4 = Instantiate(ThuatThuc, PoitThuatThuc.position, Quaternion.identity);
    }
    public void NemQua()
    {
        GameObject kynang=Instantiate(Qua,Nemqua.position, Quaternion.identity);
    }
    public void KiemKhi()
    {
        GameObject Kiem = Instantiate(KiemThan, PoitKiemThan.position, Quaternion.identity);
        Kiem.transform.localScale = PlayerControler.instance.transform.localScale;
    }
    public void TrieuHoiCotTrongTam()
    {
        Manager.Instance.SoundCuaphat.Play();
        GameObject Skill4 = Instantiate(CuaPhat, PoitTuong1.position, Quaternion.identity);
        GameObject Skill5 = Instantiate(CuaPhat2, PoitTuong2.position, Quaternion.identity);
    }
    public void SoundQP()
    {
        Manager.Instance.SoundQP.Play();
    }
    public void SoundAttackCharacter()
    {
        Manager.Instance.SoundAttackplayer.Play();
    }
    public Animator anim;
    int Choiatack = 0;
    private void Start()
    {
    }
    private void FixedUpdate()
    {
        if (Choiatack == 3)
        {
            Choiatack = 0;
        }
    }
    public void Attack()
    {
        anim.SetBool("Bon", true);
        anim.SetFloat("Attack", Choiatack);
        Choiatack++;
    }
    public void Stop()
    {
        anim.SetBool("Bon", false);
    }
    public void DowBangpha()
    {
        Manager.Instance.SoundBangpha.Play();
        anim.SetBool("Bon", true);
        anim.SetFloat("Attack", 3);
    }
    public void SkillCauBangDow()
    {
        Manager.Instance.SoundCauBang.Play();
        if (PlayerprefFruit.instanFruit.Cam >= 1)
        {
            anim.SetBool("Bon", true);
            anim.SetFloat("Attack", 4);
            PlayerprefFruit.instanFruit.userbuttonCam();
        }
    }
    public void SkillNemQuaBomDow()
    {
        Manager.Instance.SoundBom.Play();
        if (PlayerprefFruit.instanFruit.Tao >= 1)
        {
            anim.SetBool("Bon", true);
            anim.SetFloat("Attack", 5);
            PlayerprefFruit.instanFruit.userbuttonTao();
        }
    }
    public void DowTrHoiThuatT()
    {
        Manager.Instance.SoundThuatthuc.Play();
        if (PlayerprefFruit.instanFruit.Bo >= 1)
        {
            anim.SetBool("Bon", true);
            anim.SetFloat("Attack", 6);
            PlayerprefFruit.instanFruit.userbuttonBo();
        }
    }
    public void DowKiemThan()
    {
        Manager.Instance.SoundKiemThan.Play();
        anim.SetBool("Bon", true);
        anim.SetFloat("Attack", 7);
    }
    //ngoaile CauBang
    int a;
    public void SSS()
    {
        a++;
        if (a == 2)
        {
            anim.SetBool("Bon", false);
            a = 0;
        }
    }
}
