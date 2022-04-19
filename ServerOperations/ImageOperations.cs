using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Renci.SshNet;
using System.Net;
using System.IO;

namespace BookStore
{
    public static class ImageOperations
    {
        // Enter your host name or IP here
        private static string host = _host;
        // Enter your sftp username here
        private static string username = _user;
        // Enter your sftp password here
        private static string password = _pass;

        public static Stream DownloadImage(string coverPagePicture)
        {
            WebClient webClient = new WebClient();
            Stream stream = webClient.OpenRead(_url + coverPagePicture.Replace(" ", "%20")); 
            return stream;
        }

        public static void UploadImage(string fileName, string name)
        {
            var connectionInfo = new ConnectionInfo(host, username, new PasswordAuthenticationMethod(username, password));
            using (var sftp = new SftpClient(connectionInfo))
            {
                sftp.Connect();
                sftp.ChangeDirectory(_directory);
                using (var uplfileStream = System.IO.File.OpenRead(fileName))
                {
                    sftp.UploadFile(uplfileStream, name, true);
                }
                sftp.Disconnect();
            }
        }

        public static void DeleteImage(string coverPagePicture)
        {
            var connectionInfo = new ConnectionInfo(host, username, new PasswordAuthenticationMethod(username, password));
            using (var sftp = new SftpClient(connectionInfo))
            {
                sftp.Connect();
                sftp.ChangeDirectory(_directory);
                sftp.DeleteFile(coverPagePicture);
                sftp.Disconnect();
            }
        }
    }
}