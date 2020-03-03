using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace VisualTasking
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            CreateTask();

        }
        void CreateTask()
        {
            Task t = new Task(new Action(ShowMessage));
            Task t2 = new Task(new Action(() => MessageBox.Show("Mensaje con arrow Function")));
            Task t3 = new Task((message) => MessageBox.Show(message.ToString()), "valor de message");
            Task t4 = new Task(new Action(() => AddMessage("Mensajito de tarea...")));
            t4.Start();
            AddMessage("Tarea del hilo principal...");
            //Iniciar y ejecutar tareas en un solo paso            
            Task t6 = Task.Factory.StartNew(() => AddMessage("Esta tarea es con Task.Factory.StartNew(()=>{})..."));
            Task t8 = Task.Run(() => AddMessage("Esta tarea es con Task.Run(()=>{})..."));

        }
        void AddMessage(string mensaje)
        {
            int hiloTarea = Thread.CurrentThread.ManagedThreadId;
            this.Dispatcher.Invoke(() =>
            {
                Message.Content += $"Mensaje: {mensaje}" +
                $"Hilo actual: {hiloTarea}\n";
            });
        }


        void ShowMessage()
        {
            this.Dispatcher.Invoke(() =>
            {
                Message.Content += "Ejecutando metodo showmessage \n";
            });
        }
    }
}
