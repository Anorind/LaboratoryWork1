using static System.Runtime.InteropServices.JavaScript.JSType;

namespace LaboratoryWork1
{
//    Задание 1
//Вывести на экран свое(краткое!!!) резюме с помощью последовательности
//MessageBox’ов(числом не менее трех). Причем на заголовке последнего должно
//отобразиться общее количество символов в резюме / количество MessageBox’ов.

    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Text = "Form1";
            ShowResume();
        }
        private void ShowResume()
        {
            string fullName = "Моє повне ім'я: Анорін Данило Олександрович";
            string cityBorn = "Я народився в місті Ізмаїл";
            string myAge = "Мені 31 рік";
            DialogResult fullNameBox = MessageBox.Show(fullName, "Ф.І.О.", MessageBoxButtons.OK);
            DialogResult cityBornBox = MessageBox.Show(cityBorn, "Місце народження", MessageBoxButtons.OK);
            DialogResult ageBox = MessageBox.Show(myAge, "Вік", MessageBoxButtons.OK);

            DialogResult finalBox = MessageBox.Show($"Всього було використано символів в попередніх Meesage Box'ах: {(fullName.Length+cityBorn.Length+ myAge.Length).ToString()}", "Кількість MessageBox Всього: 4", MessageBoxButtons.OK);

            Environment.Exit(0);
        }
        #endregion
    }
}