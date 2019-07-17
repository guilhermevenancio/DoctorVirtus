using System.IO;

namespace DoctorVirtus.Aplicativo.Interface {
    public interface IFile {
        bool Exists(string fileName);
        void Save(string filename, MemoryStream stream);
        Stream Read(string fileName);
    }
    
    public interface IAndroidVersionDependencyService {
        int GetAndroidVersion();
    }
}
