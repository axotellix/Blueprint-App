using Blueprint.Utils.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Security.Policy;
using System.Text;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;


namespace Blueprint.Components.Forms {

    [ToolboxItem(true)]
    public partial class FilePicker : RoundedComponent {

        // styling
        // hover & press effect influence
        private const int HOVER_INFLUENCE = 2;
        private const int PRESS_INFLUENCE = 1;

        private Color BackColor_default;        //: keep Component state
        private Color BorderColor_default;      //: keep Component state


        // main
        private string file_path = string.Empty;

        public string FilePath
        {
            get => file_path;
            private set
            {
                file_path = value;
                FilePathChanged?.Invoke(this, EventArgs.Empty);
            }
        }

        public event EventHandler FilePathChanged;

        public FilePicker()
        {
            InitializeComponent();
            SetupClickHandler();
            this.Load += FilePicker_Load;
        }

        private void SetupClickHandler()
        {
            // Обрабатываем клик по всему компоненту
            this.Click += FilePicker_Click;

            // И по всем дочерним элементам
            foreach (Control control in this.Controls)
            {
                control.Click += FilePicker_Click;
            }
        }

        private void FilePicker_Click(object sender, EventArgs e)
        {
            OpenFileDialog();
        }

        private void OpenFileDialog()
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                // Настройки диалога
                openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.png, *.gif, *.bmp)|*.jpg;*.jpeg;*.png;*.gif;*.bmp|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // copy > selected file to Server
                    string selectedFile = openFileDialog.FileName;
                    CopyFileToResources(selectedFile);

