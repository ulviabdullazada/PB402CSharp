namespace Abstract_Interface;
/*
 Aşağıdakı memberlərdən ibarət User class yaradın
 - UserName - istifadəçinin istifadəçi adını ifadə edir
 - Password - İstifadəçinin şifrə dəyərini ifadə edir


UserName dəyəri təyin olunmamış User obyekti yaradıla bilinməməlidir.UserName dəyərinin uzunluğu minimum 6, maksimum 25 ola bilər.
Password dəyərinin uzunluğu minimum 8 , maksimum 25 ola bilər və içərisində mütləq ən az 1 böyük, 1 kiçik hərf və 1 rəqəm olmalıdır.


Daha sonra User type-da olan obyekt yaradın, bunun üçün username və password dəyərlərini console-dan qəbul edin.


User classin icinde asagidaki metodlar da olsun:


  - HasDigit - parametr olaraq string dəyər qəbul edib o dəyərdə rəqəm varsa geriyə true yoxdusa false qaytaran metod
  - HasUpper -  parametr olaraq string dəyər qəbul edib o dəyərdə uppercase varsa geriyə true yoxdursa false qaytaran metod
  - HasLower - parametr olaraq string dəyər qəbul edib o dəyərdə lowercase varsa geriyə true yoxdursa false qaytaran metod
*/
public class User
{
    private string _userName;
    public string Username
    {
        get
        {
            return _userName;
        }
        set
        {
            if (value.Length > 5 && value.Length < 26)
            {
                _userName = value;
            }
        }
    }

    private string _password;
    public string Password
    {
        get
        {
            return _password;
        }
        set
        {
            if (value.Length > 7 && value.Length < 26 && HasDigit(value) && HasLower(value) && value.HasUpper())
            {
                _password = value;
            }
        }
    }

    public User(string username)
    {
        Username = username;
    }

    static bool HasDigit(string text)
    {
        foreach (var letter in text)
        {
            if (Char.IsDigit(letter))
            {
                return true;
            }
        }
        return false;
    }

    static bool HasLower(string text)
    {
        foreach (var letter in text)
        {
            if (Char.IsLower(letter))
            {
                return true;
            }
        }
        return false;
    }
    public override string ToString()
    {
        return $"{Username} {Password}";
    }
}
