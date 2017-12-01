using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

using UnityEngine.Collections;
using System;
using System.Text.RegularExpressions;



public class Login2 : MonoBehaviour
{

    public GameObject username;
    public GameObject email;
    public GameObject password;
    public GameObject passwordConformation;
    public string Name;
    private string Email;
    private string Password;
    private string PasswordConformation;
    private string Form;
    private bool EmailValid = false;
    public Text txt_status;

    void Start()
    {


    }

    public void RegisterButton()
    {
        bool N = false;
        bool E = false;
        bool P = false;
        bool PC = false;
        EmailValid = false;
        if (Name != "")
        {
            if (!System.IO.File.Exists(@"C:\tmp\" + Name + ".txt"))
            {
                N = true;

            }
            else
            {

                txt_status.text = "Username Has Been Taken";
            }
        }
        else
        {

            txt_status.text = "Username Field is empty";
        }
        if (Email != "")
        {
            EmailValid = Regex.IsMatch(Email, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase);
            if (EmailValid == true)
            {
                if (Email.Contains("@") == true)
                {
                    if (Email.Contains(".") == true)
                    {
                        E = true;
                    }
                    else
                    {

                        txt_status.text = "Email Field is Incorrect";
                    }
                }
                else
                {
                    txt_status.text = "Email Field is Incorrect";
                }
            }
            else
            {

                txt_status.text = "Email Field is Incorrect";
            }
        }
        else
        {

            txt_status.text = "Email Field is empty or Incorrect";
        }
        if (Password != "")
        {
            if (Password.Length > 5)
            {
                P = true;
            }
            else
            {

                txt_status.text = "Password Must at least be 6 characters long";
            }
        }
        else
        {
            txt_status.text = "Password Field is empty";
        }
        if (Password == PasswordConformation)
        {
            PC = true;
            if (P == true)
            {

            }
        }
        else
        {
            txt_status.text = "Passwords Don't Match";
        }
        if (N == true && E == true && P == true && PC == true)
        {
            int i = 1;
            bool Clear = true;
            foreach (char c in Password)
            {
                i++;
                if (Clear)
                {
                    Password = "";
                    Clear = false;
                }
                char Encrypted = (char)(c * i);
                Password += Encrypted.ToString();
            }

            Form = (Name + Environment.NewLine + Email + Environment.NewLine + Password);
            System.IO.File.WriteAllText(@"C:\tmp\" + Name + ".txt", Form);
            txt_status.text = "Registration Successful";
            username.GetComponent<InputField>().text = "";
            email.GetComponent<InputField>().text = "";
            password.GetComponent<InputField>().text = "";
            passwordConformation.GetComponent<InputField>().text = "";

        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            if (username.GetComponent<InputField>().isFocused)
            {
                email.GetComponent<InputField>().Select();
            }
            if (email.GetComponent<InputField>().isFocused)
            {
                password.GetComponent<InputField>().Select();
            }
            if (password.GetComponent<InputField>().isFocused)
            {
                passwordConformation.GetComponent<InputField>().Select();
            }
        }
        if (Input.GetKeyDown(KeyCode.Return))
        {
            if (PasswordConformation != "" && Password != "" && Email != "" && Name != "")
            {
                RegisterButton();
            }
        }
        Name = username.GetComponent<InputField>().text;
        Email = email.GetComponent<InputField>().text;
        Password = password.GetComponent<InputField>().text;
        PasswordConformation = passwordConformation.GetComponent<InputField>().text;


    }
}