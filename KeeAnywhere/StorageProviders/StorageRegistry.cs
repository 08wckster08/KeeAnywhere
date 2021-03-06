using System.Collections.Generic;
using System.Linq;
using KeeAnywhere.StorageProviders.AmazonS3;
using KeeAnywhere.StorageProviders.Box;
using KeeAnywhere.StorageProviders.Dropbox;
using KeeAnywhere.StorageProviders.GoogleDrive;
using KeeAnywhere.StorageProviders.HiDrive;
using KeeAnywhere.StorageProviders.HubiC;
using KeeAnywhere.StorageProviders.OneDrive;
using KeePassLib.Native;

namespace KeeAnywhere.StorageProviders
{
    public static class StorageRegistry
    {
        static StorageRegistry()
        {
            var d = new HashSet<StorageDescriptor>();

            var isUnix = NativeLib.IsUnix();

            d.Add(new StorageDescriptor(StorageType.AmazonS3, "Amazon S3", "s3", account => new AmazonS3StorageProvider(account), () => new AmazonS3StorageConfigurator(), PluginResources.AmazonS3_16x16));
            if (!isUnix) d.Add(new StorageDescriptor(StorageType.Box, "Box", "box", account => new BoxStorageProvider(account), () => new BoxStorageConfigurator(), PluginResources.Box_16x16));
            d.Add(new StorageDescriptor(StorageType.Dropbox, "Dropbox", "dropbox", account => new DropboxStorageProvider(account), () => new DropboxStorageConfigurator(false), PluginResources.Dropbox_16x16));
            d.Add(new StorageDescriptor(StorageType.DropboxRestricted, "Dropbox-Restricted", "dropbox-r", account => new DropboxStorageProvider(account), () => new DropboxStorageConfigurator(true), PluginResources.Dropbox_16x16));
            d.Add(new StorageDescriptor(StorageType.GoogleDrive, "Google Drive", "gdrive", account => new GoogleDriveStorageProvider(account), () => new GoogleDriveStorageConfigurator(), PluginResources.GoogleDrive_16x16));
            if (!isUnix) d.Add(new StorageDescriptor(StorageType.HiDrive, "HiDrive", "hidrive", account => new HiDriveStorageProvider(account), () => new HiDriveStorageConfigurator(), PluginResources.HiDrive_16x16));
            if (!isUnix) d.Add(new StorageDescriptor(StorageType.HubiC, "hubiC", "hubic", account => new HubiCStorageProvider(account), () => new HubiCStorageConfigurator(), PluginResources.HubiC_16x16));
            d.Add(new StorageDescriptor(StorageType.OneDrive, "OneDrive", "onedrive", account => new OneDriveStorageProvider(account), () => new OneDriveStorageConfigurator(), PluginResources.OneDrive_16x16));

            Descriptors = d.ToArray();
        }

        public static IEnumerable<StorageDescriptor> Descriptors;
    }
}