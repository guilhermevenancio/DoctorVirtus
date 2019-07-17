using System;
using System.IO;
using Java.IO;
using Xamarin.Forms;

[assembly: Dependency(typeof(SaveAndroid))]

/// <summary>
/// This method used to save the files.
/// </summary>
public class SaveAndroid : DoctorVirtus.Aplicativo.Interface.IFile
{
    /// <summary>
    /// Save method used to save the files using <see cref="MemoryStream"/> class.
    /// </summary>
    /// <param name="fileName">Name of the output file.</param>
    /// <param name="stream">The file in the form of <see cref="MemoryStream"/> class.</param>
    /// 

    public bool Exists(string fileName)
    {
        string exception = string.Empty;
        string root = null;

        if (Android.OS.Environment.IsExternalStorageEmulated)
            root = Android.OS.Environment.ExternalStorageDirectory.ToString();
        else
            root = Environment.GetFolderPath(Environment.SpecialFolder.Personal);

        Java.IO.File myDir = new Java.IO.File(root + "/Atlanta Sistemas");
        
        Java.IO.File file = new Java.IO.File(myDir, fileName);

        if (file.Exists())
            return true;
        else
            return false;

    }

    public Stream Read(string fileName)
    {
        string exception = string.Empty;
        string root = null;

        if (Android.OS.Environment.IsExternalStorageEmulated)
            root = Android.OS.Environment.ExternalStorageDirectory.ToString();
        else
            root = Environment.GetFolderPath(Environment.SpecialFolder.Personal);

        //Java.IO.File myDir = new Java.IO.File(root + "/Atlanta Sistemas");

        //Java.IO.File file = new Java.IO.File(myDir, fileName);

        return new MemoryStream(System.IO.File.ReadAllBytes(root + "/Atlanta Sistemas/" + fileName));

        //MemoryStream file = Context.OpenFileInput(root + "/Atlanta Sistemas/" + fileName);

    }

    //public void Save(string fileName, string contentType, MemoryStream stream)
    public void Save(string fileName, MemoryStream stream)
    {
        string exception = string.Empty;
        string root = null;

        if (Android.OS.Environment.IsExternalStorageEmulated)
            root = Android.OS.Environment.ExternalStorageDirectory.ToString();
        else
            root = Environment.GetFolderPath(Environment.SpecialFolder.Personal);

        Java.IO.File myDir = new Java.IO.File(root + "/Atlanta Sistemas");
        myDir.Mkdir();



        Java.IO.File file = new Java.IO.File(myDir, fileName);

        if (file.Exists())
        {
            file.Delete();
        }

        //try
        //{
            FileOutputStream outs = new FileOutputStream(file);
            outs.Write(stream.ToArray());

            outs.Flush();
            outs.Close();
        //}
        //catch (Exception e)
        //{
        //    exception = e.ToString();
        //}
        /*finally
        {
            if (contentType != "application/html")
            {
                stream.Dispose();
            }
        }*/

        /*if (file.Exists() && contentType != "application/html")
        {
            Android.Net.Uri path = Android.Net.Uri.FromFile(file);
            string extension = Android.Webkit.MimeTypeMap.GetFileExtensionFromUrl(Android.Net.Uri.FromFile(file).ToString());
            string mimeType = Android.Webkit.MimeTypeMap.Singleton.GetMimeTypeFromExtension(extension);
            Intent intent = new Intent(Intent.ActionView);
            intent.SetFlags(ActivityFlags.ClearTop | ActivityFlags.NewTask);
            path = FileProvider.GetUriForFile(Android.App.Application.Context, Android.App.Application.Context.PackageName + ".provider", file);
            intent.SetDataAndType(path, mimeType);
            intent.AddFlags(ActivityFlags.GrantReadUriPermission);
            Android.App.Application.Context.StartActivity(Intent.CreateChooser(intent, "Choose App"));
        }*/
    }

    /*public string AppPath()
    {
        string root = null;
        if (Android.OS.Environment.IsExternalStorageEmulated)
        {
            root = Android.OS.Environment.ExternalStorageDirectory.ToString();
        }
        else
        {
            root = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        }

        Java.IO.File myDir = new Java.IO.File(root + "/Atlanta Sistemas");
        myDir.Mkdir();

        return root + "/Atlanta Sistemas";

    }*/

}