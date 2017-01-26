using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace PaintNewEra
{
    class SaverLoader
    {
        private String lastPath;

        public bool canSaveWithoutAs()
        {
            return lastPath != null;
        }

        public void saveAs(String path, SavedStatus status)
        {
            lastPath = path;
            var bf = new BinaryFormatter();
            using (var sw = new StreamWriter(lastPath))
            {
                bf.Serialize(sw.BaseStream, status);
            }
        }

        public void save(SavedStatus status)
        {
            if (lastPath == null)
            {
                MessageBox.Show("Нельзя сохранить.");
                return;
            }
            saveAs(lastPath, status);
        }

        public SavedStatus load(String path)
        {
            try
            {
                lastPath = path;
                SavedStatus status = null;
                using (var sr = new StreamReader(path))
                {
                    status = (SavedStatus)new BinaryFormatter().Deserialize(sr.BaseStream);
                }
                return status;
            } catch (Exception e)
            {
                return null;
            }
        }
    }
}
