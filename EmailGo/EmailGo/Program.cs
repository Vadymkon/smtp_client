using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Mail;
using System.Net;
using System.Windows;

namespace EmailGo
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 2 && args[0].Length != 0 && args[1].Length != 0)
            {
                SmtpClient C = new SmtpClient("smtp.gmail.com");
                C.Port = 587;
                C.Credentials = new NetworkCredential("vadykakonon", "code");
                C.EnableSsl = true;
                C.Send(new MailMessage("vadykakonon@gmail.com", args[0], args[1], $"LAB-1\n{DateTime.Now}\nKonchaVadym"));
                MessageBox.Show("done.");
            }
            else
            {
                Console.WriteLine("SYNTAX: mail-1 <ToAddr> <Title>");
                MessageBox.Show("failed.");
            }
        }
    }
}