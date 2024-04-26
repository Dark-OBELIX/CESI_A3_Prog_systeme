﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Net.Sockets;
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

namespace p7
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
		

		public MainWindow()
        {
            InitializeComponent();

			

		}
		
		// Méthode qui initialise la barre de progression 
		void worker_DoWork(object sender, DoWorkEventArgs e)
		{
			for (int i = 1; i <= 100; i++)
			{
				(sender as BackgroundWorker).ReportProgress(i);
				
				Thread.Sleep(2000);
				
			}
		}

		void worker_ProgressChanged(object sender, ProgressChangedEventArgs e)
		{   
			//initialisation de la barre de progression avec le pourcentage de progression
			pbstatus1.Value   = e.ProgressPercentage;

			//Affichage de la progression sur un label
			lb_etat_prog_server.Content = pbstatus1.Value.ToString() +"%";

			
			
		}

		// lancer la barre de progression en créant un objet de type BackgroundWorker
		//BackgroundWorker :
		private void Button_Click(object sender, RoutedEventArgs e)
        {
			//création, initialisation et mise à jour de l'objet BackgroundWorker
			BackgroundWorker worker = new BackgroundWorker();
			worker.WorkerReportsProgress = true;
			worker.DoWork += worker_DoWork;
			worker.ProgressChanged += worker_ProgressChanged;
			worker.RunWorkerAsync();
		}

		

	}
}
