using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Diagnostics;
using System.Windows.Forms;

using System.IO;

namespace FileManager_JH
{
    class FileManager
    {
        #region 기본값(외부에서 접근 금지)
        private string str_FileName = "N/A";
        private string str_FilePath = "N/A";
        private string str_FileType = ".jpg"; 
        #endregion

        public string FileName
        {
            get
            {
                //출력
                return str_FileName;
            }
            set
            {
                //입력
                str_FileName = value;
            }
        }

        public string FilePath
        {
            get
            {
                //출력
                return str_FilePath;
            }
            set
            {
                //입력
                str_FilePath = value;
            }
        }

        public string FileType
        {
            get
            {
                return str_FileType;
            }
            set
            {
                str_FileType = value;
            }
        }

        private void Create()
        {


            MessageBox.Show(FilePath + FileName + FileType);
            //MessageBox.Show("Create");
        }

        private void Copy()
        {
            MessageBox.Show("Copy");
        }

        public void Delete()
        {
            MessageBox.Show("Delete");
        }

        public bool Delete_File(string str_Delete_File_Name)
        {
            bool return_Value = false;

            FileInfo File = new FileInfo(str_Delete_File_Name);

            if (File != null)
            {
                File.Delete();
            }

            if(File.Exists == true)
            {
                return_Value = false;
            }
            else
            {
                return_Value = true;
            }

            return return_Value;
        }

        public void Delete_Folder()
        {
            Console.WriteLine("test 구문");
            MessageBox.Show("Delete Folder");
            MessageBox.Show("Delete Folder2");
            MessageBox.Show("Delete Folder3");
        }
    }
}
