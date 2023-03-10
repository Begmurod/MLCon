
// This file was auto-generated by ML.NET Model Builder. 

using MlConsoleApp2;

Console.WriteLine("Средняя температура периферийных газов °С");
Console.WriteLine("Введите дату в формате ДД.ММ.ГГГГ");
string[]data_date = new string[] { "31.12.2022  0:00:00", "31.12.2022  8:00:00", "31.12.2022  16:00:00" };

for (int i = 0; i < data_date.Length; i++)
{
    string data = data_date[i];
    Console.WriteLine(data);

    // Create single instance of sample data from first line of dataset for model input
    MLModel1.ModelInput sampleData = new MLModel1.ModelInput()
    {
        Date = data,
  
    };

    // Make a single prediction on the sample data and print results
    var predictionResult = MLModel1.Predict(sampleData);

    Console.WriteLine($"\n\nПрогнозируемое значение за {data}: {predictionResult.Score}\n\n");
    Console.WriteLine("=============== End of process, hit any key to finish ===============");
    Console.ReadKey();
}