
using System;
using System.Net;
using System.Net.Mail;
using System.Net.Mime;
using System.Threading;
using System.ComponentModel;

namespace dotnetCoreSendMail
{
    class Program
    {
        static void Main(string[] args)
        {
            //send mail with SendGrid
            var server = "smtp.sendgrid.net";
            var pwd = "SG.4aXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXlrECI"; //API secret
            var sender = "xxxxxxxxx@hotmail.com"; //必須驗證過的發信者
            SmtpClient client = new SmtpClient(server);
            client.Port = 25;
            client.Credentials = new System.Net.NetworkCredential("apikey", pwd);
            client.Send(sender, "david@isrock.com.tw", "主旨", "內文");
        }
    }
}
