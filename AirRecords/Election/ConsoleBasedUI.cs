using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Election
{
    class ConsoleBasedUI : IUserInterface
    {
        private ICyclistFileReader IOhandler;
        private ConfigData configData;
        private ConstituencyList cyclistList;

        public ConsoleBasedUI(ICyclistFileReader IOhandler)
        {
            this.IOhandler = IOhandler;
            this.configData = null;
            this.cyclistList = null;
        }

        public void Run()
        {
            SetupConfigData();
            
            RunProducerConsumer();

            DisplayCyclists();

            Console.WriteLine("Press any key to close");
            Console.ReadKey();
        }

        public void SetupConfigData()
        {
            // Make sure configData is a new empty object
            configData = new ConfigData();

            // Generate configuration data (filename and required fitreport for each cyclist)
            configData.configRecords.Add(new ConfigRecord("Candidate-01.xml"));
            configData.configRecords.Add(new ConfigRecord("Candidate-02.xml"));
            configData.configRecords.Add(new ConfigRecord("Candidate-03.xml"));
            configData.configRecords.Add(new ConfigRecord("Candidate-04.xml"));
            configData.configRecords.Add(new ConfigRecord("Candidate-05.xml"));
        }

        public void RunProducerConsumer()
        {
            //Create cyclist list to hold individual cyclist objects read from datasets
            cyclistList = new ConstituencyList();

            // Create progress manager with number of files to process
            ProgressManager progManager = new ProgressManager(configData.configRecords.Count);

            // Output message to indicate that the program has started
            Console.WriteLine("=================================================");
            Console.WriteLine("Creating and starting all producers and consumers");
            Console.WriteLine("=================================================");
            Console.WriteLine();

            // Create a PCQueue instance, give it a capacity of 4
            var pcQueue = new PCQueue(4);

            // Create 2 Producer instances and 2 Consumer instances, these will begin executing on
            // their respective threads as soon as they are instantiated
            Producer[] producers = { new Producer("P1", pcQueue, configData, IOhandler),
                                     new Producer("P2", pcQueue, configData, IOhandler) };

            Consumer[] consumers = { new Consumer("C1", pcQueue, cyclistList, progManager),
                                     new Consumer("C2", pcQueue, cyclistList, progManager) };

            // Keep producing and consuming until all work items are completed
            while (progManager.ItemsRemaining > 0) ;

            // Output message to indicate that the program is shutting down
            Console.WriteLine();
            Console.WriteLine("=========================================");
            Console.WriteLine("Shutting down all producers and consumers");
            Console.WriteLine("=========================================");
            Console.WriteLine();

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
            Console.WriteLine("============================================================");
            Console.WriteLine("All producers and consumers shut down");
            Console.WriteLine("============================================================");
        }

        public void DisplayCyclists()
        {
            // Having finished generating data we can now display cyclist data
            Console.WriteLine();
            Console.WriteLine("============================================================");
            foreach (var cyclist in cyclistList.candidates)
            {
                Console.WriteLine("Candidate read from XML data: {0}", cyclist.ToString());
                Console.WriteLine(cyclist.FitReportInitial.ToString());
                Console.WriteLine(cyclist.FitReportFinal.ToString());
                Console.WriteLine();
            }
            Console.WriteLine();

            // Calculate and output mean asymmetry across all candidates
            Console.WriteLine("============================================================");
            Console.WriteLine("Mean Asymmetry across all candidates\nInitial fit");

            foreach (var measure in cyclistList.calcMeanAsymmetry("Initial"))
            {
                Console.WriteLine("\t{0}", measure.ToString());
            }
            Console.WriteLine();

            Console.WriteLine("Mean Asymmetry across all candidates\nFinal fit");

            foreach (var measure in cyclistList.calcMeanAsymmetry("Final"))
            {
                Console.WriteLine("\t{0}", measure.ToString());
            }
            Console.WriteLine();
            Console.WriteLine("============================================================");
        }
    }
}
