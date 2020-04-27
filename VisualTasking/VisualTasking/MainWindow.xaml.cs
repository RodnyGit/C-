using System;
using System.Collections.Generic;
using System.Diagnostics;
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
        CancellationTokenSource CTS;
        CancellationToken CT;
        Task longRunningTask;

        public MainWindow()
        {
            InitializeComponent();
            //CreateTask();
        }
        void CreateTask()
        {
            #region Distintas maneras de crear tareas

            Task t = new Task(new Action(ShowMessage));
            Task t2 = new Task(new Action(() => MessageBox.Show("Mensaje con arrow Function")));
            Task t3 = new Task((message) => MessageBox.Show(message.ToString()), "valor de message");
            Task t4 = new Task(new Action(() => AddMessage("Mensajito de tarea...")));
            t4.Start();
            AddMessage("Tarea del hilo principal...");
            //Iniciar y ejecutar tareas en un solo paso
            Task t6 = Task.Factory.StartNew(() => AddMessage("Esta tarea es con Task.Factory.StartNew(()=>{})..."));
            Task t8 = Task.Run(() => AddMessage("Esta tarea es con Task.Run(()=>{})..."));
            #endregion

            #region Esperando tareas

            //creando tarea
            Task t9 = new Task(new Action(() =>
            {
                WriteToOuput("Iniciando tarea 9");
                Thread.Sleep(5000);
                WriteToOuput("Terminando tarea 9");
            }));
            //iniciando tarea
            t9.Start();
            //esperando tarea
            t9.Wait();


            RunTaskGroup();
            #endregion

            TareaConRetorno();

        }
        #region Task con retorno

        void TareaConRetorno()
        {
            Task<int> T = Task.Run((new Func<int>(() =>
            {
                WriteToOuput("Creando el numero aleatorio ");
                Thread.Sleep(3000);
                return new Random().Next(1000);
            })));
            WriteToOuput("El valor aleatorio es " + Convert.ToString(T.Result));
        }

        #endregion

        #region Metodos

        void RunTaskGroup()
        {
            Task[] TaskGroup = new Task[]
            {
                Task.Run(()=>RunTask(1)),
                Task.Run(()=>RunTask(2)),
                Task.Run(()=>RunTask(3)),
                Task.Run(()=>RunTask(4))
            };
            WriteToOuput("Esperando todas las tareas...");
            Task.WaitAny(TaskGroup);
            WriteToOuput("Finalizadas todas las tareas...");
        }

        void RunTask(byte numero)
        {
            WriteToOuput($"Iniciando tarea: {numero}");
            Thread.Sleep(2000);
            WriteToOuput($"Terminando tarea: {numero}");
        }

        void WriteToOuput(string mensaje)
        {
            Debug.WriteLine($"Mensaje: {mensaje}, " +
                $"Hilo actual: { Thread.CurrentThread.ManagedThreadId}\n");
        }

        void AddMessage(string mensaje)
        {
            int hiloTarea = Thread.CurrentThread.ManagedThreadId;
            this.Dispatcher.Invoke(() =>
            {
                Message.Content += $"Mensaje: {mensaje} --" +
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
        #endregion

        #region MetodosVisual

        private void Stop_Click(object sender, RoutedEventArgs e)
        {
            if (CTS != null)
                CTS.Cancel();
            else
                AddMessage("No hay CTS");
        }

        private void Status_Click(object sender, RoutedEventArgs e)
        {
            if (CTS != null)
                AddMessage(longRunningTask.Status.ToString());
            else
                AddMessage("No hay CTS");

        }

        private void Start_Click(object sender, RoutedEventArgs e)
        {
            CTS = new CancellationTokenSource();
            CT = CTS.Token;
            Task.Run(() =>
            {
                longRunningTask = Task.Run(() =>
                {
                    DoLongRunTask(CT);
                }, CT);
                try
                {
                    longRunningTask.Wait();
                }
                catch (AggregateException ex)
                {
                    foreach (var item in ex.InnerExceptions)
                    {
                        if (item is TaskCanceledException)
                            AddMessage("Excepcion de cancelacion capturada");
                        else
                            AddMessage(item.Message);
                    }
                }
            });

        }

        private void DoLongRunTask(CancellationToken CT)
        {
            int i = 0;
            while ((i < 700) && (!CT.IsCancellationRequested))
            {
                i = new Random().Next(1000);
                AddMessage(i.ToString());
                Thread.Sleep(2000);
            }
            if (CT.IsCancellationRequested)
            {
                //Logica de cancelacion
                AddMessage("Proceso cancelado");
                CT.ThrowIfCancellationRequested();
            }
        }
        #endregion
    }
}
