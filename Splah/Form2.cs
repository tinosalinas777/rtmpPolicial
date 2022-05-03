using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Splah
{
    public partial class Form2 : Form
    {

        public Form2()
        {
            InitializeComponent();
            vlcControl1.Video.IsMouseInputEnabled = true;
            vlcControl1.Video.IsKeyInputEnabled = true;
            
            vlcControl1.VlcMediaPlayer.Video.FullScreen = true;
            vlcControl1.VlcMediaPlayer.Video.IsKeyInputEnabled = true;
            vlcControl1.VlcMediaPlayer.Video.IsMouseInputEnabled = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            vlcControl1.CreateControl();
            vlcControl1.Video.FullScreen = true;
;       }

        private void Form2_Load(object sender, EventArgs e)
        {
            textBox1.Text = "rtmp://192.168.1.128:1935/live/test";//direccion por defecto del servidor rtmp
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try     //try y catch atrapan ecepcion no controlada
            {
                vlcControl1.Play(new Uri(textBox1.Text));//reproduce variable textBox1.Text
            }
            catch(Exception)
            {
                MessageBox.Show("No ingreso un servidor");
                return;
            }
            
        }
        //funcion para pausar o continuar el video
        private void button2_Click(object sender, EventArgs e)
        {
            if(button2.Text=="parar")//los condicionales if cambian la leyenda del boton2
            {
                vlcControl1.Pause();
                button2.Text = "Iniciar";

            }
            else if(button2.Text=="Iniciar")
            {
                vlcControl1.Play();
                button2.Text = "parar";
            }
        }
        //funcion para detener la reproduccion del streaming
        private void button3_Click(object sender, EventArgs e)
        {
            vlcControl1.Stop();
            
        }
    }
}
