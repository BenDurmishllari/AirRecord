using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Election
{
    public partial class FormsBasedUI : Form, IUserInterface
    {
        public IConstituencyFileReader IOhandler { get; set; }
        private ConfigData configData;
        private LocationList constituencyList;

        private String selectedReportType;

        public FormsBasedUI(IConstituencyFileReader IOhandler)
        {
            InitializeComponent();
            this.IOhandler = IOhandler;
        }

        private void FormsBasedUI_Load(object sender, EventArgs e)
        {
        }

        public void SetupConfigData()
        {
            // Make sure configData is a new empty object
            configData = new ConfigData();

            // Generate configuration data (filename and required fitreport for each cyclist)
            configData.configRecords.Add(new ConfigRecord("Quaside.xml"));
            configData.configRecords.Add(new ConfigRecord("Sunderland.xml"));
            configData.configRecords.Add(new ConfigRecord("Liverpool.xml"));
            configData.configRecords.Add(new ConfigRecord("Manchester.xml"));
        }

        public void RunProducerConsumer()
        {
            //Create cyclist list to hold individual cyclist objects read from datasets
            constituencyList = new LocationList();

            // Create progress manager with number of files to process
            ProgressManager progManager = new ProgressManager(configData.configRecords.Count);

            // Output message to indicate that the program has started
            progressLbl.Text = "Creating and starting all producers and consumers";

            // Create a PCQueue instance, give it a capacity of 4
            var pcQueue = new PCQueue(4);

            // Create 2 Producer instances and 2 Consumer instances, these will begin executing on
            // their respective threads as soon as they are instantiated
            Producer[] producers = { new Producer("P1", pcQueue, configData, IOhandler),
                                     new Producer("P2", pcQueue, configData, IOhandler) };

            Consumer[] consumers = { new Consumer("C1", pcQueue, constituencyList, progManager),
                                     new Consumer("C2", pcQueue, constituencyList, progManager) };

            // Keep producing and consuming until all work items are completed
            while (progManager.ItemsRemaining > 0) ;

            // Output message to indicate that the program is shutting down
            progressLbl.Text = "Shutting down all producers and consumers";

            // Deactivate the PCQueue so it does not prevent waiting producer and/or consumer threads
            // from completing
            pcQueue.Active = false;

            // Iterate through producers and signal them to finish
            foreach (var p in producers)
            {
                p.Finished = true;
            }

            // Iterate through consumers and signal them to finish
            foreach (var c in consumers)
            {
                c.Finished = true;
            }

            // We need to ensure that no thread waiting on Monitor.Wait() is stranded with
            // no Monitor.Pulse() now possible since all producer and consumer threads have
            // been signalled to stop, in the worse case all such threads could be stranded
            // so pulse that many times to ensure enough pulses are made available (or the
            // program can halt erroneously), wasted pulse are simply ignored 
            for (int i = 0; i < (Producer.RunningThreads + Consumer.RunningThreads); i++)
            {
                lock (pcQueue)
                {
                    // Pulse the PCQueue to signal any waiting threads
                    Monitor.Pulse(pcQueue);

                    // Give a short break to the main thread so the pulses have time to be
                    // detected by any potentially waiting producer and/or consumer threads
                    Thread.Sleep(100);
                }
            }

            // Once all producer and consumer threads have finally finished we can gracefully
            // shutdown the main thread, this is achieved by spinning on a while() loop until
            // there are no running threads, in this case we do not mind the main thread
            // spinning as we are about to shutdown the program
            while ((Producer.RunningThreads > 0) || (Consumer.RunningThreads > 0)) ; // Wait by spinning

            Console.WriteLine();
            progressLbl.Text = "All producers and consumers shut down";
        }

        public void DisplayLocations()
        {
            // Clear any items in listbox
            LocationListbox.Items.Clear();

            // Having finished generating data we can now display constituency data on form
            foreach (var constituency in constituencyList.Locations)
            {
                LocationListbox.Items.Add(constituency);
                LocationListbox.Sorted = true;
            }
        }

        public void DisplayParties()
        {
            // Clear any items in listbox
            partyListbox.Items.Clear();

            // Having finished generating data we can now display constituency data on form
            foreach (var party in constituencyList.CalculateTotalParticulates())
            {
                partyListbox.Items.Add(party);

            }

            
        }

        private void configBtn_Click(object sender, EventArgs e)
        {
            // Clear any items in listbox
            LocationListbox.Items.Clear();

            SetupConfigData();

            // Update form object properties
            progressLbl.Text = "Config data loaded. Waiting for user to press load";
            RunProducerConsumerBtn.Enabled = true;
            constituencyBtn.Enabled = false;
            partiesBtn.Enabled = false;
            configBtn.Enabled = false;
        }

        private void RunProducerConsumerBtn_Click(object sender, EventArgs e)
        {
            // Clear any items in listbox
            LocationListbox.Items.Clear();

            progressLbl.Text = "Obtaining data. Please wait";
            progressLbl.Refresh();

            // Run producer consumer to load cyclist data
            RunProducerConsumer();

            // Update form object properties
            progressLbl.Text = "Candidate data loaded";
            constituencyBtn.Enabled = true;
            partiesBtn.Enabled = true;
            RunProducerConsumerBtn.Enabled = false;
        }

        private void constituenciesBtn_Click(object sender, EventArgs e)
        {
            DisplayLocations();
        }

        private void partiesBtn_Click(object sender, EventArgs e)
        {
            DisplayParties();
        }

        private void constituencyListbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Clear any items in listbox
            candidateListbox.Items.Clear();

            Location constituency = (Location) LocationListbox.SelectedItem;

            // Having finished generating data we can now display party data on form
            foreach (var c in constituency.Particulates)
            {
                candidateListbox.Items.Add(c);
            }
        }

        
    }
}
