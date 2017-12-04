using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public class Users
    {
        public static int userid;
        public string username { get; set; }
        public string nAme { get; set; }
        public string sUrname { get; set; }
        public string pAssword { get; set; }
        public string newPassword { get; set; }
        public int questionid { get; set; }
        public string sAnswer { get; set; }
        public int userRoleid { get; set; }
        public DateTime userCreatedate { get; set; }
        public Users()
        {

        }

        public bool KullaniciEkle(string username, string nAme, string sUrname, string pAssword, int userRoleid, int questionID, string answer)
        {

            using (dbYazılımSınamaEntities y = new dbYazılımSınamaEntities())
            {
                y.tblUsers.Add(new tblUsers()
                {
                    userName = username,
                    name = nAme,
                    surname = sUrname,
                    password = pAssword,
                    userRoleID = userRoleid,
                    userCreateDate = DateTime.Now,
                    questionID = questionID,
                    answer = answer
                });

                if (y.SaveChanges() == 1)
                    return true;
                else
                    return false;
            }
        }
        public bool KullaniciAdKontrol(string username)
        {
            using (dbYazılımSınamaEntities y = new dbYazılımSınamaEntities())
            {
                var kullanici = y.tblUsers.Where(u => u.userName == username).Count();

                if (kullanici > 0)
                    return true;
                else
                    return false;
            }
        }
        public bool GirisYap(string username, string pAssword)
        {
            using (dbYazılımSınamaEntities y = new dbYazılımSınamaEntities())
            {
                tblUsers giris = (from a in y.tblUsers where a.userName == username && a.password == pAssword select a).FirstOrDefault();
                if (giris != null)
                {
                    userid = giris.userID;
                    return true;
                }
                else
                    return false;

            }

        }
        public string SifreDegistir(string username, int questionid, string sAnswer, string newPassword)
        {

            using (dbYazılımSınamaEntities y = new dbYazılımSınamaEntities())
            {

                var degistir = (from us in y.tblUsers
                                join qu in y.tblSecurityQuestions on us.questionID equals qu.questionID
                                where (us.userName == username) && (qu.questionID == questionid) && (us.answer == sAnswer)
                                select us).SingleOrDefault();

                if (degistir == null)
                {
                    return "Böyle bir kullanıcı yok!";
                }
                else
                {
                    degistir.password = newPassword;
                    //degistir = newPassword;
                    // y.tblUsers.Where(u => u.userName == username);
                    //tblUsers guncelle=y.


                    if (y.SaveChanges() == 1)
                        return "Şifre Değiştirildi! :)";
                    else
                        return "Hata!! :(";
                }
            }

        }



    }



}

