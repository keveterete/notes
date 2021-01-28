using System;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        
        static public string currentTheme;
        static public string currentMessage;
        static public string pathWithFiles = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "FolderWithNotes\\"); //Полный путь до папки C:/Users/username/MyDocuments/FolderWithNotes/
        public void RefreshList() //Функция обновления листа с файлами
        {
            listWithFiles.Items.Clear();
            DirectoryInfo dir = new DirectoryInfo(pathWithFiles);
            FileInfo[] files = dir.GetFiles("*.txt");
            foreach (FileInfo fi in files)
            {
                var stringFile = fi.ToString();
                var fileWithoutTXT = stringFile.Remove(stringFile.Length - 4, 4);
                listWithFiles.Items.Add(fileWithoutTXT);
            }
        }
        public Form1()
        {
            InitializeComponent();
            bool existingDirectory = Directory.Exists(pathWithFiles);
            if (!existingDirectory) Directory.CreateDirectory(pathWithFiles);

       

        }

        private void button1_Click(object sender, EventArgs e) //Функция создания файла
        {
            Note newfile = new Note();
            newfile.Owner = this;
            newfile.ShowDialog();

        }

        public void Form1_Load(object sender, EventArgs e) 
        {
            RefreshList();

        }


        public void Sort(object sender, EventArgs e)
        {
            FileInfo[] SortOfDate(FileInfo[] file)
            {
                Array.Sort(file, new Comparison<FileInfo>((f, f2) => f.CreationTime.CompareTo(f2.CreationTime)));
                return file;
            }

        }
        //FileInfo[] SortOfName(FileInfo[] file)
        //{

        //    Array.Sort(file, (f1, f2) => f1.Name.CompareTo(f2.Name));
        //    return file;
        //}
        private void openfile_Click(object sender, EventArgs e) //Кнопка загрузки файла
        {
            Note loaded = new Note();
            loaded.Owner = this;
            try
            {
                string nameOfFile = Path.GetFileNameWithoutExtension(pathWithFiles + listWithFiles.SelectedItem.ToString());
                loaded.loadFileTema = nameOfFile;
                loaded.loadFileMessage = File.ReadAllText(Path.Combine(pathWithFiles, listWithFiles.SelectedItem.ToString()) + ".txt");
                loaded.ShowDialog();
            }
            catch (NullReferenceException) //Нужно ли это теперь?
            {
                MessageBox.Show("Выберите файл!");
          }
        }

        private void delet_Click(object sender, EventArgs e) //Кнопка удаления файла (Конт меню)

        {
            try
            {
                string directoryOfFile = Path.Combine(pathWithFiles, listWithFiles.SelectedItem.ToString() + ".txt");

                File.Delete(directoryOfFile);
            }
            catch (NullReferenceException) 
            {
                MessageBox.Show("Выберите файл!");
            }

            listWithFiles.Items.Clear();
            RefreshList();

        }

        private void contextMenuStrip1_Opening(object sender, System.ComponentModel.CancelEventArgs e) { }
        // конт меню правой мыши

        private void contextMenuStrip2_Opening(object sender, System.ComponentModel.CancelEventArgs e) { }

        private void Sorting_MouseClick(object sender, System.ComponentModel.CancelEventArgs e)
        {


        }
    }
}