                    // set > file preview image
                    string projectRoot = Directory.GetParent(System.Windows.Forms.Application.StartupPath)
                                    .Parent  // Debug
                                    .Parent  // bin
                                    .Parent  // ProjectName
                                    .FullName;
                    string resourcesPath = Path.Combine(projectRoot, FilePath);
                    FilePreview.Image = System.Drawing.Image.FromFile(resourcesPath);
                }
            }
        }

        private void CopyFileToResources(string sourceFilePath)
        {
            try
            {
                // Путь к папке Resources/img/Products в корне проекта
                string projectRoot = Directory.GetParent(System.Windows.Forms.Application.StartupPath)
                                    .Parent  // Debug
                                    .Parent  // bin
                                    .Parent  // ProjectName
                                    .FullName;
                string resourcesPath = Path.Combine(projectRoot, "Resources", "img", "Products");

                // Создаем папки, если их нет
                if (!Directory.Exists(resourcesPath))
                {
                    Directory.CreateDirectory(resourcesPath);
                }

                // Получаем имя файла с расширением
                string fileName = Path.GetFileName(sourceFilePath);

                // Генерируем уникальное имя файла (чтобы не было конфликтов)
                //string latinFileName = Transliterate(fileName);
                string uniqueFileName = GenerateUniqueFileName(resourcesPath, fileName);
                string destinationPath = Path.Combine(resourcesPath, uniqueFileName);

                // Копируем файл
                File.Copy(sourceFilePath, destinationPath, true);

                // Сохраняем ОТНОСИТЕЛЬНЫЙ путь (рекомендуется)
                FilePath = Path.Combine("Resources", "img", "Products", uniqueFileName);

                // Если нужен абсолютный путь:
                // FilePath = destinationPath;
                MessageBox.Show(FilePath);

                // set > file preview image
                setFilePreview(projectRoot + FilePath);
            }
            catch (Exception ex)
            {
                //MessageBox.Show($"Ошибка при копировании файла: {ex.Message}",
                //                "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //@ helper > set file preview image
        private void setFilePreview(string file_path)
        {
            ImageIcon.Visible = false;
            Placeholder.Visible = false;
            FilePreview.Visible = true;
            FilePreview.Image = System.Drawing.Image.FromFile(file_path);
        }

        //@ helper > cyrillic to latin
        private string Transliterate(string text)
        {
            var translitMap = new Dictionary<string, string>
            {
                {"а", "a"}, {"б", "b"}, {"в", "v"}, {"г", "g"}, {"д", "d"},
                {"е", "e"}, {"ё", "yo"}, {"ж", "zh"}, {"з", "z"}, {"и", "i"},
                {"й", "y"}, {"к", "k"}, {"л", "l"}, {"м", "m"}, {"н", "n"},
                {"о", "o"}, {"п", "p"}, {"р", "r"}, {"с", "s"}, {"т", "t"},
                {"у", "u"}, {"ф", "f"}, {"х", "h"}, {"ц", "ts"}, {"ч", "ch"},
                {"ш", "sh"}, {"щ", "sch"}, {"ъ", ""}, {"ы", "y"}, {"ь", ""},
                {"э", "e"}, {"ю", "yu"}, {"я", "ya"},
                {"А", "A"}, {"Б", "B"}, {"В", "V"}, {"Г", "G"}, {"Д", "D"},
                {"Е", "E"}, {"Ё", "Yo"}, {"Ж", "Zh"}, {"З", "Z"}, {"И", "I"},
                {"Й", "Y"}, {"К", "K"}, {"Л", "L"}, {"М", "M"}, {"Н", "N"},
                {"О", "O"}, {"П", "P"}, {"Р", "R"}, {"С", "S"}, {"Т", "T"},
                {"У", "U"}, {"Ф", "F"}, {"Х", "H"}, {"Ц", "Ts"}, {"Ч", "Ch"},
                {"Ш", "Sh"}, {"Щ", "Sch"}, {"Ъ", ""}, {"Ы", "Y"}, {"Ь", ""},
                {"Э", "E"}, {"Ю", "Yu"}, {"Я", "Ya"}
            };

            string result = "";
            foreach (char c in text)
            {
                string charStr = c.ToString();
                if (translitMap.ContainsKey(charStr))
                    result += translitMap[charStr];
                else if (char.IsLetterOrDigit(c) || c == '.' || c == '_' || c == '-')
                    result += c;
                else
                    result += "_"; // Заменяем спецсимволы на подчеркивание
            }
            return result;
        }

        private string GenerateUniqueFileName(string directoryPath, string fileName)
        {
            string nameWithoutExt = Path.GetFileNameWithoutExtension(fileName);
            string extension = Path.GetExtension(fileName);
            string newFileName = fileName;
            int counter = 1;

            // Если файл с таким именем уже существует, добавляем число
            while (File.Exists(Path.Combine(directoryPath, newFileName)))
            {
                newFileName = $"{nameWithoutExt}_{counter}{extension}";
                counter++;
            }

            return newFileName;
        }

        // Метод для очистки выбранного файла
        public void ClearSelection()
        {
            FilePath = string.Empty;
        }

        // Метод для ручной установки файла (если нужно)
        public void SetFilePath(string path)
        {
            if (File.Exists(path))
            {
                FilePath = path;
            }
        }

        private void FilePreview_Layout(object sender, LayoutEventArgs e)
        {
            ImageIcon.Size = new Size(48, 31);
            ImageIcon.Location = new Point(160, 70);
            FilePreview.Size = new Size(348, 182);
            FilePreview.Location = new Point(17, 20);

            FilePreview.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void ImageIcon_Layout(object sender, LayoutEventArgs e)
        {
            ImageIcon.Size = new Size(48, 31);
            ImageIcon.Location = new Point(160, 70);
            FilePreview.Size = new Size(348, 182);
            FilePreview.Location = new Point(17, 20);

            FilePreview.SizeMode = PictureBoxSizeMode.Zoom;
        }


        /* ---- [ STYLING ] ---- */
        private void FilePicker_Load(object sender, EventArgs e)
        {
            Placeholder.ForeColor = GlassUIColors.Grey;
            ImageIcon.Size = new Size(48, 31);
            ImageIcon.Location = new Point(160, 70);
            FilePreview.Size = new Size(348, 182);
            FilePreview.Location = new Point(17, 20);

            FilePreview.SizeMode = PictureBoxSizeMode.Zoom;

            // register > events
            this.MouseEnter += SetStyleHover;
            Placeholder.MouseEnter += SetStyleHover;
            ImageIcon.MouseEnter += SetStyleHover;
            FilePreview.MouseEnter += SetStyleHover;

            this.MouseLeave += SetStyleHoverOut;
            Placeholder.MouseLeave += SetStyleHoverOut;
            ImageIcon.MouseLeave += SetStyleHoverOut;
            FilePreview.MouseLeave += SetStyleHoverOut;

            this.MouseDown += SetStylePress;
            Placeholder.MouseDown += SetStylePress;
            ImageIcon.MouseDown += SetStylePress;
            FilePreview.MouseDown += SetStylePress;

            this.MouseUp += SetStylePressOut;
            Placeholder.MouseUp += SetStylePressOut;
            ImageIcon.MouseUp += SetStylePressOut;
            FilePreview.MouseUp += SetStylePressOut;

            // set > component style
            SetStyle();
        }

        private void SetStyle()
        {
            this.BorderColor = GlassUIColors.GreyBorder;
            this.BackColor = GlassUIColors.GreyDark;
            this.BorderWidth = 1;
            BackColor_default = this.BackColor;
            BorderColor_default = this.BorderColor;
        }
        //@ helper > set button style (icon, appearance)
        private void SetStyleHover(object sender, EventArgs e)
        {
            this.BackColor = BackColor_default.Lighten(HOVER_INFLUENCE);
            this.BorderColor = BorderColor_default.Lighten(HOVER_INFLUENCE);
        }

        //@ helper > set button style (icon, appearance)
        private void SetStyleHoverOut(object sender, EventArgs e)
        {
            this.BackColor = BackColor_default;
            this.BorderColor = BorderColor_default;
        }

        //@ helper > set button style (icon, appearance)
        private void SetStylePress(object sender, EventArgs e)
        {
            this.BackColor = BackColor_default.Lighten(PRESS_INFLUENCE);
            this.BorderColor = BorderColor_default.Lighten(PRESS_INFLUENCE);
        }

        //@ helper > set button style (icon, appearance)
        private void SetStylePressOut(object sender, EventArgs e)
        {
            this.BackColor = BackColor_default.Lighten(HOVER_INFLUENCE);
            this.BorderColor = BorderColor_default.Lighten(HOVER_INFLUENCE);
        }

    }
}
