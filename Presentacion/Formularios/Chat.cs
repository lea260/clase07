﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio.Modelo;
using Negocio.Objetos;


namespace Presentacion.Formularios
{
    public partial class Chat : Form
    {
        System.Timers.Timer t;
        public Chat()
        {
            InitializeComponent();
            InitChat();
        }
        private void InitChat()
        {
            //
            List<DataChat> list = null;
            Mensaje chat = new Mensaje();
            list = chat.ObtenerMensajes(1);
            string mensaje= "vacio";
            //llenar listbox.
            lstChat.Items.Add("hasdfsdf");

        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            string text = txtMensaje.Text;
            if (!string.IsNullOrEmpty(text))
            {
                lstChat.Items.Add(text);
                lstChat.SelectedIndex = lstChat.Items.Count - 1;
            }           
        }


        private void listChat_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Chat_Load(object sender, EventArgs e)
        {
            t = new System.Timers.Timer();
            t.Interval = 1000;//1s
            t.Elapsed += On_TimeEvent;
        }

        private void On_TimeEvent(object sender, System.Timers.ElapsedEventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
 