﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD_WSR
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // метод передвижения программы
            Panel_Location();
            // кнопка закрытия программы
            btn_Close.Click += (s, e) => { Close(); };
            // показать панель редактирования 
            switch_notes.Click += (s, e) => { Panel(pnl_Edit); };
            // показать панель БД
            switch_View.Click += (s, e) => { Panel(pnl_View); };
            // показать панель таблицы триггера
            switch_deleted.Click += (s, e) => { Panel(pnl_Deleted); };
        }
        // строка подключения к БД
        static string myConnection = ConfigurationManager.ConnectionStrings["DbConnection"].ConnectionString;
        // метод добаление записей в БД
        public bool Insert()
        {
            bool isSuccess = false;
            try
            {
                string query = $"INSERT INTO db_User ([Имя], [Фамилия], [Группа], [instgram]) VALUES ('{txt_name.Text}', '{txt_surname.Text}', '{txt_instgram.Text}', '{txt_group.Text}')";
                using (SqlConnection sql = new SqlConnection(myConnection))
                {
                    sql.Open();
                    SqlCommand command = new SqlCommand(query, sql);
                    int row = command.ExecuteNonQuery();
                    isSuccess = row > 0 ? true : false;
                    ClearRow();
                }
            }
            catch (Exception ex) { MessageBox.Show("Косяк", ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error); }
            return isSuccess;
        }
        // метод очитски полей
        void ClearRow()
        {
            txt_name.Text = "";
            txt_surname.Text = "";
            txt_instgram.Text = "";
            txt_group.Text = "";
        }
        //метод переключения между панелями
        void Panel(Panel panel) { panel.BringToFront(); }
        // метод передвижения формы
        void Panel_Location()
        {
            int move = 0, moveX = 0, moveY = 0;
            pnl_Top.MouseDown += (s, e) => { move = 1; moveX = e.X; moveY = e.Y; };
            pnl_Top.MouseMove += (s, e) => { if (move == 1) SetDesktopLocation(MousePosition.X - moveX, MousePosition.Y - moveY); };
            pnl_Top.MouseUp += (s, e) => { move = 0; };
        }

        // сообщение
        void Message(string line)
        {
            MessageBox.Show(line, "Уведомление системы!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void Btn_add_Click(object sender, EventArgs e)
        {
            bool success = Insert();
            Message(success ? "Данные успешно отправлены в Базе Данных." : "Данные не отправлены в Бвзу Данных. Косяк брат!");
        }
    }
}
