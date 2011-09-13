using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AppLimit.CloudComputing.SharpBox;
using AppLimit.CloudComputing.SharpBox.StorageProvider.DropBox;

namespace AirSynx
{
    class Program
    {
        static void Main(string[] args)
        {
            CloudStorage dropBoxStorage = new CloudStorage();
            var dropBoxConfig = CloudStorage.GetCloudConfigurationEasy(nSupportedCloudConfigurations.DropBox);
            var dropBoxCredentials = new DropBoxCredentials();
            dropBoxCredentials.ConsumerKey = "zip1sn9ee6cbnh3";
            dropBoxCredentials.ConsumerSecret = "8l5kntfytecpuga";
            dropBoxCredentials.UserName = "admin@etheralstudios.com";
            dropBoxCredentials.Password = "superxl1";
            var storageToken = dropBoxStorage.Open(dropBoxConfig, dropBoxCredentials);
            dropBoxStorage.CreateFolder("/Synx");
            var Folder = dropBoxStorage.GetFolder("/Synx");
            String srcFile = Environment.ExpandEnvironmentVariables("C:\\Users\\Nicholas\\Test.txt");
            dropBoxStorage.UploadFile(srcFile, Folder);
            dropBoxStorage.Close();
        }
    }
}
