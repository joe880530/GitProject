using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileManager_JH
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            FileManager _FileManager = new FileManager();

            //_FileManager.FilePath = "서울시 서대문구 연희 3동 ";
            //_FileManager.FileName = "BaBo";
            //_FileManager.FileType

            //_FileManager.Delete();

            //_FileManager.Delete_File();
            _FileManager.Delete_File("Wa");
        }
    }
}
