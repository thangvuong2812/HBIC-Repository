using BusinessObject;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace HBIC_Official.Code
{
    public class UpLoadFile
    {
        IConfiguration _config;
        public UpLoadFile()
        {
            _config = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json").Build();
        }

        public async Task<BOPath> UploadSingle(IFormFile file)
        {
            var ftpConn = _config.GetSection("FTPConnection");
            string ftpurl = ftpConn.GetSection("FtpUrl").Value;
            string ftpusername = ftpConn.GetSection("FtpUser").Value;
            string ftppassword = ftpConn.GetSection("FtpPass").Value;
            string filePath = "/HBIC/" + DateTime.Now.ToString("yyyyyMMddhhmmssfff") + "_" + file.FileName;
            string ftpFullPath = ftpurl + filePath;
            if (string.IsNullOrEmpty(ftpFullPath))
            {
                return null;
            }
            FtpWebRequest ftp = (FtpWebRequest)FtpWebRequest.Create(ftpFullPath);
            ftp.Credentials = new NetworkCredential(ftpusername, ftppassword);
            ftp.KeepAlive = false;
            ftp.UseBinary = true;
            ftp.EnableSsl = false;
            ftp.UsePassive = true;

            ftp.Method = WebRequestMethods.Ftp.UploadFile;
            ServicePointManager.ServerCertificateValidationCallback = delegate (object s, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors)
            {
                return true;
            };

            using (Stream stream = ftp.GetRequestStream())
            {
                await file.CopyToAsync(stream);
            }

            return new BOPath { FullPath = ftpFullPath, FilePath = filePath };
        }
        public string DeleteFile1(IFormFile file)
        {
            var ftpConn = _config.GetSection("FTPConnection");
            string ftpurl = ftpConn.GetSection("FtpUrl").Value;
            string ftpusername = ftpConn.GetSection("FtpUser").Value;
            string ftppassword = ftpConn.GetSection("FtpPass").Value;
            string filePath = "/HBIC/" + DateTime.Now.ToString("yyyyyMMddhhmmssfff") + "_" + file.FileName;
            string ftpFullPath = ftpurl + filePath;
            FtpWebRequest request = (FtpWebRequest)WebRequest.Create(ftpFullPath);
            request.Method = WebRequestMethods.Ftp.DeleteFile;
            request.Credentials = new NetworkCredential(ftpusername, ftppassword);

            using (FtpWebResponse response = (FtpWebResponse)request.GetResponse())
            {
                return response.StatusDescription;
            }
        }
    }

}
