using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


    public class DataProcessingService
    {
        private readonly IDataProcessor _dataProcessor;
        public DataProcessingService(IDataProcessor dataProcessor)
        {
            _dataProcessor = dataProcessor;
        }
        public void ProcessInput(string input)
        {
            string processedData = _dataProcessor.Process(input);
            Console.WriteLine($"Processed Data: {processedData}");
        }
    }